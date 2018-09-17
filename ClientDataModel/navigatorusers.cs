using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel
{
    public class navigatorusers
    {
        public class NavUser
        {
            public Guid row_idnumber { get; set; }
            public Guid version_idnum { get; set; }
            public Guid iteration_idnum { get; set; }
            public Guid build_idnum { get; set; }
            public Guid usertype { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string f_name { get; set; }
            public string l_name { get; set; }
            public string email { get; set; }
            public string phone_number { get; set; }
            public Int32 Status = 1;
        }

        public class NavUserRoot
        {
            public NavUser users { get; set; }
        }
        public class NavUserObjects
        {
            public List<NavUser> users { get; set; }
        }


        public class NavUserMapping
        {
            public Guid row_idnumber { get; set; }
            public Guid user_idnum { get; set; }
            public Guid Org_idnum { get; set; }
            public Guid Env_idnum { get; set; }
            public Int32 Status = 1;
        }
        public class NavUserMappingRoot
        {
            public NavUserMapping mapping { get; set; }
        }
        public class NavUserMappingObjects
        {
            public List<NavUserMapping> mapping { get; set; }
        }

        public class NavUserType
        {
            public Guid row_idnumber { get; set; }
            public string usertype { get; set; }
            public string usr_typ_shrt { get; set; }
            public Int32 Status = 1;
        }
        public class NavUserTypeRoot
        {
            public NavUserType type { get; set; }
        }
    }
}
