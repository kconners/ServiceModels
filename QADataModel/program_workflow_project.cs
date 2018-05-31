using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class program_workflow_project
    {
        public class ProgWorkProj
        {
            public Guid program_workflow_project_idnumber { get; set; }
            public Guid program_idnumber { get; set; }
            public Guid workflow_idnumber { get; set; }
            public Guid project_idnumber { get; set; }
            public int Status = 1;
        }
        public class getMappings
        {
            public List<ProgWorkProj> mappings { get; set; }
        }

        public class MappingRootObject
        {
            public ProgWorkProj mappings { get; set; }
        }
    }
}
