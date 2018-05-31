using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class Jira
    {
        public class ticket
        {
            public Guid row_idnumber { get; set; }
            public string affectsversions { get; set; }
            public string assignee { get; set; }
            public string components { get; set; }
            public string created { get; set; }
            public string client { get; set; }
            public string creator { get; set; }
            public string customfields { get; set; }
            public string descr { get; set; }
            public string duedate { get; set; }
            public string environment { get; set; }
            public string fixversions { get; set; }
            public string jira { get; set; }
            public string jiraidentifier { get; set; }
            public string issuekey { get; set; }
            public string issuepriority { get; set; }
            public string securitylevel { get; set; }
            public string severity { get; set; }
            public string qaresource { get; set; }
            public string project { get; set; }
            public string reporter { get; set; }
            public string resolution { get; set; }
            public string issuestatus { get; set; }
            public string summary { get; set; }
            public string issuetype { get; set; }
            public string updated { get; set; }
            public string votes { get; set; }
            public Int32 Status = 1;
        }
        public class ticketsForMapping : ticket
        {

            int testCaseCount = 0;

        }

        public class ticketRoot
        {
            public ticket tickets { get; set; }
        }
        public class ticketRootObject
        {
            public List<ticket> tickets { get; set; }
        }

        public class issuelink
        {
            public Guid row_idnumber { get; set; }
            public string project { get; set; }
            public string linkid { get; set; }
            public string linkfromticketnum { get; set; }
            public string linktoticketnum { get; set; }
            public string linktype { get; set; }
            public Int32 Status = 1;
        }
        public class issuelinkRoot
        {
            public issuelink links { get; set; }
        }
        public class issuelinkRootObject
        {
            public List<issuelink> links { get; set; }
        }

        public class fixMapping
        {
            public Guid row_idnumber { get; set; }
            public string issue_key { get; set; }
            public string release_id { get; set; }
            public string release_name { get; set; }
            public string release_description { get; set; }
            public Int32 Status = 1;
        }
        public class fixMappingRoot
        {
            public fixMapping mappings { get; set; }
        }
        public class fixMappingRootObject
        {
            public List<fixMapping> mappings { get; set; }
        }

        public class comment
        {
            public Guid row_idnumber { get; set; }
            public Guid issue_idnumber { get; set; }

            public string issue_key { get; set; }
            public string self { get; set; }
            public string id { get; set; }
            public string author { get; set; }
            public string body { get; set; }
            public string updateauthor { get; set; }
            public string created { get; set; }
            public string updated { get; set; }

            public Int32 Status = 1;
        }
        public class commentRoot
        {
            public comment comments { get; set; }
        }
        public class commentRootObject
        {
            public List<comment> comments { get; set; }
        }

        public class label
        {
            public Guid row_idnumber { get; set; }
            public Guid issue_idnumber { get; set; }

            public string issue_key { get; set; }
            public string name { get; set; }

            public Int32 Status = 1;
        }
        public class labelRoot
        {
            public label labels { get; set; }
        }
        public class labelRootObject
        {
            public List<label> labels { get; set; }
        }


        public class Release_Issue_Mapping
        {
            public Guid row_idnumber { get; set; }
            public Guid release_idnumber { get; set; }
            public Guid issue_idnumber { get; set; }
            public string summary_withTC_Count { get; set; }

            public string issue_key { get; set; }
            public string issue_summary { get; set; }

            public Int32 Status = 1;
        }
        public class Release_Issue_MappingRoot
        {
            public Release_Issue_Mapping mappings { get; set; }
        }
        public class Release_Issue_MappingObject
        {
            public List<Release_Issue_Mapping> mappings { get; set; }
        }



    }
}
