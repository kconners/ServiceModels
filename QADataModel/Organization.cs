using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class Organization
    {
        public Guid Org_IDNUm { get; set; }
        public string ORGID = string.Empty;
        public string OrgName = string.Empty;
        public string OrgStatus = string.Empty;
        public string OrgDescription = string.Empty;
        public string OrgContact = string.Empty;
        public string OrgContactNum = string.Empty;
        public string OrgContactEmail = string.Empty;
        public string OrgOracleSchema = string.Empty;
        public string OrgDotNetDLLLocation = string.Empty;
    }
}
