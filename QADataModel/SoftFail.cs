using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class SoftFail
    {
        public class SoftFailDetails
        {
            public Guid row_idnum { get; set; }
            public Guid org_idnum { get; set; }
            public Guid orgenv_idnum { get; set; }
            public string test_set_id { get; set; }
            public string test_run_id { get; set; }
            public string test_method_identifier { get; set; }
            public Int32 Status = 1;
        }

        public class SoftFailRoot
        {
            public SoftFailDetails softfails { get; set; }
        }
        public class SoftFailObject
        {
            public List<SoftFailDetails> softfails { get; set; }
        }
    }
}
