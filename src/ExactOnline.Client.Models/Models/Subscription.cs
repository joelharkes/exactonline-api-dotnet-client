using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class Subscription
    {
        ///<![CDATA[Indicates if subscription is blocked for time cost entry]]>
        public bool? BlockEntry { get; set; }

        ///<![CDATA[Date of cancellation]]>
        public DateTime CancellationDate { get; set; }

        ///<![CDATA[Reference to Classification]]>
        public Guid Classification { get; set; }

        ///<![CDATA[Code of Classification]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ClassificationCode { get; set; }

        ///<![CDATA[Description of Classification]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }

        ///<![CDATA[Purchase order number of customer]]>
        public string CustomerPONumber { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Invoice Day]]>
        public byte? InvoiceDay { get; set; }

        ///<![CDATA[Invoice date]]>
        public DateTime InvoicedTo { get; set; }

        ///<![CDATA[Reference to invoice account]]>
        public Guid InvoiceTo { get; set; }

        ///<![CDATA[Reference to contact person of invoice account]]>
        public Guid InvoiceToContactPerson { get; set; }

        ///<![CDATA[Name of contact person of invoice account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }

        ///<![CDATA[Name of invoice account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }

        ///<![CDATA[Invoicing start date]]>
        public DateTime InvoicingStartDate { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Number]]>
        public Int32 Number { get; set; }

        ///<![CDATA[Reference to order account]]>
        public Guid OrderedBy { get; set; }

        ///<![CDATA[Reference of contact person of order account]]>
        public Guid OrderedByContactPerson { get; set; }

        ///<![CDATA[Name of contact person of order account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }

        ///<![CDATA[Name of order account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }

        ///<![CDATA[Payment condition]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[Description of PaymentCondition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        ///<![CDATA[Indicates if subscription is printed]]>
        public bool Printed { get; set; }

        ///<![CDATA[Reference to reason cancelled]]>
        public Guid ReasonCancelled { get; set; }

        ///<![CDATA[Code of ReasonCancelled]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledCode { get; set; }

        ///<![CDATA[Description of ReasonCancelled]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ReasonCancelledDescription { get; set; }

        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Collection of subscription lines]]>
        public IEnumerable<SubscriptionLine> SubscriptionLines { get; set; }

        ///<![CDATA[Collection of restriction employees]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionEmployee> SubscriptionRestrictionEmployees { get; set; }

        ///<![CDATA[Collection of restriction items]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<SubscriptionRestrictionItem> SubscriptionRestrictionItems { get; set; }

        ///<![CDATA[Reference to subscription type]]>
        public Guid SubscriptionType { get; set; }

        ///<![CDATA[Code of SubscriptionType]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeCode { get; set; }

        ///<![CDATA[Description of SubscriptionType]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionTypeDescription { get; set; }
    }
}