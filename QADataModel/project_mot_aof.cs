using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class project_mot_aof
    {
        public class ProjMOTAOF
        {
            public Guid project_mot_aof_idnumber { get; set; }
            public Guid project_idnumber { get; set; }
            public Guid mot_idnumber { get; set; }
            public Guid aof_idnumber { get; set; }
            public int Status = 1;
        }
        public class getMappings
        {
            public List<ProjMOTAOF> mappings { get; set; }
        }

        public class MappingRootObject
        {
            public ProjMOTAOF mappings { get; set; }
        }
    }
}
