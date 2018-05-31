using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class ClientProgWFProjMOTAOF
    {
        public class clientprogwpProjmotaof
        {
            public Guid aof_idnum { get; set; }
            public Guid mot_idnum { get; set; }
            public Guid project_idnum { get; set; }
            public Guid workflow_idnum { get; set; }
            public Guid program_idnum { get; set; }
            public Guid client_idnum { get; set; }

            public string aof { get; set; }
            public string aof_srtname { get; set; }

            public string mot { get; set; }
            public string mot_srtname { get; set; }

            public string project_name { get; set; }
            public string project_shrt_name { get; set; }

            public string workflow { get; set; }
            public string workflow_srtname { get; set; }

            public string program { get; set; }
            public string program_short { get; set; }

            public string client { get; set; }

        }
        public class getaofs
        {
            public List<clientprogwpProjmotaof> mappings { get; set; }
        }

        public class aofRootObject
        {
            public clientprogwpProjmotaof mappings { get; set; }
        }
    }
}
