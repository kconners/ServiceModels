using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class RewardDef

    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string id { get; set; }
        public string certificatetypecode { get; set; }
        public string name { get; set; }
        public string howmanypointstoearn { get; set; }
        public string pointtype { get; set; }
        public string pointevent { get; set; }
        public string productid { get; set; }
        public string tierid { get; set; }
        public string threshhold { get; set; }
        public string smallimagefile { get; set; }
        public string largeimagefile { get; set; }
        public string catalogstartdate { get; set; }
        public string catalogenddate { get; set; }
        public string active { get; set; }
        public string fulfillmentproviderid { get; set; }
        public string mediumimagefile { get; set; }
        public string locationgroupid { get; set; }
        public string redeemtimelimit { get; set; }
        public string pushnotificationid { get; set; }
        public string rewardtype { get; set; }
        public string conversionrate { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;

    }
}