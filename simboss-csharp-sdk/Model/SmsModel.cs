using System;

namespace Simboss.Csharp.Sdk.Model
{

    public class SmsModel
    {

        public Int64 Id
        {
            get; set;
        }

        public String Iccid{
            get; set;
        }

        public String Carrier{
            get; set;
        }

        public String Text{
            get; set;
        }

        public DateTime SendTime{
            get; set;
        }

        public String Type{
            get; set;
        }
    }
}