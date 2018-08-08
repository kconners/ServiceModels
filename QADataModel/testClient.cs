using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class testClient
    {
        public Guid testclient_idnumber { get; set; }
        public Guid client_idnum { get; set; }
        public string client_name { get; set; }
        public Guid env_idnum { get; set; }
        public Guid loyaltyversion { get; set; }
        
        public Guid build_idnum { get; set; }
        public string client_schema { get; set; }
        public string client_desc { get; set; }
        public string clientpricontact { get; set; }
        public string clientcontactnumber { get; set; }
        public string clientcontactemail { get; set; }
        public string clientlwidnumber { get; set; }
        public string clientlwprojectname { get; set; }
        public string client_oracle_schema { get; set; }
        public int Status { get; set; }
    }
    public class TestclientRoot
    {
        public testClient orgs { get; set; }
    }
    public class TestclientObjects
    {
        public List<testClient> orgs { get; set; }
    }


    public class testclient_URLS
    {
        public string CSURL { get; set; }
        public string MPURL { get; set; }
        public string APIURL { get; set; }
        public string MGWURL { get; set; }
        public string RESTURL { get; set; }
        public string Schema { get; set; }
        public string NET { get; set; }
        public string JAR { get; set; }
    }
    public class TestclientURLRoot
    {
        public testclient_URLS URLs { get; set; }
    }
    public class TestclientURLObjects
    {
        public List<testclient_URLS> URLs { get; set; }
    }


    public class testclientenv
    {

        public Guid Client_IDNumber { get; set; }
        public string OrgName { get; set; }
        public Guid Env_IDNumber { get; set; }

        public string Environment { get; set; }
        public string Env_Shrt { get; set; }
        public string Description { get; set; }
        public string Order { get; set; }
        public Int32 Status = 1;
    }

    public class TestclientenvRoot
    {
        public testclientenv orgsenvs { get; set; }
    }
    public class TestclientenvObjects
    {
        public List<testclientenv> orgsenvs { get; set; }
    }
}
