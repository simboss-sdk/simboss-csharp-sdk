using System;
using System.Collections.Generic;

namespace Simboss.Csharp.Sdk.Model
{
    public class SmsListModel
    {
        public List<SmsModel> List {
            get; set;
        }

        public PageModel Page{
            get; set;
        }
    }
}