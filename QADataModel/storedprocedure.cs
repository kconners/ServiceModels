using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class storedprocedure
    {

        public class storedproc
        {
            public Guid row_idnumber { get; set; }
            public string name { get; set; }
            public string shrt_nm { get; set; }
            public string type { get; set; }
            public string release { get; set; }
            public string build { get; set; }
            public string script { get; set; }
            public string Created_By { get; set; }
            public DateTime Create_Date { get; set; }
            public string UPdated_By { get; set; }
            public DateTime Updated_Date { get; set; }
            public int Status { get; set; }
        }


    }
}
