using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Conf
{
    public class SimbossConfig
    {
        public String AppId {
            get; set;
        }

        public String AppSecret{
            get; set;
        }

        public String ApiUrl {
            get; set;
        }

        public Dictionary<String, String> optConf = new Dictionary<String, String>() {
            {"httpTimeout" , "10000"}
        };

        public SimbossConfig(String appId, String appSecret, String apiUrl = null, Dictionary<String, String> optConf = null)
        {
            this.AppId = appId;
            this.AppSecret = appSecret;
            if (String.IsNullOrWhiteSpace(apiUrl)) {
                this.ApiUrl = UriConstants.API_URL;
            } else {
                this.ApiUrl = apiUrl;
            }
            if (optConf != null && optConf.Count > 0) {
                foreach (KeyValuePair<String, String> item in optConf) {
                    this.optConf.Add(item.Key, item.Value);
                }
            }
        }
    }
}
