using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request;
using Simboss.Csharp.Sdk.Response;
using Xunit;
using Xunit.Abstractions;

namespace Simboss.Csharp.Sdk.Test
{
    public class TestCardPoolMgt
    {
        private readonly ITestOutputHelper log;

        public TestCardPoolMgt(ITestOutputHelper log)
        {
            this.log = log;
        }

        private static SimbossClient client = new SimbossClient("10242017520", "2aa9382a45d3092f24fe2a0325f28200").Init();

        [Fact]
        public void testCardPoolDetail()
        {
            CardPoolDetailRequest request = new CardPoolDetailRequest();
            request.Iccid = "8986031740205777419";
            SimbossResponse<CardPoolModel> response = client.Excute<CardPoolModel>(request);
            log.WriteLine(response.ToString());
        }

        [Fact]
        public void testCardPoolList()
        {
            CardPoolListRequest request = new CardPoolListRequest();
            SimbossResponse<List<CardPoolModel>> response = client.Excute<List<CardPoolModel>>(request);
            log.WriteLine(response.ToString());
        }

    }
}