using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Product
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }

        public string categoryid { get; set; }
        public string isvisibleinln { get; set; }
        public string name { get; set; }
        public string brandname { get; set; }
        public string partnumber { get; set; }
        public string baseprice { get; set; }
        public string pointtype { get; set; }
        public string quantity { get; set; }
        public string quantitythreshold { get; set; }
        public string classcode { get; set; }
        public string classdescription { get; set; }
        public string stylecode { get; set; }
        public string styledescription { get; set; }
        public string deptcode { get; set; }
        public string deptdescription { get; set; }
        public string divisioncode { get; set; }
        public string divisiondescription { get; set; }
        public string companycode { get; set; }
        public string companydescription { get; set; }
        public string createdbyuser { get; set; }
        public string struserfield { get; set; }
        public string longuserfield { get; set; }
        public string id { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
