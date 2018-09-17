using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel.Rest
{
    public class Authentication
    {
        public class Data
        {
            public string tokenType { get; set; }
            public string accessToken { get; set; }
            public int expiresIn { get; set; }
        }


        public class MobileLogin
        {
            public string clientId { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public MemberDevice memberDevice { get; set; }
        }

        public class MemberDevice
        {
            public int deviceId = 0;
            public bool deviceType;
            public int deviceOS = 0;
            public double deviceOSVersion = 0;
            public int acceptsPush = 0;
            public double pushToken = 0;
        }





        public class GetAuth
        {
            public ApplicationPermissions secrets { get; set; }
        }
        public class ApplicationPermissions
        {
            public string clientId { get; set; }
            public string clientSecret { get; set; }
        }
        public class Auth
        {
            public bool isError { get; set; }
            public Data data { get; set; }
            public object developerMessage { get; set; }
            public string userMessage { get; set; }
            public object moreInfo { get; set; }
            public int responseCode { get; set; }
            public int httpStatusCode { get; set; }
            public object errors { get; set; }
            public string requestId { get; set; }
        }
    }
}
