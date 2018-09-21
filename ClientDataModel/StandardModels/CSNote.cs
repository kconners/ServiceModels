using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class CSNote
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string memberid { get; set; } public string note { get; set; } public string createdby { get; set; } public string deleted { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
