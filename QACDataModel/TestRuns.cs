using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
    public class TestRuns
    {
        public int id { get; set; }
        public int test_set_id { get; set; }
        public string test_set_name { get; set; }
        public int release_id { get; set; }
        public int project_id { get; set; }
        public int run_by_user_id { get; set; }
        public string run_by_user_name { get; set; }
        public bool is_sequential { get; set; }
        public string status_code { get; set; }
        public string execution_type { get; set; }
        public DateTime date_started { get; set; }
        public DateTime date_finished { get; set; }
        public int nbr_tests { get; set; }
        public int nbr_passed { get; set; }
        public int nbr_failed { get; set; }
        public int nbr_blocked { get; set; }
        public int nbr_awaiting_run { get; set; }
        public int run_time { get; set; }
        public string run_time_formated { get; set; }
        public string release_name { get; set; }
        public string test_host { get; set; }
        public string configuration_name { get; set; }
    }
    public class TestRunReturn
    {
        public Metadata metadata { get; set; }
        public List<TestRuns> results { get; set; }
    }


    
}
