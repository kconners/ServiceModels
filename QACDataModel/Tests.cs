using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
    public class TestsReturn
    {
        public Metadata metadata { get; set; }
        public List<Tests> results { get; set; }
    }

    public class Tests
    {
        public int id { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public int project_id { get; set; }
        public Permissions __permissions { get; set; }
        public bool active { get; set; }
        public int assignee_user_id { get; set; }
        public int avg_run_time { get; set; }
        public string avg_run_time_formated { get; set; }
        public int create_user_id { get; set; }
        public List<object> custom_fields { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_last_escalated { get; set; }
        public DateTime date_updated { get; set; }
        public string description { get; set; }
        public string execution_type { get; set; }
        public int folder_id { get; set; }
        public string folder_name { get; set; }
        public int import_id { get; set; }
        public string last_escalation_rule { get; set; }
        public int last_escalation_rule_id { get; set; }
        public string last_run_by_name { get; set; }
        public int last_run_by_user_id { get; set; }
        public DateTime last_run_date { get; set; }
        public string last_run_status { get; set; }
        public int last_run_test_set { get; set; }
        public string last_run_test_set_title { get; set; }
        public int nbr_escalations { get; set; }
        public int nbr_events { get; set; }
        public int nbr_fail_status { get; set; }
        public int nbr_files { get; set; }
        public int nbr_notes { get; set; }
        public int nbr_pass_status { get; set; }
        public int nbr_steps { get; set; }
        public int nbr_times_run { get; set; }
        public int original_id { get; set; }
        public string owner_name { get; set; }
        public string priority { get; set; }
        public int owner_user_id { get; set; }
        public List<TestStep> test_steps { get; set; }
        public int update_user_id { get; set; }
        public string test_type { get; set; }
        public string user_name { get; set; }
        public int version { get; set; }
    }
    public class TestStep
    {
        public int id { get; set; }
        public int create_user_id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public string expected_result { get; set; }
        public bool is_stopped_on_fail { get; set; }
        public int nbr_files { get; set; }
        public int seq { get; set; }
        public string step { get; set; }
        public int update_user_id { get; set; }
    }
}
