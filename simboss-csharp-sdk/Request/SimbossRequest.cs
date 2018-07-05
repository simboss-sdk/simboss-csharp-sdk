using System;
using System.Collections.Generic;

namespace Simboss.Csharp.Sdk.Request
{
    public interface SimbossRequest
    {
        String GetUri();

        SortedDictionary<String, String> GetParam();
    }
}
