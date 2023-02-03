using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{
    public class DeviceRateplansRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_DEVICE_RATEPLANS;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if (withRechargeUnit)
            {
                map.Add("withRechargeUnit", "true");
            }
            return map;
        }

        public Boolean withRechargeUnit
        {
           get; set;
        }
    }
}