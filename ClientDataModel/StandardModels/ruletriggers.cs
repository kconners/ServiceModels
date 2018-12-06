using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataModel.StandardModels
{
    public class ruletriggers
    {
        public Guid row_idnumber { get; set; }
        public Guid env_idnumber { get; set; }
        public string ruletriggerid { get; set; }
        public string attributesetcode { get; set; }
        public string sequence { get; set; }
        public string invocationtype { get; set; }
        public RuleType ruletype { get; set; }
        public string conditionalexpression { get; set; }
        public string ruleinstance { get; set; }
        public string canqueue { get; set; }
        public string isconfigured { get; set; }
        public string rulename { get; set; }
        public string promotioncode { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string targeted { get; set; }
        public string continueonerror { get; set; }
        public string alwaysrun { get; set; }
        public string logexecution { get; set; }
        public string owningobject { get; set; }
        public string createdate { get; set; }
        public string updatedate { get; set; }
        public Int32 Status = 1;
        
    }

    public class ruleConfiguration
    {
        public class AwardLoyaltyCurrency
        {
            public string NegativeAdjustmentPointType { get; set; }
            public string TransientPropertyName { get; set; }
            public string TransientPropertyExpression { get; set; }
            public string LocationIdExpression { get; set; }
            public string ChildAttributeSetName { get; set; }
            public string ChangedByExpression { get; set; }
            public string EvaluateTierRule { get; set; }
            public string PointAwardMethod { get; set; }
            public string PointBatchMode { get; set; }
            public string VirtualCardLocationLogic { get; set; }
            public string VirtualCardNumber { get; set; }
            public string ExpireDate { get; set; }
            public string PointsExpirationMethod { get; set; }
            public string ExpirationDays { get; set; }
            public string PointBankTransactionDate { get; set; }
            public string PointEventType { get; set; }
            public string PointType { get; set; }
            public string AccrualExpression { get; set; }
            public string AllowZeroPoints { get; set; }
            public string PutPointsOnHold { get; set; }
            public string AllowNegativePointBalance { get; set; }
            public string RuleVersion { get; set; }
            public string DescriptionExpression { get; set; }
            public string RuleId { get; set; }
            public string RuleName { get; set; }
            public string RuleDescription { get; set; }
        }
        public class IssueReward
        {
            public string FulfillmentOption { get; set; }
            public string IssuedRewardType { get; set; }
            public string PointsConsumption { get; set; }
            public string IssueMemberRewardChoice { get; set; }
            public string ExhaustPoints { get; set; }
            public string MarkAsRedeemed { get; set; }
            public string AssignLWCertificate { get; set; }
            public string RuleName { get; set; }
            public string OfferCode { get; set; }
            public string RewardType { get; set; }
            public string ExpiryDateExpression { get; set; }
            public string ChangedByExpression { get; set; }
            public string TriggeredEmailName { get; set; }
            public string LowThresholdEmailName { get; set; }
            public string LowCertificatesEmailRecepient { get; set; }
            public string RuleVersion { get; set; }
            public string RuleId { get; set; }
            public string RuleDescription { get; set; }
        }

        public class IssueCoupon
        {
            public string OfferCode { get; set; }
            public string AssignLWCertificate { get; set; }
            public string LowThresholdEmailName { get; set; }
            public string LowCertificatesEmailRecepient { get; set; }
            public string CouponType { get; set; }
            public string StartDateExpression { get; set; }
            public string ExpiryDateExpression { get; set; }
            public string RuleVersion { get; set; }
            public string RuleId { get; set; }
            public string RuleName { get; set; }
            public string RuleDescription { get; set; }
        }
        public class EvaluateTier
        {
            public string OverrideTier { get; set; }
            public string IncludeExpiredPoints { get; set; }
            public string VirtualCardLocationLogic { get; set; }
            public string VirtualCardNumber { get; set; }
            public string Tiers { get; set; }
            public string ExpireDate { get; set; }
            public string TierUpgradeEmailName { get; set; }
            public string TierDowngradeEmailName { get; set; }
            public string RuleVersion { get; set; }
            public string RuleId { get; set; }
            public string RuleName { get; set; }
            public string RuleDescription { get; set; }
        }
    }
    public enum RuleType
    {
        AwardDefaultContent,
        AwardLoyaltyCurrency,
        ChangeMembersPassword,
        CreateVirtualCard,
        EvaluateTier,
        ExecuteRealtimeCampaign,
        IssueCoupon,
        IssueMessage,
        IssueReward,
        IssueRewardFromCatalog,
        SendPushNotification,
        SendSms,
        SendTriggeredEmail,
        UpdateGooglePayLoyaltyCard,
        UpdateLastActivity
    }
}
