using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class tests
    {
        public class testDetails
        {
            public Guid Test_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public Guid Script_IDNumber { get; set; }
            public Guid Application_IDNumber { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public Int32 Status = 1;
        }

        public class TestsRoot
        {
            public testDetails testsdetails { get; set; }
        }
        public class TestsObject
        {
            public List<testDetails> testsdetails { get; set; }
        }
    }
}
