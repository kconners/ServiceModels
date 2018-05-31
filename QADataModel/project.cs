using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class project
    {
        public class Project
        {
            public Guid workflow_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid project_idnumber { get; set; }
            public Guid program_idnumber { get; set; }

            public Guid program_wf_project_idnumber { get; set; }

            public string project_name { get; set; }
            public string project_shrt_name { get; set; }
            public string project_desc { get; set; }

            public int Status = 1;
        }
        public class getprojects
        {
            public List<Project> projects { get; set; }
        }

        public class projectRootObject
        {
            public Project projects { get; set; }
        }
    }
}
