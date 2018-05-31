using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class ProgramValues
    {
        public class RunItems
        {
            public string Client_Name { get; set; }
            public string Org_Name { get; set; }
            public string Env_Short { get; set; }
            public string UserName { get; set; }
            public string OrgsEnvShortName { get; set; }
            public string OrgsEnv_LongName { get; set; }
            public string Release { get; set; }
            public string Build { get; set; }
            public string Application { get; set; }
            public string LWVersion { get; set; }
            public string LWBuild { get; set; }
            public Guid LWVersion_IDNUM { get; set; }
            public Guid LWBuild_IDNUM { get; set; }
        }
        public class GlobalVar
        {

            public string Client_Long { get; set; }
            public string Client_Shrt { get; set; }
            public string Env_Long { get; set; }
            public string Env_Shrt { get; set; }
            public string Org_BeingTested { get; set; }
            public string Orgs_Env_Long { get; set; }
            public string Orgs_Env_Shrt { get; set; }
            public string Release { get; set; }
            public string Build { get; set; }
        }
        public class ScriptRunner
        {
            public string UserName { get; set; }
            public string TestSetName { get; set; }
        }

        //public class RunItems
        //{
        //    public string Client_Name { get; set; }
        //    public string Org_Name { get; set; }
        //    public string Env_Short { get; set; }
        //    public string UserName { get; set; }
        //    public string OrgsEnvShortName { get; set; }
        //    public string OrgsEnv_LongName { get; set; }
        //    public string Release { get; set; }
        //    public string Build { get; set; }
        //    public string Application { get; set; }
        //    public string LWVersion { get; set; }
        //    public string LWBuild { get; set; }
        //    public Guid LWVersion_IDNUM { get; set; }
        //    public Guid LWBuild_IDNUM { get; set; }
        //}
        //public class GlobalVar
        //{

        //    public string Client_Long { get; set; }
        //    public string Client_Shrt { get; set; }
        //    public string Env_Long { get; set; }
        //    public string Env_Shrt { get; set; }
        //    public string Org_BeingTested { get; set; }
        //    public string Orgs_Env_Long { get; set; }
        //    public string Orgs_Env_Shrt { get; set; }
        //    public string Release { get; set; }
        //    public string Build { get; set; }
        //}
        //public class ScriptRunner
        //{
        //    public string UserName { get; set; }
        //    public string TestSetName { get; set; }
        //}
    }
}
