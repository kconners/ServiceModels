using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{

    public class TestRunResult
    {
        public int id { get; set; }
        public int test_run_item_id { get; set; }
        public int seq { get; set; }
        public bool is_stopped_on_fail { get; set; }
        public string status_code { get; set; }
        public string step { get; set; }
        public string expected_result { get; set; }
        public int test_step_id { get; set; }
        public int project_id { get; set; }
        public bool is_tokenized { get; set; }
        public string actual_result { get; set; }
    }

    public class TestRunItems
    {
        public int id { get; set; }
        public int test_set_id { get; set; }
        public int project_id { get; set; }
        public int test_run_id { get; set; }
        public int test_id { get; set; }
        public string test_name { get; set; }
        public int version { get; set; }
        public int sequence_number { get; set; }
        public int seq_token { get; set; }
        public string status_code { get; set; }
        public string run_time_formated { get; set; }
        public bool is_stopped_on_fail { get; set; }
        public string last_run_by_name { get; set; }
        public int release_id { get; set; }
        public string release_name { get; set; }
        public string test_set_name { get; set; }
        public int avg_run_time { get; set; }
        public string avg_run_time_formated { get; set; }
        public string folder_name { get; set; }
        public string test_description { get; set; }
        public DateTime last_run_date { get; set; }
        public bool is_tokenized { get; set; }
        public DateTime test_run_started { get; set; }
        public int run_by_user_id { get; set; }
        public string last_run_status { get; set; }
        public int status_updated_by { get; set; }
        public string status_updated_by_user_name { get; set; }
        public List<TestRunResult> test_run_results { get; set; }
        public string file_report { get; set; }
        public string file_log { get; set; }
        public bool automated { get; set; }
        public string configuration_name { get; set; }
        public string test_host { get; set; }
        public string actualResult { get; set; }
        public int run_time = 0;
    }

    public class TestRunItemsReturn
    {
        public Metadata metadata { get; set; }
        public List<TestRunItems> results { get; set; }
    }
}
