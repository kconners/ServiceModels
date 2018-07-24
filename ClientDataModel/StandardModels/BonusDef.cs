using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class BonusDef
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string categoryid { get; set; }
        public string folderid { get; set; }
        public string logoimagehero { get; set; }
        public string logoimageweb { get; set; }
        public string logoimagemobile { get; set; }
        public string points { get; set; }
        public string surveytext { get; set; }
        public string surveyid { get; set; }
        public string surveypointsexpression { get; set; }
        public string actionurl { get; set; }
        public string referralurl { get; set; }
        public string displayorder { get; set; }
        public string startdate { get; set; }
        public string expirydate { get; set; }
        public string quota { get; set; }
        public string applyquotatoreferral { get; set; }
        public string completed { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
