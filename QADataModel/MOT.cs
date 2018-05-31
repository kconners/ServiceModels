using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class MOT
    {
        public class mot
        {
            public Guid mot_idnumber { get; set; }
            public Guid wf_idnumber { get; set; }
            public Guid client_idnumber { get; set; }

            public string mot_name { get; set; }
            public string mot_shrt_name { get; set; }

            public int Checked = 1;
            public int Status = 1;
        }
        public class getmots
        {
            public List<mot> mots { get; set; }
        }

        public class motRootObject
        {
            public mot mots { get; set; }
        }
    }
}
