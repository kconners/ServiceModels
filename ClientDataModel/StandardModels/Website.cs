using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Website
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string identifyMemberBy { get; set; }
        public string defaultRouteURL { get; set; }
        public string defaultSkin { get; set; }
        public string automationCreateDefaultPages { get; set; }
        public string style { get; set; }
        public string error_enableValidationsSummaries { get; set; }
        public string error_showFieldLevelValidation { get; set; }
        public string error_showSummaryInContentArea { get; set; }
        public string error_contentArea { get; set; }
        public string error_summaryHeaderResourceKey { get; set; }
        public string error_summaryHeaderText { get; set; }
        public string actions { get; set; }
        public string actions_domain { get; set; }
        public string actions_DCSID { get; set; }
    }
}
