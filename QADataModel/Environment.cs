using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class Environment
    {
        public class envdetails
        {
            public Guid Env_IDNumber { get; set; }

            public string Environment { get; set; }
            public string env_shrt { get; set; }
            public Int32 Status = 1;
        }

        public class environmentRoot
        {
            public envdetails environments { get; set; }
        }
        public class environmentsObject
        {
            public List<envdetails> environments { get; set; }
        }
    }
}
