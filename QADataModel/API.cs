using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class API
    {
        public class testcall
        {
            public Guid row_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public string testcasenumber { get; set; }
            public string callname { get; set; }
            public string testcallidentifier { get; set; }
            public int Status { get; set; }

        }

        public class testcallObject
        {
            public List<testcall> testcalls { get; set; }
        }

        public class testcallRoot


        {
            public testcall testcalls { get; set; }
        }

        public class callparametervalue
        {
            public Guid row_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid testcall_idnumber { get; set; }

            public string parameternum { get; set; }
            public string dataname { get; set; }
            public string datatype { get; set; }
            public string datavalue { get; set; }

            public int Status { get; set; }

        }
        public class callparametervalueRoot
        {
            public callparametervalue testcallparameters { get; set; }
        }
        public class callparametervalueObject
        {
            public List<callparametervalue> testcallparameters { get; set; }
        }


    }
}
