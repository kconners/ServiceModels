using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class client_program_workflow
    {
        public class program_workflow
        {
            public Guid program_workflow_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid program_idnumber { get; set; }
            public Guid workflow_idnumber { get; set; }
            public int Status = 1;
        }
        public class getMappings
        {
            public List<program_workflow> mappings { get; set; }
        }

        public class MappingRootObject
        {
            public program_workflow mappings { get; set; }
        }
    }
}
