using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Opportunity
    {
        ///<![CDATA[Lead to which the opportunity applies]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Indicates the date before/on the NextAction is supposed to be done]]>
        public DateTime ActionDate { get; set; }

        ///<![CDATA[Amount in the default currency of the company. AmountDC = AmountFC * RateFC]]>
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Reference to the campaign opportunity is related to]]>
        public Guid Campaign { get; set; }

        ///<![CDATA[Description of Campaign]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CampaignDescription { get; set; }

        ///<![CDATA[The date when the opportunity is expected to be closed]]>
        public DateTime CloseDate { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[The source of the lead/opportunity]]>
        public Guid LeadSource { get; set; }

        ///<![CDATA[Description of LeadSource]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string LeadSourceDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Name of the opportunity]]>
        public string Name { get; set; }

        ///<![CDATA[Indicates what follow up action is to be undertaken to move the opportunity towards a deal. Is used in combination with ActionDate]]>
        public string NextAction { get; set; }

        ///<![CDATA[Notes of the opportunity]]>
        public string Notes { get; set; }

        ///<![CDATA[The stage of the opportunity. This is a list defined by the user]]>
        public Guid OpportunityStage { get; set; }

        ///<![CDATA[Description of OpportunityStage]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OpportunityStageDescription { get; set; }

        ///<![CDATA[Status: 1=Open, 2=Closed won, 3=Closed lost]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 OpportunityStatus { get; set; }

        ///<![CDATA[The resource who owns the opportunity and is responsible to close the opportunity (either won or lost)]]>
        public Guid Owner { get; set; }

        ///<![CDATA[Name of Owner]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OwnerFullName { get; set; }

        ///<![CDATA[The chance that the opportunity will be closed and won. The default for the probability depends on the default from the opportunity stage]]>
        public double? Probability { get; set; }

        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Code of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Exchange rate from original to division currency]]>
        public double? RateFC { get; set; }

        ///<![CDATA[Indicates the reason why the opportunity was lost.]]>
        public Guid ReasonCode { get; set; }

        ///<![CDATA[Description of ReasonCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ReasonCodeDescription { get; set; }

        ///<![CDATA[Reference to Sales type]]>
        public Guid SalesType { get; set; }

        ///<![CDATA[Description of SalesType]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesTypeDescription { get; set; }
    }
}