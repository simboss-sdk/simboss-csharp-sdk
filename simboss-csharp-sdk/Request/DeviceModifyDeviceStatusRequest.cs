using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Constant;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class DeviceModifyDeviceStatusRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_DEVICE_MODIFY_DEVICE_STATUS;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();

            if (Status == null){
                throw new SimbossException("param status is error");
            }

            if (CardStatusConstant.CarrierStatusEnum.ActivatedName == Status)
            {
                map.Add("status", "ACTIVATED_NAME");
            }
            else if (CardStatusConstant.CarrierStatusEnum.ActivatedName == Status)
            {
                map.Add("status", "DEACTIVATED_NAME");
            }
          
            return map;
        }

        public CardStatusConstant.CarrierStatusEnum ? Status
        {
            get; set;
        }
    }
}