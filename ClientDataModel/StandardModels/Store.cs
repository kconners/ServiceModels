using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Store
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }

        public string storeid { get; set; }
        public string storenumber { get; set; }
        public string storename { get; set; }
        public string storestatus { get; set; }
        public string store_status { get; set; }
        public string brandname { get; set; }
        public string brandstorenumber { get; set; }
        public string phonenumber { get; set; }
        public string addresslineone { get; set; }
        public string addresslinetwo { get; set; }
        public string city { get; set; }
        public string stateorprovince { get; set; }
        public string ziporpostalcode { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string opendate { get; set; }
        public string closedate { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string region { get; set; }
        public string district { get; set; }
        public string zone { get; set; }
        public string struserfield { get; set; }
        public string longuserfield { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
        
    }
}
