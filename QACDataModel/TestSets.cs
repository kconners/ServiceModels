using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{


    public class TestSets
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int folder_id { get; set; }
        public int create_user_id { get; set; }
        public int update_user_id { get; set; }
        public int owner_user_id { get; set; }
        public int assignee_user_id { get; set; }
        public string title { get; set; }
        public bool is_active { get; set; }
        public bool is_sequential { get; set; }
        public string status_code { get; set; }
        public string execution_type { get; set; }
        public string description { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public string folder_name { get; set; }
        public string user_name { get; set; }
        public string owner_name { get; set; }
        public int nbr_tests { get; set; }
        public string last_run_status { get; set; }
        public DateTime last_run_date { get; set; }
        public int last_run_by_user_id { get; set; }
        public string last_run_by_user_name { get; set; }
        public int nbr_times_run { get; set; }
        public int avg_run_time { get; set; }
        public string avg_run_time_formated { get; set; }
        public int nbr_files { get; set; }
        public int nbr_notes { get; set; }
        public int last_run_release_id { get; set; }
        public string last_run_release_name { get; set; }
        public int last_run_test_config_id { get; set; }
        public bool allow_run { get; set; }
        public int nbr_schedules { get; set; }
        public DateTime est_start { get; set; }
        public DateTime est_finish { get; set; }
        public int est_hrs { get; set; }
        public int est_hrs_remaining { get; set; }
        public DateTime act_start { get; set; }
        public DateTime act_finish { get; set; }
        public int act_hrs { get; set; }
        public int pct_complete { get; set; }
        public int original_id { get; set; }
        public int import_id { get; set; }
        public List<object> custom_fields { get; set; }
        public string priority_code { get; set; }
        public string assigned_to_name { get; set; }
    }

    public class TestSetReturn
    {
        public Metadata metadata { get; set; }
        public List<TestSets> results { get; set; }
    }
}
