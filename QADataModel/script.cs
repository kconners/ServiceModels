using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class script
    {
        public class RunnerDetails
        {
            public Guid RunnerDetail_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public Guid User_IDNumber { get; set; }
            public string Title { get; set; }
            public string UserName { get; set; }
            public string Description { get; set; }
            public string TestSetTitle { get; set; }
            public Int32 Status = 1;
        }

        public class RunnerDetailsRoot
        {
            public RunnerDetails runnerdetails { get; set; }
        }
        public class RootObject
        {
            public List<RunnerDetails> RunnerDetails { get; set; }
        }
    }
}
