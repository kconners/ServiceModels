using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class qac
    {
        public class Release
        {
            public Guid Release_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string ID { get; set; }
            public Guid TestingApp_IDNumber { get; set; }
            public string QAC_Updated_Date { get; set; }
            public string Type { get; set; }
            public Guid Parent_IDNumber { get; set; }
            public Int32 Parent_ID { get; set; }
            public Int32 Status = 1;
        }
        public class ReleaseRoot
        {
            public Release release { get; set; }
        }
        public class ReleasesRoot
        {
            public List<Release> releases { get; set; }
        }


        public class TestCase
        {
            public Guid TestCase_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public Guid TestingApp_IDNumber { get; set; }
            public string Client_Short { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

            public string PreConditions { get; set; }
            public string Component { get; set; }
            public string SubComponent { get; set; }
            public string Regression { get; set; }

            public string ID { get; set; }
            public string QAC_Updated_Date { get; set; }
            public string Folder { get; set; }
            public Int32 Folder_ID { get; set; }
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


        public class Run
        {
            public Guid Run_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public Guid TestSet_IDNumber { get; set; }
            public Guid Release_IDNumber { get; set; }
            public string Client_Short { get; set; }

            public string Title { get; set; }
            public string ID { get; set; }

            public string testset_id { get; set; }
            public string release_id { get; set; }
            public string testtype { get; set; }
            public string qac_status { get; set; }
            public string execution_type { get; set; }
            public string run_by_user { get; set; }
            public string configuration_name { get; set; }
            public string is_sequential { get; set; }
            public string date_started { get; set; }
            public string date_finished { get; set; }
            public string proj_id { get; set; }
            public string nbr_tests { get; set; }
            public string nbr_passed { get; set; }
            public string nbr_failed { get; set; }
            public string nbr_blocked { get; set; }
            public string nbr_awaiting_run { get; set; }
            public string run_time { get; set; }
            public string run_time_formated { get; set; }


            public Int32 Status = 1;
        }
        public class RunRoot
        {
            public Run runs { get; set; }
        }
        public class RunRootObject
        {
            public List<Run> runs { get; set; }
        }


        public class TraceabilityLink
        {
            public Guid Link_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public string link_id { get; set; }
            public string entity_code { get; set; }
            public string fkid { get; set; }
            public string linked_entity_code { get; set; }
            public string linked_fkid { get; set; }
            public string status_code { get; set; }
            public string title { get; set; }
            public string link_type { get; set; }
            public string date_updated { get; set; }
            public Int32 Status = 1;
        }
        public class TraceabilityLinkRoot
        {
            public TraceabilityLink links { get; set; }
        }
        public class TraceabilityLinkRootObject
        {
            public List<TraceabilityLink> links { get; set; }
        }


        public class TestSetTestCaseMapping
        {
            public Int32 TestSetID { get; set; }
            public Guid TestSet_IDNUM { get; set; }
            public Guid Client_IDNUM { get; set; }
            public Int32 TestCaseID { get; set; }
            public Guid TestCase_IDNUM { get; set; }
            public String TestCaseTitle { get; set; }
            public int Checked { get; set; }
            public int Status = 1;
        }
        public class TestSetTestCaseMappingRoot
        {
            public TestSetTestCaseMapping testset_testcase_mappings { get; set; }
        }
        public class TestSetTestCaseMappingRootObject
        {
            public List<TestSetTestCaseMapping> testset_testcase_mappings { get; set; }
        }


        public class TestSet
        {
            public Guid TestSet_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string ID { get; set; }
            public Guid TestingApp_IDNumber { get; set; }
            public string QAC_Updated_Date { get; set; }
            public Int32 Status = 1;
        }
        public class TestSetRoot
        {
            public TestSet testset { get; set; }
        }




        public class Requirement
        {
            public Guid Requirement_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }
            public Guid TestingApp_IDNumber { get; set; }
            public Guid BP_Testing_Element_IDNumber { get; set; }
            public string ID { get; set; }
            public string Folder { get; set; }
            public string Folder_ID { get; set; }
            public string Title { get; set; }
            public string requirement { get; set; }
            public string QAC_Updated_Date { get; set; }
            public Int32 Status = 1;
        }
        public class RequirementRoot
        {
            public Requirement requirements { get; set; }
        }
        public class RequirementRootObject
        {
            public List<Requirement> requirements { get; set; }
        }



        public class RunItem
        {
            public Guid Run_Item_IDNumber { get; set; }
            public Guid Client_IDNumber { get; set; }

            public string ID { get; set; }

            public string testset_id { get; set; }
            public string testset_title { get; set; }

            public string test_id { get; set; }
            public string test_title { get; set; }
            public string test_description { get; set; }

            public string run_id { get; set; }
            public string release_id { get; set; }

            public string run_item_time_formated { get; set; }
            public string run_item_status { get; set; }
            public string run_item_notes { get; set; }
            public string run_item_configuration { get; set; }


            public Int32 Status = 1;
        }
        public class RunItemRoot
        {
            public RunItem runitems { get; set; }
        }
        public class RunItemRootObject
        {
            public List<RunItem> runitems { get; set; }
        }
    }
}
