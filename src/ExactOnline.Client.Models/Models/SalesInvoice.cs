using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("InvoiceID")]
    public class SalesInvoice
    {
        ///<![CDATA[For the header lines (LineNumber = 0) of an entry this is the SUM(AmountDC) of all lines]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[For the header this is the sum of all lines, including VAT]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency for the invoice. Default this is the currency of the administration]]>
        public string Currency { get; set; }

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

        ///<![CDATA[Official date for the invoice. When the invoice is entered it's equal to the field 'EntryDate'. During the printing process the invoice date can be entered]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime InvoiceDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid InvoiceID { get; set; }

        ///<![CDATA[Assigned at entry or at printing depending on setting. The number assigned is based on the freenumbers as defined for the Journal. When printing the field InvoiceNumber is copied to the fields EntryNumber and InvoiceNumber of the sales entry]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 InvoiceNumber { get; set; }

        ///<![CDATA[Reference to the Customer who will receive the invoice]]>
        public Guid InvoiceTo { get; set; }

        ///<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
        public Guid InvoiceToContactPerson { get; set; }

        ///<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }

        ///<![CDATA[Name of the customer who will receive the invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }

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

        ///<![CDATA[Order date]]>
        public DateTime OrderDate { get; set; }

        ///<![CDATA[Customer who ordered the invoice]]>
        public Guid OrderedBy { get; set; }

        ///<![CDATA[Contact person of customer who ordered the invoice]]>
        public Guid OrderedByContactPerson { get; set; }

        ///<![CDATA[Name of contact person of customer who ordered the invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }

        ///<![CDATA[Name of customer who ordered the invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }

        ///<![CDATA[Number to identify the order. By default the number is based on a setting for the first free number, but you can post your own number.]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[The payment condition used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[Description of PaymentCondition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        ///<![CDATA[Payment reference for sales invoice]]>
        public string PaymentReference { get; set; }

        ///<![CDATA[Extra remarks]]>
        public string Remarks { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<SalesInvoiceLine> SalesInvoiceLines { get; set; }

        ///<![CDATA[Sales representative]]>
        public Guid Salesperson { get; set; }

        ///<![CDATA[Name of sales representative]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }

        ///<![CDATA[Starter Sales invoice status (for starter functionality)]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 StarterSalesInvoiceStatus { get; set; }

        ///<![CDATA[Description of StarterSalesInvoiceStatus]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StarterSalesInvoiceStatusDescription { get; set; }

        ///<![CDATA[The status of the entry. 10 = draft. During the creation of an invoice draft records occur in the draft modus if during an invoice a new page with lines is triggered. If the user leaves the invoice in an abnormal way the draft invoices can be recovered. Draft invoices are not included in financial reports, balances etc. 20 = open. Open invoices can be changed. New invoices get the status open by default. 50 = processed. Processed invoices can't be changed anymore. Processing is done via printing. Processed invoices can't be reopened]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }

        ///<![CDATA[Code of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        ///<![CDATA[Description of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        ///<![CDATA[Indicates the type of invoice values: 8020 - Sales invoices, 8021 - Sales credit note]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Description of the type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[Total VAT amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        ///<![CDATA[Total VAT amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }

        ///<![CDATA[The invoice number of the customer]]>
        public string YourRef { get; set; }
    }
}