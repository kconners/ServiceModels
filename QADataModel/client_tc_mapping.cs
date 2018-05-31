using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class client_tc_mapping
    {
        public Guid mapping_idnumber { get; set; }
        public Guid client_idnumber { get; set; }
        public Guid program_idnumber { get; set; }
        public Guid project_idnumber { get; set; }
        public Guid workflow_idnumber { get; set; }
        public Guid client_workflow_idnumber { get; set; }
        public Guid mot_idnumber { get; set; }
        public Guid project_mot_idnumber { get; set; }
        public Guid aof_idnumber { get; set; }
        public Guid project_aof_idnumber { get; set; }
        public int Status = 1;
    }
    public class getMappings
    {
        public List<client_tc_mapping> mappings { get; set; }
    }

    public class MappingRootObject
    {
        public client_tc_mapping mappings { get; set; }
    }
}
