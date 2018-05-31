using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class program
    {
        public class programdetails
        {
            public Guid Program_IDNUM { get; set; }
            public Guid Client_IDNUM { get; set; }
            public string Program { get; set; }
            public string prg_shrt { get; set; }
            public Int32 Status = 1;
        }

        public class programsRoot
        {
            public programdetails programs { get; set; }
        }
        public class programsObject
        {
            public List<programdetails> programs { get; set; }
        }

    }
}
