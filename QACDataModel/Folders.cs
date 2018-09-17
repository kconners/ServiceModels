using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
    public class Folders
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int project_id { get; set; }
        public string entity_code { get; set; }
        public string folder_name { get; set; }
        public bool is_active { get; set; }
        public bool is_public { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public int update_user_id { get; set; }
        public int owner_user_id { get; set; }
        public string full_folder_name { get; set; }
        public string updated_user_name { get; set; }
        public string created_user_name { get; set; }
        public string parent_name { get; set; }
    }

    public class FoldersReturm
    {
        public Metadata metadata { get; set; }
        public List<Folders> results { get; set; }
    }
}
