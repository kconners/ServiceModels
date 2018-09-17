using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
   
   
    public class Notes
    {
        public int id { get; set; }
        public int entity_id { get; set; }
        public string entity_code { get; set; }
        public string description { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public int original_id { get; set; }
        public int seq { get; set; }
        public int update_user_id { get; set; }
        public string user_name { get; set; }
    }

    public class RootObject
    {
        public Metadata metadata { get; set; }
        public List<Notes> results { get; set; }
    }
}
