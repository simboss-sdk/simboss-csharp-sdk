using System;
using System.Collections.Generic;
using System.IO;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request;
using Simboss.Csharp.Sdk.Response;
using Xunit;
using Xunit.Abstractions;

namespace Simboss.Csharp.Sdk.Test
{
    public class TestRealNameSystemMgt
    {
        private readonly ITestOutputHelper log;

        public TestRealNameSystemMgt(ITestOutputHelper log)
        {
            this.log = log;
        }

        private static SimbossClient client = new SimbossClient("10242017520", "2aa9382a45d3092f24fe2a0325f28200").Init();

        [Fact]
        public void testRealnameSubmitRealname()
        {
            RealnameSubmitRealnameRequest request = new RealnameSubmitRealnameRequest();
            request.Iccid = "89860401101730528432";
            request.Name = "张三-C#";
            request.LicenseType = Constant.LicenseTypeEnum.Idcard;
            request.LicenseCode = "49900023923";
            request.Phone = "13655445565";
            request.ExtenalUserName = "ID:xiaomi";
            request.SetPic1(new FileStream("/Users/Abel/logo.jpg",FileMode.Open));
            request.SetPic2(new FileStream("/Users/Abel/logo.jpg", FileMode.Open));
            SimbossResponse<String> response = client.Excute<String>(request);
            log.WriteLine(response.ToString());
        }
    }
}