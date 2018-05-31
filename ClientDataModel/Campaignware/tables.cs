using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.Campaignware
{
    public class tables
    {
        public class table
        {
            public Guid table_idnumber { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string alias { get; set; }
            public string tabletypeid { get; set; }
            public string iscampaignschema { get; set; }
            public string isframeworkschema { get; set; }

            public string CREATEDATE = "";
            public string UPDATEDATE = "";
            public int Status = 1;
        }
        public class tableRoot
        {
            public table tables { get; set; }
        }
        public class tableObject
        {
            public List<table> tables { get; set; }
        }
    }
}
