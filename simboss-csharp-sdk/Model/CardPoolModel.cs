using System;

namespace Simboss.Csharp.Sdk.Model
{

    public class CardPoolModel
    {

        /**
         * 流量池ID
         */
        private Int64 Id{
            get; set;
        }

        /**
         * 流量池规格
         */
        public Int32 PoolSpecification{
            get; set;
        }
        /**
         * 运营商
         */
        private String Carrier{
            get; set;
        }

        /**
         * 总容量
         */
        private Double TotalVolume{
            get; set;
        }

        /**
         * 使用量
         */
        private Double UseVolume{
            get; set;
        }

        /**
         * 剩余流量
         */
        private Double LeftVolume{
            get; set;
        }

        /**
         * 叠加流量
         */
        private Double PackageVolume{
            get; set;
        }

        /**
         * 流量使用率
         */
        private Double UseRate{
            get; set;
        }


        /**
         * 卡总数
         */
        public Int32 TotalCount{
            get; set;
        }

        /**
         * 当前激活卡量
         */
        public Int32 CurrentActivationCount{
            get; set;
        }

        /**
         * 当前停卡量
         */
        public Int32 CurrentDeactivationCount{
            get; set;
        }

        /**
         * 当前库存量
         */
        public Int32 CurrentInventoryCount{
            get; set;
        }

        /**
         * 当前测试期卡量
         */
        public Int32 CurrentTestingCount{
            get; set;
        }

        /**
         * 当前销卡的卡量
         */
        public Int32 CurrentRetiredCount{
            get; set;
        }

        /**
         * 待激活数
         */
        public Int32 ActivationReadyCount{
            get; set;
        }

    }
}