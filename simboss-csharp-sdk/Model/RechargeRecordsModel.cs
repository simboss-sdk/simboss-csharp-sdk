using System;

namespace Simboss.Csharp.Sdk.Model
{

    public class RechargeRecordsModel
    {

        public String Sequence{
            get; set;
        }

        public String OrderName{
            get; set;
        }

        public String OrderType{
            get; set;
        }

        public Double Price{
            get; set;
        }

        public DateTime CreateTime{
            get; set;
        }

        public Boolean UnlimitedVolume{
            get; set;
        }

        public Int32 Period{
            get; set;
        }

        public Double DataVolume{
            get; set;
        }

        public String VolumePlanType{
            get; set;
        }

        public String VolumePlanName{
            get; set;
        }
    }
}