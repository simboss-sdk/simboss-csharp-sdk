using System;

namespace Simboss.Csharp.Sdk.Model
{
    /**
     * 分页
     * Created by Abel 2018-06-21.
     **/
    public class PageModel
    {
        
        public Int32 PageNo{
            get; set;
        }

        public Int32 PageSize{
            get; set;
        }

        public Int32 Total{
            get; set;
        }

       
    }
}