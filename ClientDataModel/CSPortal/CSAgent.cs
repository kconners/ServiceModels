using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.CSPortal
{
    public class CSAgent
    {
        public class CustomerServiceAgent
        {
            public Guid csagent_idnumber { get; set; }

            public string id { get; set; }
            public string roleid { get; set; }
            public string groupid { get; set; }
            public string agentnumber { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string emailaddress { get; set; }
            public string phonenumber { get; set; }
            public string extension { get; set; }
            public string username { get; set; }
            public string failedpasswordattemptcount { get; set; }
            public string password { get; set; }
            public string password1 { get; set; }
            public int currentpw = 1;
            public string salt { get; set; }
            public string passwordchangerequired { get; set; }
            public string passwordexpirationdate { get; set; }
            public string status { get; set; }
            public string createdby { get; set; }
            public string resetcode { get; set; }
            public string resetcodedate { get; set; }

            public string CREATEDATE = "";
            public string UPDATEDATE = "";
            public Guid env_idnum { get; set; }
            public Guid orgenv_idnum { get; set; }
            public int TestingStatus = 1;
        }
        public class CustomerServiceAgentRoot
        {
            public CustomerServiceAgent customerserviceagents { get; set; }
        }
        public class CustomerServiceAgentObject
        {
            public List<CustomerServiceAgent> customerserviceagents { get; set; }
        }
    }
}
