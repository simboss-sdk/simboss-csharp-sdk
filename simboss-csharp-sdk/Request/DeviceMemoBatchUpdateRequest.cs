using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class DeviceMemoBatchUpdateRequest : ThreeIdsCombineModel, SimbossRequest
    {
        public String GetUri()
        {
            return UriConstants.URI_DEVICE_MEMO_BATCH_UPDATE;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if (Memo == null)
            {
                throw new SimbossException("param memo is required");
            }
            map.Add("memo", Memo);
            return map;
        }

        public String Memo
        {
            get; set;
        }
    }
}
