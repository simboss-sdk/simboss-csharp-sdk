using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class SmsListRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_SMS_LIST;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if (PageNo == null)
            {
                throw new SimbossException("param pageNo is required");
            }
            map.Add("pageNo", PageNo.ToString());
            return map;
        }

        public Int32? PageNo{
            get; set;
        }
    }
}