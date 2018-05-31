using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class URL
    {
        public class url
        {
            public Guid row_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid env_idnumber { get; set; }
            public Guid program_idnumber { get; set; }
            public Guid application_idnumber { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string fullurl { get; set; }
            public string application { get; set; }
            public string ap_srtname { get; set; }
            public Int32 Status = 1;
        }
        public class urlRoot
        {
            public url urls { get; set; }
        }
        public class urlObject
        {
            public List<url> urls { get; set; }
        }
    }
}
