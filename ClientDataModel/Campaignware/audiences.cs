using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.Campaignware
{
    public class audiences
    {
        public class audience
        {
            public Guid audience_idnumber { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string CREATEDATE = "";
            public string UPDATEDATE = "";
            public int Status = 1;
        }
        public class audienceRoot
        {
            public audience audiences { get; set; }
        }
        public class audienceObject
        {
            public List<audience> audiences { get; set; }
        }
    }
}
