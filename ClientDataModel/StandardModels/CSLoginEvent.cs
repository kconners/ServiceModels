using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    class CSLoginEvent
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string providedusername { get; set; } public string providedpassword { get; set; } public string remoteipaddress { get; set; } public string remoteusername { get; set; } public string remoteuseragent { get; set; } public string eventsource { get; set; } public string eventtype { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
