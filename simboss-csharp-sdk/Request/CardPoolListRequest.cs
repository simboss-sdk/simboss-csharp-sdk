using System;
using System.Collections.Generic;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{
    public class CardPoolListRequest : SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_CARD_POOL_LIST;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = new SortedDictionary<String, String>();
            return map;
        }
    }
}