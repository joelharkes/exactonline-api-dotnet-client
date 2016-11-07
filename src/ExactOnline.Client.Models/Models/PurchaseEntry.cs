using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class PurchaseEntry
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        ///<![CDATA[Batch number]]>
        public Int32 BatchNumber { get; set; }

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

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Reference to document]]>
        public Guid Document { get; set; }

        ///<![CDATA[Document number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        ///<![CDATA[Document subject]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Date when payment should be done]]>
        public DateTime DueDate { get; set; }

        ///<![CDATA[Entry date]]>
        public DateTime EntryDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Description of ExternalLink]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }

        public string ExternalLinkReference { get; set; }

        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }

        ///<![CDATA[Journal]]>
        public string Journal { get; set; }

        ///<![CDATA[Description of Journal]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Order number]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[Payment condition]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[Description of PaymentCondition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        public Int32 ProcessNumber { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<PurchaseEntryLine> PurchaseEntryLines { get; set; }

        ///<![CDATA[Currency exchange rate]]>
        public double? Rate { get; set; }

        ///<![CDATA[Reporting period]]>
        public Int16 ReportingPeriod { get; set; }

        ///<![CDATA[Reporting year]]>
        public Int16 ReportingYear { get; set; }

        ///<![CDATA[Indicates that amounts are reversed]]>
        public bool? Reversal { get; set; }

        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Reference to supplier (account)]]>
        public Guid Supplier { get; set; }

        ///<![CDATA[Name of supplier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }

        ///<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[Vat Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        ///<![CDATA[Vat Amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }

        ///<![CDATA[Your reference]]>
        public string YourRef { get; set; }
    }
}