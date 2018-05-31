using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class webaction
    {
        public class Webaction
        {
            public Guid Webaction_IDNumber { get; set; }
            public Guid Application_IDNumber { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public Int32 Status = 1;
        }

        public class WebactionsRoot
        {
            public Webaction webactions { get; set; }
        }
        public class WebactionsRootObject
        {
            public List<Webaction> webactions { get; set; }
        }



        public class WebActionParameter
        {
            public Guid Parameter_IDNumber { get; set; }
            public Guid Webaction_IDNumber { get; set; }
            public Int32 ParameterNumber;
            public string label { get; set; }
            public string style { get; set; }
            public string query { get; set; }

            public Int32 Status = 1;
        }
        public class WebActionParameterRoot
        {
            public WebActionParameter webactionsparameters { get; set; }
        }
        public class WebActionParameterRootObject
        {
            public List<WebActionParameter> webactionsparameters { get; set; }
        }
    }
}
