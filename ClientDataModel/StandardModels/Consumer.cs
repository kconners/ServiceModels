using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class restconsumer

    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string consumerid { get; set; }
        public string customid { get; set; }
        public string username { get; set; }
        public string id { get; set; }
        public string isdeleted { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
