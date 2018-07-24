using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    class MemberBonus
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string id { get; set; }
        public string bonusdefid { get; set; }
        public string memberid { get; set; }
        public string mtouchid { get; set; }
        public string timesclicked { get; set; }
        public string mbstatus { get; set; }
        public string referralcompleted { get; set; }
        public string displayorder { get; set; }
        public string startdate { get; set; }
        public string expirydate { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
