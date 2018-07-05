using System;
using System.IO;
using Simboss.Csharp.Sdk.Exception;

namespace Simboss.Csharp.Sdk.Helper
{
    public class FileHelper
    {
        public static String convertFileToBase64(Stream stream)
        {
            if (stream == null)
            {
                throw new SimbossException("Stream is null");
            }
            try
            {
                byte[] bt = new byte[stream.Length];
                stream.Read(bt, 0, bt.Length);
                String base64Str = Convert.ToBase64String(bt);
                bt = null;
                return base64Str;
            } finally {
                    stream.Close();
            }
        }
    }
}
