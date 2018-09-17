using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel.ProductTesting.Navigator
{
    public class User
    {
        public class NavUser
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string TablueUserName { get; set; }
            public Guid user_IDNUM;
            public AdminRole AdminRole;
            public List<OtherRole> RolesAvailable { get; set; }
        }
        public class NavUserRoot
        {
            public NavUser Users { get; set; }
        }
        public class NavUserObjects
        {
            public List<NavUser> Users { get; set; }
        }

        public class NavUserMapping
        {
            public Guid Mapping_idnumber { get; set; }
            public Guid User_idnum { get; set; }
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

        public enum AdminRole
        {
            DBAdmin,
            KeyAdmin,
            LWAdmin,
            User,
            WebAdmin
        }
        public enum OtherRole
        {
            Manage_Org,
            Program_Configuration,
            Data_Modeling,
            Content,
            Websites,
            AWS_Emails,
            DMC_Emails,
            DMC_Sms,
            Campaigns,
            Surveys,
            Promotions,
            Migrations,
            Engagement,
            Reporting_Tableau
        }
    }
}
