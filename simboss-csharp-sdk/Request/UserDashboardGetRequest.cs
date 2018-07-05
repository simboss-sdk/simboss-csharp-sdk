using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{
    public class UserDashboardGetRequest : SimbossRequest
    {
        public String GetUri()
        {
            return UriConstants.URI_USER_DASHBOARD_GET;
        }

        public SortedDictionary<String, String> GetParam()
        {
            return new SortedDictionary<String, String>();
        }
    }
}
