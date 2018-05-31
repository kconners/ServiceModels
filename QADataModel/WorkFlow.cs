using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class WorkFlow
    {
        public class workflow
        {
            public Guid workflow_idnumber { get; set; }
            public Guid client_idnumber { get; set; }

            public string workflow_name { get; set; }
            public string workflow_shrt_name { get; set; }

            public int Checked = 1;
            public int Status = 1;
        }
        public class getworkflows
        {
            public List<workflow> workflows { get; set; }
        }

        public class workflowRootObject
        {
            public workflow workflows { get; set; }
        }
    }
}
