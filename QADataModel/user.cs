using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class user
    {
        public class Permissions
        {
            public Guid user_idnumber { get; set; }
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
        }
    }
}
