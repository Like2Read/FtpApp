using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FtpApp
{
    public partial class FormMain : Form
    {
        private CancellationTokenSource _source;
        private int _bufferSize = 32768;

        public FormMain()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
                progressBar1.Value = 0;
                IWebProxy proxy = null;
                _source = new CancellationTokenSource();
                var fileName = Path.GetFileName(txtFile.Text);
                var loader = new FtpLoader(Path.Combine(txtOutput.Text, fileName), txtFile.Text, proxy, null, _source.Token, _bufferSize);
                if (await loader.IsValid())
                {
                    loader.ProgressChanged += Loader_ProgressChanged;

                    btnLoad.Enabled = false;
                    btnCancel.Enabled = true;
                    lTotalValue.Text = loader.ProgressInformation.Total.ToString();
                    progressBar1.Maximum = 100;

                    var result = await Task.Run(() => loader.TryDownload());

                    if (result.Code == FtpResultCode.OK)
                    {
                        MessageBox.Show($"File {fileName} was saved to {txtOutput.Text}", "Success");
                    }
                    else {
                        MessageBox.Show($"Failed to download or was cancelled", "Error");    
                    }

                    loader.ProgressChanged -= Loader_ProgressChanged;
                    btnLoad.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else
                    MessageBox.Show(loader.ErrorMessage, "Error");
        }

        private void CallUpdateProgressInfo(ProgressInformation info)
        {
            try
            {

                if (InvokeRequired)
                    Invoke((Action<ProgressInformation>)UpdateProgressInfo, new object[] { info });
                else
                    UpdateProgressInfo(info);
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        private async void Loader_ProgressChanged(object sender, EventArgs e)
        {
            if (e is LoaderEventArgs args)
            {
                await Task.Run(() => CallUpdateProgressInfo(args.Progress));
            }
        }

        private void UpdateProgressInfo(ProgressInformation info)
        {
            try
            {
                lCopiedValue.Text = info.Downloaded.ToString();
                progressBar1.Value = info.Progress;
                lRateValue.Text = info.TransferRate.ToString("#.##");
                lEstimatedValue.Text = info.EstimatedTime.ToString();
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _source?.Cancel();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _source?.Cancel();
        }
    }
}
