using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{
    
    public class DeviceOrderedPlansRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_DEVICE_ORDERED_PLANS;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            return map;
        }
    }
}