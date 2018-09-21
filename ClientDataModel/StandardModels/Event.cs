using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class Event
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string name { get; set; } public string displaytext { get; set; } public string description { get; set; } public string userdefined { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
