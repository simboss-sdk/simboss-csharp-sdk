using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{
    public class DeviceCancelTestingRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_DEVICE_CANCEL_TESTING;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            return map;
        }
    }
}
