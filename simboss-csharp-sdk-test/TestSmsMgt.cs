using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request;
using Simboss.Csharp.Sdk.Response;
using Xunit;
using Xunit.Abstractions;

namespace Simboss.Csharp.Sdk.Test
{
    public class TestSmsMgt
    {
        private readonly ITestOutputHelper log;

        public TestSmsMgt(ITestOutputHelper log)
        {
            this.log = log;
        }

        private static SimbossClient client = new SimbossClient("10242017520", "2aa9382a45d3092f24fe2a0325f28200").Init();

        [Fact]
        public void testSmsSend()
        {
            SmsSendRequest request = new SmsSendRequest();
            request.Iccid = "89860401101730528433";
            request.Text = "C#发送短信";
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testSmsList()
        {
            SmsListRequest request = new SmsListRequest();
            request.Iccid = "89860401101730528433";
            request.PageNo = 1;
            SimbossResponse<SmsListModel> response = client.Excute<SmsListModel>(request);
            log.WriteLine(response.ToString());
        }
    }
}