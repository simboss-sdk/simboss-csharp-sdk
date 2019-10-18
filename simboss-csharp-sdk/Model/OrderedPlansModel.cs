using System;

namespace Simboss.Csharp.Sdk.Model
{

    public class OrderedPlansModel
    {
        public String Status{
            get; set;
        }

        public Int32 RatePlanId{
            get; set;
        }

        public Double Price{
            get; set;
        }

        public Int32 TimeLength{
            get; set;
        }

        public String TimeUnit{
            get; set;
        }

        public Double DataVolume{
            get; set;
        }

        public String Name{
            get; set;
        }

        public String Type{
            get; set;
        }

        public String Description{
            get; set;
        }

        public String EffectiveDate{
            get; set;
        }

        public String ExpirationDate{
            get; set;
        }

        public Boolean UnlimitedVolume{
            get; set;
        }

        public Boolean UseCountAsVolume{
            get; set;
        }
    }
}