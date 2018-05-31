using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class Applications
    {
        public class applicationdetails
        {
            public Guid Application_IDNumber { get; set; }
            public string application { get; set; }
            public string ap_srtname { get; set; }
            public Int32 Status = 1;
        }

        public class ApplicationsRoot
        {
            public applicationdetails applications { get; set; }
        }
        public class ApplicationsObject
        {
            public List<applicationdetails> applications { get; set; }
        }
    }
}
