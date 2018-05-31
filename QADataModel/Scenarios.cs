using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class Scenarios
    {
        public class scenario
        {
            public Guid Scenario_idnumber { get; set; }
            public Guid Client_idnumber { get; set; }
            public Guid DataModel_idnumber { get; set; }
            public Guid TestCase_idnumber { get; set; }

            public string Scenario { get; set; }
            public string Scnshort { get; set; }
            public string Description { get; set; }

            public int Status { get; set; }
        }

        public class getScenarios
        {
            public List<scenario> scenarios { get; set; }
        }



        public class scenario_attribute_queryvalue
        {
            public Guid Row_idnumber { get; set; }
            public Guid Mapping_idnumber { get; set; }
            public Guid DataModel_idnumber { get; set; }
            public Guid DataModel_Attribute_idnumber { get; set; }
            public string ValueType { get; set; }
            public string Label { get; set; }
            public string Query { get; set; }
            public string EvaluationType { get; set; }
            public string Evaluated_value { get; set; }

            public int Status { get; set; }
        }

        public class get_scenario_attribute_queryvalues
        {
            public List<scenario_attribute_queryvalue> queryValues { get; set; }
        }
        public class get_scenario_attribute_queryvalue
        {
            public scenario_attribute_queryvalue queryValues { get; set; }
        }

        public class UsedGuid
        {
            public Guid Value { get; set; }
            public bool Used;
        }
        public class UsedDate
        {
            public DateTime Value { get; set; }
            public bool Used;
        }
        public class UsedString
        {
            public String Value { get; set; }
            public bool Used;
        }
        public class UsedInt
        {
            public Int32 Value { get; set; }
            public bool Used;
        }





        public class scenario_attribute_query_Global_value
        {
            public Guid Row_idnumber { get; set; }
            public Guid Mapping_idnumber { get; set; }

            public string Guid1 { get; set; }
            public int GuidFromParent1 { get; set; }
            public string Guid2 { get; set; }
            public int GuidFromParent2 { get; set; }

            public string string1 { get; set; }
            public int stringFromParent1 { get; set; }
            public string string2 { get; set; }
            public int stringFromParent2 { get; set; }

            public string Int1 { get; set; }
            public int IntFromParent1 { get; set; }
            public string Int2 { get; set; }
            public int IntFromParent2 { get; set; }

            public string DateTime1 { get; set; }
            public int DateTimeFromParent1 { get; set; }
            public string DateTime2 { get; set; }
            public int DateTimeFromParent2 { get; set; }

            public int Status { get; set; }
        }

        public class get_scenario_attribute_query_Global_value
        {
            public scenario_attribute_query_Global_value globalValues { get; set; }
        }




        public class ExecQueryBody
        {

            public Guid Guid1 { get; set; }
            public Guid Guid2 { get; set; }

            public string string1 { get; set; }
            public string string2 { get; set; }

            public Int32 Int1 { get; set; }
            public Int32 Int2 { get; set; }

            public DateTime DateTime1 { get; set; }
            public DateTime DateTime2 { get; set; }

            public string Label { get; set; }
            public string Query { get; set; }
            public string QueryResult { get; set; }

        }
    }
}
