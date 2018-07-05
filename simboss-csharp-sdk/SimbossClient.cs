using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Simboss.Csharp.Sdk.Conf;
using Simboss.Csharp.Sdk.Helper;
using Simboss.Csharp.Sdk.Request;
using Simboss.Csharp.Sdk.Response;

namespace Simboss.Csharp.Sdk
{
    public class SimbossClient
    {
        private static String defaultCharSet = "utf-8";

        private SimbossConfig config;

        private HttpClient httpClient;

        public SimbossClient(String appId, String appSecret, String apiUrl = null, Dictionary<String, String> optConf = null)
        {
            this.config = new SimbossConfig(appId, appSecret, apiUrl, optConf);
        }

        public SimbossClient Init()
        {
            this.httpClient = new HttpClient();
            this.httpClient.Timeout = TimeSpan.FromMilliseconds(int.Parse(this.config.optConf["httpTimeout"]));
            return this;
        }

        public SimbossResponse<T> Excute<T>(SimbossRequest request)
        {
            SimbossResponse<T> response;
            String result = null;
            try
            {
                String url = this.config.ApiUrl + request.GetUri();
                SortedDictionary<String, String> paramDic = GetRequestParam(request);
                Task<String> task = Post(url, paramDic);
                result = task.Result;
                response = JsonConvert.DeserializeObject<SimbossResponse<T>>(result);
            }
            catch (System.Exception e)
            {
                response = new SimbossResponse<T>();
                response.Success = false;
                response.Message = e.Message + ", result: " + result;
                response.Code = "599";
            }
            return response;
        }


        public async Task<string> Post(string url, SortedDictionary<String, String> paramDic)
        {
            var encoding = Encoding.GetEncoding(defaultCharSet);
            List<String> paramList = new List<string>();
            foreach (KeyValuePair<String, String> kv in paramDic)
            {
                paramList.Add(string.Format(
                    string.Format("{0}={1}",
                    HttpUtility.UrlEncode(kv.Key, encoding),
                    HttpUtility.UrlEncode(kv.Value, encoding))));
            }
            String data = string.Join("&", paramList);
            StringContent content = new StringContent(data, encoding, "application/x-www-form-urlencoded");
            //content.Headers.ContentEncoding.Add(defaultCharSet);
            using (var message = await httpClient.PostAsync(url, content).ConfigureAwait(false))
            {
                var response = await message.Content.ReadAsByteArrayAsync();
                var responseString = encoding.GetString(response);
                return responseString;
            }
        }

        private SortedDictionary<String, String> GetRequestParam(SimbossRequest request)
        {
            SortedDictionary<String, String> paramDic = request.GetParam();
            paramDic.Add("appid", this.config.AppId);
            paramDic.Add("timestamp", TimeHelper.GetTimeStamp());
            String sign = SignatureHelper.GetSignature(paramDic, this.config.AppSecret);
            paramDic.Add("sign", sign);
            return paramDic;
        }

        public void Dispose()
        {
            if (httpClient != null)
            {
                httpClient.Dispose();
            }
        }

    }
}
