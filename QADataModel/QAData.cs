using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class QAData
    {
        public class Client
        {
            public Guid Client_IDNUM = new Guid();
            public string client = string.Empty;
            public string clnt_short = string.Empty;
            public string client_shema = string.Empty;
            public string postgres_client_shema = string.Empty;
            public string qac_projectnum = string.Empty;
            public string jira_project_id = string.Empty;
            public string projectname = string.Empty;
            public string createdate = string.Empty;
            public string updatedate = string.Empty;
            public string clientlib_dll = string.Empty;
            public string clientlib_jar = string.Empty;
            public int Status = 1;
        }

        public class GetClientsResponce
        {
            public List<Client> clients { get; set; }

        }
        public class GetClientsRepo
        {
            public Client clients { get; set; }

        }

        public class GetAvailableMappings
        {
            public List<UserClientSelection> clients { get; set; }
        }


        public class User
        {
            public Guid User_IDNUM = new Guid();

            public string username = string.Empty;
            public string firstname = string.Empty;
            public string lastname = string.Empty;
            public string emailaddress = string.Empty;
            public string password = string.Empty;
            public int status = 1;
            public int qacnumber;
            public string qacpascod = string.Empty;
            public string messageboxpref = string.Empty;
            public string las_loggedin = string.Empty;
            public string jirapasscode = string.Empty;
            public string nameforwindowsaccount = string.Empty;

            public int isadmin { get; set; }
            public int sally { get; set; }
            public int levi { get; set; }
            public int lw { get; set; }
            public int qa { get; set; }
            public int qac { get; set; }
            public int hertz { get; set; }
            public int api { get; set; }
            public int automation { get; set; }
            public int reporting { get; set; }
            public DateTime createdDate { get; set; }
            public DateTime updatedDate { get; set; }
        }
        public class UserRoot
        {
            public User user { get; set; }
        }
        public class UserClientSelection
        {
            public Guid client_idnum = new Guid();
            public string client = string.Empty;
            public string username = string.Empty;
            public int show { get; set; }
        }

    }
}
