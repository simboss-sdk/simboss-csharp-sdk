using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Exception;

namespace Simboss.Csharp.Sdk.Model
{
    public class ThreeIdsCombineModel
    {

        private List<String> Iccids {
            get; set;
        }

        private List<String> Msisdns{
            get; set;
        }

        private List<String> Imsis{
            get; set;
        }


        public void AddIccid(String iccid)
        {
            if (Iccids == null)
            {
                Iccids = new List<string>();
            }
            Iccids.Add(iccid);
        }

        public void AddMsisdn(String msisdn)
        {
            if (Msisdns == null)
            {
                Msisdns = new List<String>();
            }
            Msisdns.Add(msisdn);
        }

        public void AddImsi(String imsi)
        {
            if (Imsis == null)
            {
                Imsis = new List<String>();
            }
            Imsis.Add(imsi);
        }

        public SortedDictionary<String, String> GetBaseParam()
        {
            SortedDictionary<String, String> map = new SortedDictionary<String, String>();
            String separator = ",";
            if (Iccids != null && Iccids.Count > 0)
            {
                map.Add("iccids", String.Join(separator, Iccids));
            }
            if (Msisdns != null && Msisdns.Count > 0)
            {
                map.Add("msisdns", String.Join(separator, Msisdns));
            }
            if (Imsis != null && Imsis.Count > 0)
            {
                map.Add("imsis", String.Join(separator, Imsis));
            }
            if (map.Count < 1)
            {
                throw new SimbossException("param iccids, msisdns, imsis at least one can't be null");
            }
            return map;
        }

    }
}