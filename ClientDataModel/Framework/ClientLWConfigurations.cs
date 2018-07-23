using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.Framework
{
    public class ClientLWConfigurations
    {
        public class Configuration_Keys
        {
            public Guid row_idnumber { get; set; }
            public string client { get; set; }
            public string env { get; set; }
            public string org_env { get; set; }
            public string key { get; set; }
            public string website { get; set; }
            public string application { get; set; }
            public Int32 Status = 1;
        }

        public class Key_Root
        {
            public Configuration_Keys keys { get; set; }
        }
        public class Key_Roots
        {
            public List<Configuration_Keys> keys { get; set; }
        }

        public enum DBType
        {
            Oracle,
            PostgreSQL
        }

        public class Configurations
        {
            public Guid row_idnumber { get; set; }
            public string client { get; set; }
            public string env { get; set; }
            public string org_env { get; set; }
            public string application { get; set; }
            public Guid key_idnumber { get; set; }

            public string identifier { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string attributename { get; set; }
            public string displaytext { get; set; }

            public Int32 Status = 1;
        }

        public class Configuration_Root
        {
            public Configurations Items { get; set; }
        }
        public class Configuration_Roots
        {
            public List<Configurations> Items { get; set; }
        }


    }
}
