using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Promotion
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string promotiondescription { get; set; }
        public string enrollmentsupporttype { get; set; }
        public string folderid { get; set; }
        public string locationgroupid { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string displayorder { get; set; }
        public string targeted { get; set; }
        public string id { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;

    }
}
