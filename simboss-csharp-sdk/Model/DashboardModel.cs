using System;

namespace Simboss.Csharp.Sdk.Model
{

    /**
     * 仪表盘数据对象.
     * Created by jiacheo on 2017/4/25.
     */
    public class DashboardModel
    {
        public String userAccount
        {
            set; get;
        }

        public String company
        {
            set; get;
        }

        public String mobile
        {
            set; get;
        }

        public String name
        {
            set; get;
        }

        public DateTime registerTime
        {
            set; get;
        }

        public Double balance
        {
            set; get;
        }

        public CardSummary cardSummary
        {
            set; get;
        }

        public class CardSummary
        {
            public Int32 cmcc
            {
                set; get;
            }

            public Int32 unicom
            {
                set; get;
            }

            public Int32 telcom
            {
                set; get;
            }
        }
    }
}