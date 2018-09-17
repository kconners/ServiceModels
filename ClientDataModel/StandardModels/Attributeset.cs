using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Attributeset

    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string attributesetcode { get; set; }
        public string attributesetname { get; set; }
        public string displaytext { get; set; }
        public string description { get; set; }
        public string alias { get; set; }
        public string typecode { get; set; }
        public string categorycode { get; set; }
        public string editablefromprogram { get; set; }
        public string editablefromcampaign { get; set; }
        public string parentattributesetcode { get; set; }
        public string tablecreationdate { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;

        
}
}
