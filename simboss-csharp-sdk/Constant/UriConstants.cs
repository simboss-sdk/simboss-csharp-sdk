using System;
using System.Collections.Generic;

namespace Simboss.Csharp.Sdk.Request.Constant
{

    /**
     * URI常量
     * Created by Abel 2018-06-20.
     **/
    public class UriConstants
    {
        public const String API_URL = "https://api.simboss.com";

        public const String URI_USER_DASHBOARD_GET = "/2.0/user/dashboard/get";

        public const String URI_DEVICE_DETAIL_BATCH = "/2.0/device/detail/batch";

        public const String URI_DEVICE_DETAIL = "/2.0/device/detail";

        public const String URI_DEVICE_ORDERED_PLANS = "/2.0/device/orderedPlans";

        public const String URI_DEVICE_RATEPLANS = "/2.0/device/rateplans";

        public const String URI_DEVICE_RECHARGE = "/2.0/device/recharge";

        public const String URI_DEVICE_RECHARGE_RECORDS = "/2.0/device/recharge/records";

        public const String URI_DEVICE_GPRS_STATUS = "/2.0/device/gprsStatus";

        public const String URI_DEVICE_USER_STATUS = "/2.0/device/userStatus";

        public const String URI_DEVICE_RUNNING_STATUS = "/2.0/device/runningStatus";

        public const String URI_DEVICE_RATEPLAN_SUMMARY = "/2.0/device/ratePlan/summary";

        public const String URI_DEVICE_MODIFY_DEVICE_STATUS = "/2.0/device/modifyDeviceStatus";

        public const String URI_DEVICE_DAILY_USAGE = "/2.0/device/dailyUsage";

        public const String URI_DEVICE_CANCEL_TESTING = "/2.0/device/cancelTesting";

        public const String URI_DEVICE_MEMO_UPDATE = "/2.0/device/memo/update";

        public const String URI_DEVICE_MEMO_BATCH_UPDATE = "/2.0/device/memo/batchUpdate";

        public const String URI_CARD_POOL_DETAIL = "/2.0/card/pool/detail";

        public const String URI_CARD_POOL_LIST = "/2.0/card/pool/list";

        public const String URI_REALNAME_SUBMIT_REALNAME = "/2.0/realname/submitRealname";

        public const String URI_SMS_SEND = "/2.0/sms/send";

        public const String URI_SMS_LIST = "/2.0/sms/list";
    }
}