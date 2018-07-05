using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class DeviceDailyUsageRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_DEVICE_DAILY_USAGE;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if (Date == null)
            {
                throw new SimbossException("param date is required");
            }
            map.Add("date", Date.ToString("yyyy-MM-dd"));
            return map;
        }


        public DateTime Date
        {
            get; set;
        }
    }
}