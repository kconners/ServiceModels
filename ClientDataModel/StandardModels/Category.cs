using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Category
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string id { get; set; }
        public string parentcategoryid { get; set; }
        public string name { get; set; }
        public string isvisibleinln { get; set; }
        public string description { get; set; }
        public string categorytype { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
