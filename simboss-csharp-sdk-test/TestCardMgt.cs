using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Constant;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request;
using Simboss.Csharp.Sdk.Response;
using Xunit;
using Xunit.Abstractions;

namespace Simboss.Csharp.Sdk.Test
{
    public class TestCardMgt
    {
        private readonly ITestOutputHelper log;

        public TestCardMgt(ITestOutputHelper log)
        {
            this.log = log;
        }

        private static SimbossClient client = new SimbossClient("10242017520", "2aa9382a45d3092f24fe2a0325f28200").Init();

        [Fact]
        public void testDeviceDetail()
        {
            
            DeviceDetailRequest request = new DeviceDetailRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<DeviceDetailModel> response = client.Excute<DeviceDetailModel>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceDetailBatch()
        {
            DeviceDetailBatchRequest request = new DeviceDetailBatchRequest();
            request.AddIccid("89860401101730528432");
            request.AddIccid("8986031740205777418");
            SimbossResponse<List<DeviceDetailModel>> response = client.Excute<List<DeviceDetailModel>>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceOrderedRatePlans()
        {
            DeviceOrderedPlansRequest request = new DeviceOrderedPlansRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<List<OrderedPlansModel>> response = client.Excute<List<OrderedPlansModel>>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceRateplans()
        {
            DeviceRateplansRequest request = new DeviceRateplansRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<List<RatePlansModel>> response = client.Excute<List<RatePlansModel>>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceRecharge()
        {
            DeviceRechargeRequest request = new DeviceRechargeRequest();
            request.Iccid = "8986031746205137487";
            request.RatePlanId = 500;
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }


        [Fact]
        public void testDeviceRechargeRecords()
        {
            DeviceRechargeRecordsRequest request = new DeviceRechargeRecordsRequest();
            request.Iccid = "8986031746205137487";
            SimbossResponse<List<RechargeRecordsModel>> response = client.Excute<List<RechargeRecordsModel>>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceGprsStatus()
        {
            DeviceGprsStatusRequest request = new DeviceGprsStatusRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<DeviceGprsStatusModel> response = client.Excute<DeviceGprsStatusModel>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceUserStatus()
        {
            DeviceUserStatusRequest request = new DeviceUserStatusRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<DeviceUserStatusModel> response = client.Excute<DeviceUserStatusModel>(request);
            log.WriteLine(response.ToString());
        }


        [Fact]
        public void testDeviceRunningStatus()
        {
            DeviceRunningStatusRequest request = new DeviceRunningStatusRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<DeviceRunningStatusModel> response = client.Excute<DeviceRunningStatusModel>(request);
            log.WriteLine(response.ToString());
        }


        [Fact]
        public void testDeviceRatePlanSummary()
        {
            DeviceRatePlanSummaryRequest request = new DeviceRatePlanSummaryRequest();
            request.Iccid = "8986031746205137487";
            SimbossResponse<RatePlanSummaryModel> response = client.Excute<RatePlanSummaryModel>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceModifyDeviceStatus()
        {
            DeviceModifyDeviceStatusRequest request = new DeviceModifyDeviceStatusRequest();
            request.Iccid = "89860401101730528432";
            request.Status = CardStatusConstant.CarrierStatusEnum.ActivatedName;
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceDailyUsage()
        {
            DeviceDailyUsageRequest request = new DeviceDailyUsageRequest();
            request.Iccid = "8986031746205137487";
            request.Date = DateTime.Now.AddDays(-1);
            SimbossResponse<DailyUsageModel> response = client.Excute<DailyUsageModel>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceCancelTesting()
        {
            DeviceCancelTestingRequest request = new DeviceCancelTestingRequest();
            request.Iccid = "89860401101730528432";
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }


        [Fact]
        public void testDeviceMemoUpdate()
        {
            DeviceMemoUpdateRequest request = new DeviceMemoUpdateRequest();
            request.Iccid = "89860401101730528432";
            request.Memo = "C#单个备注";
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testDeviceMemoBatchUpdate()
        {
            DeviceMemoBatchUpdateRequest request = new DeviceMemoBatchUpdateRequest();
            request.AddIccid("89860401101730528432");
            request.AddIccid("8986031740205777418");
            request.Memo = "C#批量配置";
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }
    }
}
