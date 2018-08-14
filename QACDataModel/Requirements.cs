using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACDataModel
{
    public class Requirements
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public Permissions __permissions { get; set; }
        public DateTime act_finish { get; set; }
        public double act_hrs { get; set; }
        public DateTime act_start { get; set; }
        public int assignee_user_id { get; set; }
        public string business_rule { get; set; }
        public List<object> custom_fields { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_last_escalated { get; set; }
        public DateTime date_opened { get; set; }
        public DateTime date_updated { get; set; }
        public string description { get; set; }
        public DateTime est_finish { get; set; }
        public double est_hrs { get; set; }
        public double est_hrs_remaining { get; set; }
        public DateTime est_start { get; set; }
        public int folder_id { get; set; }
        public string folder_name { get; set; }
        public int import_id { get; set; }
        public string last_escalation_rule { get; set; }
        public int last_escalation_rule_id { get; set; }
        public int nbr_escalations { get; set; }
        public int nbr_events { get; set; }
        public int nbr_files { get; set; }
        public int nbr_notes { get; set; }
        public int nbr_tasks { get; set; }
        public int opened_by { get; set; }
        public string opened_by_company { get; set; }
        public string opened_by_email { get; set; }
        public string opened_by_name { get; set; }
        public int original_id { get; set; }
        public string owner_name { get; set; }
        public int owner_user_id { get; set; }
        public double pct_complete { get; set; }
        public int update_user_id { get; set; }
        public string user_name { get; set; }
    }

    public class RequirementsReturn
    {
        public Metadata metadata { get; set; }
        public List<Requirements> results { get; set; }
    }
    
}
