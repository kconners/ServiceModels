using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
   public class Language
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string culture { get; set; }
        public string language { get; set; }
        public Int32 Status = 1;
    }
}
