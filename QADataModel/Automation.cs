using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class Automation
    {
        public Guid row_idnumber { get; set; }
        public string full_test_assembly { get; set; }
        public string test { get; set; }
        public string category { get; set; }
        public string parameters { get; set; }
        public string run_order { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
