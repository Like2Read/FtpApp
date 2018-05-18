using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Threading;
using System.Diagnostics;

namespace FtpApp
{
    public enum FtpLoaderStates { No = 0, Downloading = 1, Downloaded = 2, Failed = 3 }
    public enum FtpResultCode { OK = 0, Error = 1 }
    public class FtpResult
    {
        public FtpResultCode Code { get; set; }
        public string Message { get; set; }
    }

    public class LoaderEventArgs : EventArgs
    {
        public ProgressInformation Progress { get; }

        public LoaderEventArgs(ProgressInformation progress) {
            Progress = progress;
        }
    }

    public class FtpLoader
    {
        private string _filePath;
        private string _ftpPath;
        private long _fileSize;
        private IWebProxy _proxy;
        private CancellationToken _token;
        private ICredentials _credentials;
        private long _processed;
        private long Processed { get => _processed; set { _processed = value; RaiseProcessedChangedEvent(); } }

        private int _bufferSize;
        private string _lastError;
        private Stopwatch _stopWatch = new Stopwatch();

        public string ErrorMessage { get => State == FtpLoaderStates.Failed ? _lastError : string.Empty; }

        public FtpLoaderStates State { get; private set; }

        public ProgressInformation ProgressInformation { get => GetProgressInformation(); }

        public event EventHandler ProgressChanged;

        private ProgressInformation GetProgressInformation()
        {
            return new ProgressInformation(_fileSize, _processed, (long)_stopWatch.ElapsedMilliseconds/1000);
        }

        public FtpLoader(string filePath, string ftpPath, IWebProxy proxy, ICredentials credentials, CancellationToken token, int bufferSize)
        {
            _filePath = filePath;
            _ftpPath = ftpPath;
            _proxy = proxy;
            State = FtpLoaderStates.No;
            _token = token;
            _credentials = credentials;
            _bufferSize = bufferSize;
        }

        private FtpWebRequest GetRequest(string method)
        {
            var request = (FtpWebRequest)FtpWebRequest.Create(new Uri(_ftpPath));
            request.UseBinary = true;
            request.Timeout = 10000;
            request.Proxy = _proxy;
            if (_credentials != null)
                request.Credentials = _credentials;
            request.Method = method;

            return request;
        }

        public async Task<bool> IsValid()
        {
            try
            {
                var request = GetRequest(WebRequestMethods.Ftp.GetFileSize);
                using (FtpWebResponse response = (FtpWebResponse) await request.GetResponseAsync())
                {
                    _fileSize = response.ContentLength;
                    response.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                State = FtpLoaderStates.Failed;
                _lastError = ex.Message;
                return false;
            }

        }

        
        public FtpResult TryDownload()
        {
            State = FtpLoaderStates.Downloading;
            var result = new FtpResult() { Code = 0, Message = "" };
            try
            {

                _stopWatch.Start();
                var request = GetRequest(WebRequestMethods.Ftp.DownloadFile);
                using (var fileStream = File.Create(_filePath))
                {
                    using (var stream = request.GetResponse().GetResponseStream())
                    {
                        foreach (var buffer in stream.ReadAsEnumerable(_bufferSize))
                        {
                            _token.ThrowIfCancellationRequested();

                            fileStream.WriteAsync(buffer, 0, buffer.Length);
                            Processed += buffer.Length;
                        }
                    }
                    fileStream.Close();
                    State = FtpLoaderStates.Downloaded;
                }
                Processed = _fileSize;
                _stopWatch.Stop();
            }
            catch (Exception ex)
            {
                ClearDownloaded();
                //log error;
                State = FtpLoaderStates.Failed;
                result.Code = FtpResultCode.Error;
                result.Message = ex.Message;
                _lastError = ex.Message;
                Processed = 0;
                _stopWatch.Reset();
            }
            return result;
        }

        private void ClearDownloaded()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    File.Delete(_filePath);
                }
                catch (Exception ex2)
                {
                    //log error
                }
            }
        }

        private void RaiseProcessedChangedEvent()
        {
            var eventHandler = ProgressChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new LoaderEventArgs(GetProgressInformation()));
            }
        }
    }
}
