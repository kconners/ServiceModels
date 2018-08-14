using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QADataModel;
using RestSharp;
using Newtonsoft.Json;

namespace QACDataModel
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public class AuthenticationData
        {
            private int UserId;
            private string PassCode;
            private string UserName;
            private string Client;

            public AuthenticationData(string _Client, string _UserName)
            {
                SimpleAES A = new SimpleAES();

                QAData.User UU = new QAData.User();
                var clieNt = new RestClient(conFIG.QADataRestEndpoint + "api/Users/");

                var request = new RestRequest(Method.GET);
                request.AddQueryParameter("UserName", _UserName);


                var response = clieNt.Execute(request);
                string res = response.Content;

                var resultsJSON = JsonConvert.DeserializeObject<QAData.UserRoot>(res);
                UU = resultsJSON.user;

                UserId = UU.qacnumber;
                UserName = UU.emailaddress;
                PassCode = A.DecryptString(UU.qacpascod);

                Client = _Client;

            }
            public string GetAuth()
            {
                return Login(UserName, PassCode);
            }
            
            public int ProjId()
            {
                int ProjectID = 0;

                var client = new RestClient(conFIG.QADataRestEndpoint + "api/Clients/");

                var request = new RestRequest(Method.GET);
                request.AddQueryParameter("value", Client);
                request.AddQueryParameter("parameter", "client");
                var response = client.Execute(request);
                string L = response.Content;

                var resultsJSON = JsonConvert.DeserializeObject<QAData.GetClientsRepo>(L);

                ProjectID = Convert.ToInt32(resultsJSON.clients.qac_projectnum);


                return ProjectID;
            }
        }
        private static string Login(string _UN, string _PW)
        {

            string Auth = "";

            string Authorization = Base64Encode(_UN + ":" + _PW);
            Auth = "Basic " + Authorization;


            return Auth;
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
