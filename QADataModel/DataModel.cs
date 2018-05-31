using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class DataModel
    {
        public class Datamodel
        {
            public Guid DataModel_idnumber { get; set; }
            public Guid parent_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid standard_idnumber { get; set; }
            public string modelName { get; set; }
            public int Status { get; set; }
            public int Level { get; set; }

        }

        public class getDataModel
        {
            public List<Datamodel> datamodels { get; set; }
        }

        public class DataModelRootObject
        {
            public Datamodel datamodels { get; set; }
        }



        public class DatamodelMapping
        {
            public Guid DataModel_idnumber { get; set; }
            public Guid parent_idnumber { get; set; }
            public Guid row_idnumber { get; set; }
            public Guid scenario_idnumber { get; set; }
            public string modelName { get; set; }
            public int Status { get; set; }
            public int Level { get; set; }
        }

        public class DatamodelMappingRoot
        {
            public DatamodelMapping datamodelmappings { get; set; }
        }

        public class DatamodelMappingRootObject
        {
            public List<DatamodelMapping> datamodelmappings { get; set; }

        }

        public class dataModelAttribute
        {
            public Guid standard_idnumber = new Guid();
            public Guid attribute_idnumber = new Guid();
            public Guid DataModel_idnumber = new Guid();
            public Guid client_idnumber = new Guid();
            public string attribute = string.Empty;
            public string attributelabel = string.Empty;
            public string attribute_type = string.Empty;
            public int Status = 1;
        }

        public class getDataModelAttributes
        {
            public List<dataModelAttribute> dataModelAttributes { get; set; }
            public List<Datamodel> children { get; set; }
        }
    }
}
