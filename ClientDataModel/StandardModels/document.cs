using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    class document
    { public Guid row_idnumber { get; set; } public Guid env_idnumber { get; set; } public string id { get; set; } public string templateid { get; set; } public string name { get; set; } public string documenttype { get; set; } public string version { get; set; } public string islocked { get; set; } public string properties { get; set; } public string htmlcontentareas { get; set; } public string textcontentareas { get; set; } public string postprocessingconfig { get; set; } public string createdate { get; set; } public string updatedate { get; set; } public Int32 Status = 1; }
}
