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
            public string Iteration { get; set; }
            public string Build { get; set; }
            public string Application { get; set; }
            public string LWVersion { get; set; }
            public string LWIteration { get; set; }
            public string LWBuild { get; set; }
            public string TestSetName { get; set; }
            public string URL { get; set; }
            public Guid LWVersion_IDNUM { get; set; }
            public Guid LWBuild_IDNUM { get; set; }
            public Guid LWITeration_IDNUM { get; set; }

            public RunItems(QADataModel.TestingObjects.RunItems RI)
            {
                this.Application = RI.Application;
                this.Client_Name = RI.Client_Name;
                this.Org_Name = RI.Org_Name;
                this.Env_Short = RI.Env_Short;
                this.UserName = RI.UserName;
                this.OrgsEnvShortName = RI.OrgsEnvShortName;
                this.OrgsEnv_LongName = RI.OrgsEnv_LongName;
                this.Release = RI.Release;
                this.Build = RI.Build;
                this.LWVersion = RI.LWVersion;
                this.LWBuild = RI.LWBuild;
                this.LWVersion_IDNUM = RI.LWVersion_IDNUM;
                this.LWBuild_IDNUM = RI.LWBuild_IDNUM;
            }
            public RunItems()
            {

            }
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
