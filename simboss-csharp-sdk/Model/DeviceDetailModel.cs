using System;

namespace Simboss.Csharp.Sdk.Model
{

    public class DeviceDetailModel
    {

        /**
         * iccid
         *
         * @ref https://baike.baidu.com/item/iccid/5181544
         */
        public String Iccid {
            set; get;
        }

        /**
         * imsi
         *
         * @ref https://baike.baidu.com/item/imsi/307249
         */
        public String Imsi{
            set; get;
        }

        /**
         * msisdn
         */
        public String Msisdn{
            set; get;
        }

        /**
         * 运营商
         *
         */
        public String Carrier{
            set; get;
        }

        /**
         * 卡片类型：单卡: SINGLE，流量池: POOL
         */
        public String Type{
            set; get;
        }

        /**
         * 状态
         *
         */
        public String Status{
            set; get;
        }

        /**
         * 设备状态
         *
         */
        public String DeviceStatus{
            set; get;
        }

        /**
         * 出库时间
         */
        public DateTime OpenDate{
            set; get;
        }

        /**
         * 激活时间
         */
        public DateTime StartDate{
            set; get;
        }

        /**
         * 过期时间
         */
        public DateTime ExpireDate{
            set; get;
        }

        /**
         * 套餐流量最后更新时间
         */
        public DateTime LastSyncDate{
            set; get;
        }

        /**
         * 激活宽限期(天）
         */
        public Int64 ActiveDuration{
            set; get;
        }

        /**
         * 卡备注
         */
        public String Memo{
            set; get;
        }

        /**
         * 是否需要实名认证
         */
        public Boolean RealnameRequired{
            set; get;
        }

        /**
         * 实名认证用户姓名
         */
        public String RealName{
            set; get;
        }

        /**
         * 卡实名审核状态，审核通过：pass、未提交：not-submit、审核不通过：not-pass、待审核：not-audit
         */
        public String RealNameCertifystatus{
            set; get;
        }

        /**
         * 流量池ID
         */
        public Int64 CardPoolId{
            set; get;
        }

        /**
         * 测试期结束时间
         */
        public DateTime TestingExpireDate{
            set; get;
        }

        /**
         * 套餐id
         */
        public Int64 RatePlanId{
            set; get;
        }

        /**
         * 套餐名称
         */
        public String IratePlanName{
            set; get;
        }

        /**
         * 套使用量(MB)
         */
        public Double UsedDataVolume{
            set; get;
        }

        /**
         * 当前套餐总流量(MB)
         */
        public Double TotalDataVolume{
            set; get;
        }

        /**
         * 当前套餐生效时间
         */
        public DateTime RatePlanEffetiveDate{
            set; get;
        }

        /**
         * 当前套餐失效时间
         */
        public DateTime RatePlanExpirationDate{
            set; get;
        }

        /**
         * 套餐当月用量
         */
        public Double DataUsage{
            set; get;
        }

        /**
         *
         */
        public String[] Functions{
            set; get;
        }

        /**
         * 公司名称
         */
        public String OrgName{
            set; get;
        }

        /**
         * imei状态
         */
        public String ImeiStatus{
            set; get;
        }

        /**
         * 网络限速值
         */
        public Double SpeedLimit{
            set; get;
        }

        /**
         *
         */
        public Boolean UseCountAsVolume{
            set; get;
        }



    }
}
