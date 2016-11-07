using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {
        ///<![CDATA[Account linked to the transaction]]>
        public Guid Account { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Reference to ProjectWBS (work breakdown structure)]]>
        public Guid Activity { get; set; }

        ///<![CDATA[Description of ProjectWBS]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ActivityDescription { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }

        ///<![CDATA[Amount in the currency of the transaction of the transaction]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Attachment linked to the transaction]]>
        public Guid Attachment { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency of the amount]]>
        public string Currency { get; set; }

        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Description of Division]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DivisionDescription { get; set; }

        ///<![CDATA[Employee linked to the transaction]]>
        public Guid Employee { get; set; }

        ///<![CDATA[End time of the transaction]]>
        public DateTime EndTime { get; set; }

        ///<![CDATA[Entrynumber]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Errortext, used for the backgroundjobs]]>
        public string ErrorText { get; set; }

        ///<![CDATA[Status of the transaction]]>
        public Int16 HourStatus { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Item linked to the transaction. Items of type 'time' are linked to time transactions. Items of other types are linked to cost transactions]]>
        public Guid Item { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[True if you can use decimals for item quantity]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Notes linked to the transaction]]>
        public string Notes { get; set; }

        ///<![CDATA[Price in the currency of the transaction]]>
        public double? Price { get; set; }

        ///<![CDATA[PriceFC (AmountFC = Quantity * PriceFC)]]>
        public double? PriceFC { get; set; }

        ///<![CDATA[Project linked to the transaction]]>
        public Guid Project { get; set; }

        ///<![CDATA[Reference to project account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid ProjectAccount { get; set; }

        ///<![CDATA[Project account code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectAccountCode { get; set; }

        ///<![CDATA[Project account name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectAccountName { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Quantity of the transaction]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Start time of the transaction]]>
        public DateTime StartTime { get; set; }

        ///<![CDATA[Subscription linked to the transaction]]>
        public Guid Subscription { get; set; }

        ///<![CDATA[Account linked to the subscription]]>
        public Guid SubscriptionAccount { get; set; }

        ///<![CDATA[Subscription account code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountCode { get; set; }

        ///<![CDATA[Subscription account name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionAccountName { get; set; }

        ///<![CDATA[Description of the subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        ///<![CDATA[Subscription number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }

        ///<![CDATA[Type of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Type { get; set; }
    }
}