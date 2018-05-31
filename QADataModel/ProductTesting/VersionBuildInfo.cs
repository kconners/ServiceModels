using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel.ProductTesting
{
    public class VersionBuildInfo
    {
        public class versionBuildDetails
        {
            public Guid row_idnumber { get; set; }
            public Guid version_idnumber { get; set; }
            public Guid build_idnumber { get; set; }
            public Guid env_idnumber { get; set; }
            public string url { get; set; }
            public string schema { get; set; }
            public Int32 Status = 1;
        }
        public class versionBuildRoot
        {
            public versionBuildDetails details { get; set; }
        }
        public class versionBuildObject
        {
            public List<versionBuildDetails> details { get; set; }
        }
    }
}
