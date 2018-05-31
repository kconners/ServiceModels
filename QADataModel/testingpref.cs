using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class testingpref
    {
        public Guid TestingPref_IDNumber { get; set; }
        public Guid User_IDNumber { get; set; }
        public Guid Client_IDNumber { get; set; }
        public Guid Env_IDNumber { get; set; }
        public Guid Application_IDNumber { get; set; }
        public int browsertype { get; set; }
        public Guid Release_IDNumber { get; set; }
        public Guid Iteration_IDNumber { get; set; }
        public Guid Build_IDNumber { get; set; }
        public Guid TestSet_IDNumber { get; set; }
        public Guid Test_IDNumber { get; set; }
        public string scriptname { get; set; }
        public int Status { get; set; }
    }

    public class TestPreferenceRoot
    {
        public testingpref testingPreferences { get; set; }
    }
    public class TestPreferencesRootObjects
    {
        public List<testingpref> testingPreferences { get; set; }
    }



    public class QuickTestingPreferences
    {
        public class RootObject
        {
            public testingpref testingPreferences { get; set; }
        }
    }


    public class testingprefForRunItems
    {
        public Guid TestingPref_IDNumber { get; set; }
        public Guid User_IDNumber { get; set; }
        public Guid Client_IDNumber { get; set; }
        public Guid Env_IDNumber { get; set; }

        public Guid Release_IDNumber { get; set; }
        public Guid Iteration_IDNumber { get; set; }
        public Guid Build_IDNumber { get; set; }

        public Guid Org_IDNumber { get; set; }
        public Guid OrgEnv_IDNumber { get; set; }

        public Guid LWVersion_IDNumber { get; set; }
        public Guid LWBuild_IDNumber { get; set; }

        public int Status { get; set; }
    }

    public class TestPreferenceForRunItemsRoot
    {
        public testingprefForRunItems testingPreferences { get; set; }
    }
}
