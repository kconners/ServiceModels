using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class AOF
    {
        public class aof
        {
            public Guid aof_idnumber { get; set; }
            public Guid mot_idnumber { get; set; }
            public Guid wf_idnumber { get; set; }
            public Guid client_idnumber { get; set; }

            public string aof_name { get; set; }
            public string aof_shrt_name { get; set; }

            public int Checked = 1;
            public int Status = 1;
        }
        public class getaofs
        {
            public List<aof> aofs { get; set; }
        }

        public class aofRootObject
        {
            public aof aofs { get; set; }
        }
    }
}
