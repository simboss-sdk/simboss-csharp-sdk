using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;

namespace Simboss.Csharp.Sdk.Model
{

    /**
     * ICCID, MSISDN, IMSI三字段
     * Created by Abel 2018-06-20.
     **/
    public class ThreeIdCombineModel
    {

        public String Iccid
        {
            get; set;
        }

        public String Msisdn
        {
            get; set;
        }

        public String Imsi
        {
            get; set;
        }

        public SortedDictionary<String, String> GetBaseParam()
        {
            SortedDictionary<String, String> map = new SortedDictionary<String, String>();
            if (Iccid != null)
            {
                map.Add("iccid", Iccid);
            }
            if (Msisdn != null)
            {
                map.Add("msisdn", Msisdn);
            }
            if (Imsi != null)
            {
                map.Add("imsi", Imsi);
            }
            if (map.Count < 1)
            {
                throw new SimbossException("param iccid, msisdn, imsi at least one can't be null");
            }
            return map;
        }
    }

}