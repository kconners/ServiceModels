using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class TestingAppUser
    {
        public class User
        {
            public string User_IDNUM { get; set; }
            public string username { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string emailaddress { get; set; }
            public string password { get; set; }
            public int status { get; set; }
            public int qacnumber { get; set; }
            public string qacpascod { get; set; }
            public string messageboxpref { get; set; }
            public string las_loggedin { get; set; }
            public string jirapasscode { get; set; }
            public string nameforwindowsaccount { get; set; }
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
        public class RootObjectList
        {
            public List<User> users { get; set; }
        }
        public class RootObject
        {
            public User user { get; set; }
        }
    }
}
