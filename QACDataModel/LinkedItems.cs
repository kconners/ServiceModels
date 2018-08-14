using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{

    public class LinkedItems
    {
        public int link_id { get; set; }
        public string entity_code { get; set; }
        public int entity_id { get; set; }
        public string linked_entity_code { get; set; }
        public int linked_entity_id { get; set; }
        public string title { get; set; }
        public bool is_active { get; set; }
        public string status { get; set; }
        public DateTime date_updated { get; set; }
        public int update_user_id { get; set; }
        public string updated_user_name { get; set; }
    }

    public class LinkedItemsReturn
    {
        public Metadata metadata { get; set; }
        public List<LinkedItems> results { get; set; }
    }
}
