using System;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request;
using Simboss.Csharp.Sdk.Response;
using Xunit;
using Xunit.Abstractions;

namespace Simboss.Csharp.Sdk.Test
{
    public class TestAccountInfo
    {
        private readonly ITestOutputHelper log;

        public TestAccountInfo(ITestOutputHelper log)
        {
            this.log = log;
        }

        private static SimbossClient client = new SimbossClient("10242017520", "2aa9382a45d3092f24fe2a0325f28200").Init();

        [Fact]
        public void testUserDashboardGet()
        {
            UserDashboardGetRequest request = new UserDashboardGetRequest();
            SimbossResponse<DashboardModel> response = TestAccountInfo.client.Excute<DashboardModel>(request);
            log.WriteLine(response.ToString());
            log.WriteLine(response.Data.company);

        }
    }
}
