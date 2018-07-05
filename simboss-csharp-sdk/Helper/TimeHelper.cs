using System;
namespace Simboss.Csharp.Sdk.Helper
{
    public class TimeHelper
    {
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Math.Round(ts.TotalMilliseconds, 0).ToString();
        }
    }
}
