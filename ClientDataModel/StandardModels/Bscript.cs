using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Bscript
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string folderid { get; set; }
        public string expression { get; set; }
        public string expressioncontext { get; set; }
        public string currentconditionattributeset { get; set; }
        public string islocked { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }

}
