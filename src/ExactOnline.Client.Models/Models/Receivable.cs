using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("HID")]
    public class Receivable
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }

        ///<![CDATA[Reference to the account]]>
        public Guid AccountId { get; set; }

        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Amount]]>
        public double Amount { get; set; }

        ///<![CDATA[Amount in transit]]>
        public double AmountInTransit { get; set; }

        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Date the invoice should be paid]]>
        public DateTime DueDate { get; set; }

        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Primary key, human readable ID]]>
        public Int64 HID { get; set; }

        ///<![CDATA[Obsolete]]>
        public Guid Id { get; set; }

        ///<![CDATA[Invoice date]]>
        public DateTime InvoiceDate { get; set; }

        ///<![CDATA[Invoice number]]>
        public Int32 InvoiceNumber { get; set; }

        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }

        ///<![CDATA[Description of Journal]]>
        public string JournalDescription { get; set; }

        ///<![CDATA[Your reference]]>
        public string YourRef { get; set; }
    }
}