using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
    public class Release
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int folder_id { get; set; }
        public int release_id { get; set; }
        public int parent_id { get; set; }
        public string release_type { get; set; }
        public string title { get; set; }
        public int owner_user_id { get; set; }
        public int assignee_user_id { get; set; }
        public bool is_auto_adjust_est_dates { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public int create_user_id { get; set; }
        public int update_user_id { get; set; }
        public bool is_active { get; set; }
        public string status_code { get; set; }
        public DateTime est_start_date { get; set; }
        public DateTime est_finish_date { get; set; }
        public int seq_num { get; set; }
        public int import_id { get; set; }
        public string parent_name { get; set; }
        public string description { get; set; }
        public string updated_user_name { get; set; }
        public string created_user_name { get; set; }
        public int nbr_files { get; set; }
        public int nbr_notes { get; set; }
        public List<object> custom_fields { get; set; }
        public Permissions __permissions { get; set; }
    }
    public class Permissions
    {
        public int acl { get; set; }
    }

    public class ReleasesReturn
    {
        public Metadata metadata { get; set; }
        public List<Release> results { get; set; }
    }
    public class ResultSet
    {
        public int count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
    }

    public class Metadata
    {
        public ResultSet result_set { get; set; }
        public Permissions permissions { get; set; }
    }
}
