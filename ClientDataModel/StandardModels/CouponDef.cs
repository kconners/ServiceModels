using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    class CouponDef
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string name { get; set; } public string isglobal { get; set; } public string categoryid { get; set; } public string coupontypecode { get; set; } public string folderid { get; set; } public string passdefid { get; set; } public string logofilename { get; set; } public string startdate { get; set; } public string expirydate { get; set; } public string usesallowed { get; set; } public string usesperyear { get; set; } public string usespermonth { get; set; } public string usesperweek { get; set; } public string usesperday { get; set; } public string displayorder { get; set; } public string pushnotificationid { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
