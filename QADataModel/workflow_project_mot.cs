using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class workflow_project_mot
    {
        public class WorkProjMOT
        {
            public Guid workflow_project_mot_idnumber { get; set; }
            public Guid workflow_idnumber { get; set; }
            public Guid project_idnumber { get; set; }
            public Guid mot_idnumber { get; set; }
            public int Status = 1;
        }
        public class getMappings
        {
            public List<WorkProjMOT> mappings { get; set; }
        }

        public class MappingRootObject
        {
            public WorkProjMOT mappings { get; set; }
        }
    }
}
