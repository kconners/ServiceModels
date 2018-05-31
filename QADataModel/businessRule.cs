using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class businessRule
    {
        public class business_rule_value
        {
            public Guid row_idnumber { get; set; }
            public Guid businessRule_idnumber { get; set; }
            public Guid br_value_type_idnumber { get; set; }
            public Guid br_builder_order_idnumber { get; set; }
            public string valueType { get; set; }
            public string builderOrder { get; set; }
            public string displayName { get; set; }
            public string value { get; set; }
            public Int32 Status = 1;
        }
        public class business_rule_valueRoot
        {
            public business_rule_value values { get; set; }
        }
        public class business_rule_valueObject
        {
            public List<business_rule_value> values { get; set; }
        }

        public class business_rule_mapping
        {
            public Guid row_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid br_idnumber { get; set; }
            public Guid br_builder_order_idnumber { get; set; }
            public string valueType { get; set; }
            public string builderOrder { get; set; }
            public string displayName { get; set; }
            public string value { get; set; }
            public Int32 Status = 1;
        }
        public class business_rule_mappingRoot
        {
            public business_rule_mapping mappings { get; set; }
        }
        public class business_rule_mappingObject
        {
            public List<business_rule_mapping> mappings { get; set; }
        }

        public class Client_Program_BR_mapping
        {
            public Guid row_idnumber { get; set; }
            public Guid client_idnumber { get; set; }
            public Guid br_idnumber { get; set; }
            public Guid program_idnumber { get; set; }
            public Int32 Status = 1;
        }
        public class Client_Program_BR_mappingRoot
        {
            public Client_Program_BR_mapping mappings { get; set; }
        }
        public class Client_Program_BR_mappingObject
        {
            public List<Client_Program_BR_mapping> mappings { get; set; }
        }

    }
}
