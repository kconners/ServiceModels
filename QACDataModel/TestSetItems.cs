using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
   
    public class TestSetItems
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int test_set_id { get; set; }
        public int test_id { get; set; }
        public int seq { get; set; }
        public bool is_active { get; set; }
        public bool is_stopped_on_fail { get; set; }
        public int assignee_user_id { get; set; }
        public int default_host_id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public int create_user_id { get; set; }
        public int update_user_id { get; set; }
        public string title { get; set; }
        public int nbr_steps { get; set; }
        public int nbr_files { get; set; }
        public int nbr_notes { get; set; }
    }

    public class TestSetItemsReturn
    {
        public Metadata metadata { get; set; }
        public List<TestSetItems> results { get; set; }
    }
}
