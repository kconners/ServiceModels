using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    class CSAgent
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string roleid { get; set; } public string groupid { get; set; } public string agentnumber { get; set; } public string firstname { get; set; } public string lastname { get; set; } public string emailaddress { get; set; } public string phonenumber { get; set; } public string extension { get; set; } public string username { get; set; } public string failedpasswordattemptcount { get; set; } public string password { get; set; } public string salt { get; set; } public string passwordchangerequired { get; set; } public string passwordexpiredate { get; set; } public string csstatus { get; set; } public string createdby { get; set; } public string resetcode { get; set; } public string resetcodedate { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
