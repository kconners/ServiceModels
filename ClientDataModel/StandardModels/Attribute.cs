using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Attribute
    {

        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string minlength { get; set; }
        public string maxlength { get; set; }
        public string isunique { get; set; }
        public string displaytext { get; set; }
        public string alias { get; set; }
        public string attributecode { get; set; }
        public string statuscode { get; set; }
        public string attributename { get; set; }
        public string datatypecode { get; set; }
        public string attributesetcode { get; set; }
        public string isrequired { get; set; }
        public string encryptiontype { get; set; }
        public string visibleingrid { get; set; }
        public string canbeupdated { get; set; }
        public string issortable { get; set; }
        public string ismigrationtext { get; set; }
        public string defaultvalues { get; set; }
        public string description { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
        public string attributeset_idnum { get; set; }
}
}
