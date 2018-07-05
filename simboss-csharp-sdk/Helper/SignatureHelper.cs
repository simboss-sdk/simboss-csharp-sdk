using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Simboss.Csharp.Sdk.Exception;

namespace Simboss.Csharp.Sdk.Helper
{
    public class SignatureHelper
    {
        public static String GetSignature(SortedDictionary<String, String> paramDic, String appSecret)
        {
            String sign = "";
            foreach (KeyValuePair<String, String> kv in paramDic)
            {
                sign += kv.Key + "=" + kv.Value + "&";
            }
            if (sign.EndsWith("&"))
            {
                sign = sign.Substring(0, sign.Length - 1);
            }
            sign = sign + appSecret;
            sign = SignatureHelper.getSha256(sign);
            return sign;
        }

        public static String getSha256(String strData)
        {
            try
            {
                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(strData);
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                byte[] retVal = sha256.ComputeHash(bytValue);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (System.Exception ex)
            {
                throw new SimbossException("get sha256 error:" + ex.Message, ex);
            }
        }
    }
}
