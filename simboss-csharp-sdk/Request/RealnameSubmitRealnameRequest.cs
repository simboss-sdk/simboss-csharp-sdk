using System;
using System.Collections.Generic;
using System.IO;
using Simboss.Csharp.Sdk.Constant;
using Simboss.Csharp.Sdk.Exception;
using Simboss.Csharp.Sdk.Helper;
using Simboss.Csharp.Sdk.Model;
using Simboss.Csharp.Sdk.Request.Constant;

namespace Simboss.Csharp.Sdk.Request
{

    public class RealnameSubmitRealnameRequest : ThreeIdCombineModel, SimbossRequest
    {

        public String GetUri()
        {
            return UriConstants.URI_REALNAME_SUBMIT_REALNAME;
        }

        public SortedDictionary<String, String> GetParam()
        {
            SortedDictionary<String, String> map = base.GetBaseParam();
            if (Name == null)
            {
                throw new SimbossException("param name is required");
            }
            map.Add("name", Name);
            if (this.LicenseType == null)
            {
                throw new SimbossException("param licenseType is required");
            }
            map.Add("licenseType", LicenseType.ToString().ToLower());
            if (LicenseCode == null)
            {
                throw new SimbossException("param licenseCode is required");
            }
            map.Add("licenseCode", LicenseCode);
            if (Phone == null)
            {
                throw new SimbossException("param phone is required");
            }
            map.Add("phone", Phone);
            if (ExtenalUserName != null)
            {
                map.Add("extenalUserName", ExtenalUserName);
            }
            if (String.IsNullOrWhiteSpace(Pic1))
            {
                throw new SimbossException("param pic1 is required");
            }
            map.Add("pic1", Pic1);

            if (String.IsNullOrWhiteSpace(Pic2))
            {
                throw new SimbossException("param pic2 is required");
            }
            map.Add("pic2", Pic2);

            if (!String.IsNullOrWhiteSpace(Pic3))
            {
                map.Add("pic3", Pic3);
            }
            return map;
        }

        public String Name
        {
            get; set;
        }

        public LicenseTypeEnum? LicenseType
        {
            get; set;
        }

        public String LicenseCode
        {
            get; set;
        }

        public String Phone
        {
            get; set;
        }

        public String ExtenalUserName
        {
            get; set;
        }

        public String Pic1
        {
            get; set;
        }

        public String Pic2
        {
            get; set;
        }

        public String Pic3
        {
            get; set;
        }

        public String Diviceid
        {
            get; set;
        }

        public void SetPic1(Stream stream) {
            this.Pic1 = FileHelper.convertFileToBase64(stream);
        }

        public void SetPic2(Stream stream)
        {
            this.Pic2 = FileHelper.convertFileToBase64(stream);
        }

        public void SetPic3(Stream stream)
        {
            this.Pic3 = FileHelper.convertFileToBase64(stream);
        }
    }
}