using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Tier
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }

        public string id { get; set; }
        public string name { get; set; }
        public string displaytext { get; set; }
        public string description { get; set; }
        public string entrypoints { get; set; }
        public string exitpoints { get; set; }
        public string pointnames { get; set; }
        public string pointeventnames { get; set; }
        public string addtoenrollmentdate { get; set; }
        public string expirationdateexpression { get; set; }
        public string activityperiodstartexpression { get; set; }
        public string activityperiodendexpression { get; set; }
        public string defaultrewardid { get; set; }

        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
        
    }
}
