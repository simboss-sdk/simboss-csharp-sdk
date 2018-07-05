using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class DeviceRechargeRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_DEVICE_RECHARGE;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if(RatePlanId == 0 ) {
                throw new SimbossException("param ratePlanId is required");
            }
            map.Add("ratePlanId", RatePlanId.ToString());
            Month = Month == null ? 1 : Month;
            map.Add("month", Month.ToString());
            if (ExternalOrder != null)
            {
                map.Add("externalOrder", ExternalOrder);
            }
            return map;
        }

        public Int32 ? RatePlanId{
            get; set;
        }

        public Int32 ? Month{
            get; set;
        }

        public String ExternalOrder{
            get; set;
        }

    }
}