using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class SmsSendRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_SMS_SEND;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if (Text == null)
            {
                throw new SimbossException("param text is required");
            }
            map.Add("text", Text);
            if (MsgId != null)
            {
                map.Add("msgId", MsgId);
            }
            return map;
        }

        public String Text
        {
            get; set;
        }

        public String MsgId
        {
            get; set;
        }
    }
}