using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class loyaltyware
    {
        public class version
        {
            public Guid version_idnumber { get; set; }
            public string version_name { get; set; }
            public string version_shrt_name { get; set; }
            public int Status = 1;
        }
        public class getversions
        {
            public List<version> versions { get; set; }
        }
        public class versionRootObject
        {
            public version versions { get; set; }
        }

        public class iteration
        {
            public Guid version_idnumber { get; set; }
            public Guid iteration_idnumber { get; set; }

            public string iteration_name { get; set; }
            public string iteration_shrt_name { get; set; }

            public int Status = 1;
        }
        public class getiterations
        {
            public List<iteration> builds { get; set; }
        }
        public class iterationRootObject
        {
            public iteration builds { get; set; }
        }

        public class build
        {
            public Guid version_idnumber { get; set; }
            public Guid iteration_idnumber { get; set; }
            public Guid build_idnumber { get; set; }
            public string build_name { get; set; }
            public string build_shrt_name { get; set; }
            public int Status = 1;
        }
        public class getbuilds
        {
            public List<build> builds { get; set; }
        }
        public class buildRootObject
        {
            public build builds { get; set; }
        }
        
    }
}
