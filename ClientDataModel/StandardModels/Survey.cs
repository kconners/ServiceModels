using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Survey
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string survey_id { get; set; }
        public string survey_name { get; set; }
        public string folderid { get; set; }
        public string survey_description { get; set; }
        public string effective_date { get; set; }
        public string expiration_date { get; set; }
        public string constraintsxml { get; set; }
        public string email_id { get; set; }
        public string surveytype { get; set; }
        public string surveyaudience { get; set; }
        public string displayorder { get; set; }
        public string surveycompleteeventid { get; set; }
        public string surveyterminateandtallyeventid { get; set; }
        public string template_id { get; set; }
        public string document_id { get; set; }
        public string surveystatus { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
    }
}
