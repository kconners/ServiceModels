using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class testcase
    {
        public class TestCase
        {
            public Guid row_idnum { get; set; }
            public Guid client_idnum { get; set; }
            public Guid program_idnum { get; set; }
            public Guid project_idnum { get; set; }
            public Guid mot_idnum { get; set; }
            public Guid aof_idnum { get; set; }
            public string testtype { get; set; }
            public string iteration { get; set; }
            public string prd { get; set; }
            public string requirement_id { get; set; }
            public string use_case { get; set; }
            public string test_case { get; set; }
            public string test_case_title { get; set; }
            public string test_case_description { get; set; }
            public string module { get; set; }
            public string feature { get; set; }
            public Guid feature_idnumber { get; set; }
            public string feature_type { get; set; }
            public string test_case_id { get; set; }
            public string test_condition { get; set; }
            public string test_steps { get; set; }
            public string expected_results { get; set; }
            public string assigned_to { get; set; }
            public string tested_by { get; set; }
            public string notes { get; set; }
            public string automated_yes_no { get; set; }
            public string automation_script_name { get; set; }
            public Int32 automation_test_status = 0;
            public string regression_yes_no { get; set; }
            public string execution_version { get; set; }
            public string execution_notes { get; set; }
            public DateTime aproveddate { get; set; }
            public Int32 qatestcasenum = 0;
            public Guid qa_test_idnum { get; set; }
            public Guid br_idnum { get; set; }
            public string aprovedby { get; set; }
            public Int32 testcasenum = 0;
            public Guid rorv_idnum { get; set; }
            public Guid pi_mapping_idnum { get; set; }
            public Guid auto_test_idnum { get; set; }
            public Guid standard_test_idnum { get; set; }
            public DateTime created_date { get; set; }
            public Int32 Status = 1;
        }
        public class TestCaseRoot
        {
            public TestCase testcases { get; set; }
        }
        public class TestCaseRootObject
        {
            public List<TestCase> testcases { get; set; }
        }


        public class FullTestCase : TestCase
        {
            public string program { get; set; }
            public string workflow { get; set; }
            public string project { get; set; }
            public string mot { get; set; }
            public string aof { get; set; }
            public Guid wf_idnum { get; set; }
        }
        public class FullTestCaseRoot
        {
            public FullTestCase testcases { get; set; }
        }
        public class FullTestCaseRootObject
        {
            public List<FullTestCase> testcases { get; set; }
        }

        public class QACompleteTestCase : TestCase
        {
            public string folder { get; set; }
            public string folder_idnum { get; set; }
            public string qacompleteTitle { get; set; }
            public string qacompleteDescription { get; set; }
            public string qacStatus { get; set; }
            public string qactesttype { get; set; }
            public string qacexecutionType { get; set; }
            public string qacpriority { get; set; }

        }
        public class QACompleteRoot
        {
            public QACompleteTestCase testcases { get; set; }
        }
        public class QACompleteRootObject
        {
            public List<QACompleteTestCase> testcases { get; set; }
        }

    }
}
