using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpApp
{
    public static class Helpers
    {
        public static IEnumerable<byte[]> ReadAsEnumerable(this Stream stream, int bufferSize)
        {
            byte[] buffer = new byte[bufferSize];
            int count;
            while ((count = stream.Read(buffer, 0, bufferSize)) > 0)
            {
                if (count < bufferSize)
                    Array.Resize<byte>(ref buffer, count);
                yield return buffer;

                buffer = new byte[bufferSize];
            }
        }
    }
}
