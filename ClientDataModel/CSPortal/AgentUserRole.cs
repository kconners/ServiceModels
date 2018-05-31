using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.CSPortal
{
    public class AgentUserRole
    {
        public class UserRole
        {
            public Guid userrole_idnumber { get; set; }

            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string pointawardlimit { get; set; }


            public string CREATEDATE = "";
            public string UPDATEDATE = "";
            public Guid env_idnum { get; set; }
            public Guid orgenv_idnum { get; set; }
            public int TestingStatus = 1;
        }
        public class UserRoleRoot
        {
            public UserRole userroles { get; set; }
        }
        public class UserRoleObject
        {
            public List<UserRole> userroles { get; set; }
        }




        public class UserRoleFunction
        {
            public Guid rolefunction_idnumber { get; set; }

            public string id { get; set; }
            public string roleid { get; set; }
            public string role { get; set; }
            public string functionid { get; set; }
            public string function { get; set; }

            public string CREATEDATE = "";
            public string UPDATEDATE = "";
            public Guid env_idnum { get; set; }
            public Guid orgenv_idnum { get; set; }
            public int TestingStatus = 1;
        }
        public class UserRoleFunctionRoot
        {
            public UserRoleFunction rolefunctions { get; set; }
        }
        public class UserRoleFunctionObject
        {
            public List<UserRoleFunction> rolefunctions { get; set; }
        }



        public class Function
        {
            public Guid rolefunction_idnumber { get; set; }

            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }

            public string CREATEDATE = "";
            public string UPDATEDATE = "";
            public Guid env_idnum { get; set; }
            public Guid orgenv_idnum { get; set; }
            public int TestingStatus = 1;
        }
        public class FunctionRoot
        {
            public Function functions { get; set; }
        }
        public class FunctionObject
        {
            public List<Function> functions { get; set; }
        }
    }
}
