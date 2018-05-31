using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.Framework
{
    public class StandardTables
    {
        public class Tables
        {
            public Guid row_idnumber { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public Int32 Status = 1;
        }

        public class Tables_Root
        {
            public Tables Items { get; set; }
        }
        public class Tables_Roots
        {
            public List<Tables> Items { get; set; }
        }

        public class Table_Columns
        {
            public Guid Row_idnumber { get; set; }
            public Guid Table_idnumber { get; set; }
            public string Name { get; set; }
            public Int32 Ordernumber { get; set; }
            public string Type { get; set; }
            public Int32 Status = 1;
        }

        public class Table_columns_Root
        {
            public Table_Columns Items { get; set; }
        }
        public class Table_columns_Roots
        {
            public List<Table_Columns> Items { get; set; }
        }

    }
}
