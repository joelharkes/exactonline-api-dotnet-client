using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("EntryID")]
    public class SalesEntry
    {
        ///<![CDATA[Amount in the default currency of the company. For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction. For the header this is the sum of all lines, including VAT]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        ///<![CDATA[The number of the batch of entries. Normally a batch consists of multiple entries. Batchnumbers are filled for invoices created by: - Fixed entries - Prolongation (only available with module hosting)]]>
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

        ///<![CDATA[Currency for the invoice. By default this is the currency of the administration]]>
        public string Currency { get; set; }

        ///<![CDATA[Reference to customer (account)]]>
        public Guid Customer { get; set; }

        ///<![CDATA[Name of customer]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }

        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Document that is manually linked to the invoice]]>
        public Guid Document { get; set; }

        ///<![CDATA[Number of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        ///<![CDATA[Subject of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[The due date for payments. This date is calculated based on the EntryDate and the Paymentcondition]]>
        public DateTime DueDate { get; set; }

        ///<![CDATA[The date when the invoice is entered]]>
        public DateTime EntryDate { get; set; }

        ///<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Description of ExternalLink]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ExternalLinkDescription { get; set; }

        ///<![CDATA[Reference of ExternalLink]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ExternalLinkReference { get; set; }

        ///<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
        public Int32 InvoiceNumber { get; set; }

        ///<![CDATA[Indicates whether the invoice has extra duty]]>
        public bool? IsExtraDuty { get; set; }

        ///<![CDATA[The journal code. Every invoice should be linked to a sales journal]]>
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

        ///<![CDATA[Number to indentify the invoice. Order numbers are not unique. Default the number is based on a setting for the first free number]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[The payment condition used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[Description of PaymentCondition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        ///<![CDATA[The payment reference used for bank imports, VAT return and Tax reference]]>
        public string PaymentReference { get; set; }

        public Int32 ProcessNumber { get; set; }

        ///<![CDATA[Foreign currency rate]]>
        public double? Rate { get; set; }

        ///<![CDATA[The period of the transaction lines. The period should exist in the period date table]]>
        public Int16 ReportingPeriod { get; set; }

        ///<![CDATA[The financial year to which the entry belongs. The financial year should exist in the period date table]]>
        public Int16 ReportingYear { get; set; }

        ///<![CDATA[Indicates if amounts are reversed]]>
        public bool? Reversal { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<SalesEntryLine> SalesEntryLines { get; set; }

        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[Vat amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }

        ///<![CDATA[The invoice number of the customer]]>
        public string YourRef { get; set; }
    }
}