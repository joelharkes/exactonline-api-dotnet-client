using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TransactionLine
    {
        ///<![CDATA[Reference to account]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of the Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of the Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Amount in the default currency of the company]]>
        public double AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double AmountFC { get; set; }

        ///<![CDATA[Vat base amount in the currency of the transaction]]>
        public double? AmountVATBaseFC { get; set; }

        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? AmountVATFC { get; set; }

        ///<![CDATA[Reference to asset]]>
        public Guid Asset { get; set; }

        ///<![CDATA[Code of Asset]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        ///<![CDATA[Description of Asset]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        ///<![CDATA[Reference to cost center]]>
        public string CostCenter { get; set; }

        ///<![CDATA[Description of CostCenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        ///<![CDATA[Reference to cost unit]]>
        public string CostUnit { get; set; }

        ///<![CDATA[Description of CostUnit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency]]>
        public string Currency { get; set; }

        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Reference to document]]>
        public Guid Document { get; set; }

        ///<![CDATA[Number of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        ///<![CDATA[Subject of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Date that payment should be done]]>
        public DateTime DueDate { get; set; }

        ///<![CDATA[Reference to header of the entry]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number of the header]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }

        ///<![CDATA[Extra duty amount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? ExtraDutyAmountFC { get; set; }

        ///<![CDATA[Extra duty percentage]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? ExtraDutyPercentage { get; set; }

        ///<![CDATA[Financial period]]>
        public Int16 FinancialPeriod { get; set; }

        ///<![CDATA[Financial year]]>
        public Int16 FinancialYear { get; set; }

        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Code of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }

        ///<![CDATA[Reference to item]]>
        public Guid Item { get; set; }

        ///<![CDATA[Code of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[The journal code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string JournalCode { get; set; }

        ///<![CDATA[The journal description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        ///<![CDATA[Line number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Line type]]>
        public Int16 LineType { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[OffsetID]]>
        public Guid OffsetID { get; set; }

        ///<![CDATA[Order number]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[Discount amount when paid in time]]>
        public double? PaymentDiscountAmount { get; set; }

        ///<![CDATA[Payment reference]]>
        public string PaymentReference { get; set; }

        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Code of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Serial number of item]]>
        public string SerialNumber { get; set; }

        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }

        ///<![CDATA[Description of Subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        ///<![CDATA[Tracking number of item]]>
        public string TrackingNumber { get; set; }

        ///<![CDATA[Tracking number description]]>
        public string TrackingNumberDescription { get; set; }

        ///<![CDATA[Vat code]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[Vat percentage]]>
        public double? VATPercentage { get; set; }

        ///<![CDATA[Vat type]]>
        public string VATType { get; set; }

        ///<![CDATA[Your reference (of customer)]]>
        public string YourRef { get; set; }
    }
}