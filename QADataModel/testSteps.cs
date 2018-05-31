using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class testSteps
    {
        public class teststep
        {
            public Guid TestStep_IDNumber { get; set; }
            public Guid Script_IDNumber { get; set; }
            public Guid Test_IDNumber { get; set; }
            public Int32 stepNumber;
            public string webAction { get; set; }
            public string Description { get; set; }
            public string value_1 { get; set; }
            public string value_2 { get; set; }
            public string value_3 { get; set; }
            public string value_4 { get; set; }
            public string value_5 { get; set; }
            public string value_6 { get; set; }
            public string value_7 { get; set; }
            public string value_8 { get; set; }
            public string value_9 { get; set; }
            public string value_10 { get; set; }
            public string value_11 { get; set; }
            public string value_12 { get; set; }
            public string value_13 { get; set; }
            public string value_14 { get; set; }
            public string value_15 { get; set; }
            public string value_16 { get; set; }
            public string value_17 { get; set; }
            public string value_18 { get; set; }
            public string value_19 { get; set; }
            public string value_20 { get; set; }

            public Int32 Status = 1;
        }

        public class TestStepsRoot
        {
            public teststep teststeps { get; set; }
        }
        public class RootObject
        {
            public List<teststep> teststeps { get; set; }
        }
    }
}
