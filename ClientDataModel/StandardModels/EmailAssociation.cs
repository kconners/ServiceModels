using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class EmailAssociation
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string emailqueueid { get; set; } public string ownertype { get; set; } public string ownerid { get; set; } public string rowkey { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
