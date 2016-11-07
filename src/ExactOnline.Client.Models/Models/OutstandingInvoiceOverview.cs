namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("CurrencyCode")]
    public class OutstandingInvoiceOverview
    {
        ///<![CDATA[Primary key]]>
        public string CurrencyCode { get; set; }

        ///<![CDATA[Total invoice amount to be paid]]>
        public double OutstandingPayableInvoiceAmount { get; set; }

        ///<![CDATA[Number of invoices to be paid]]>
        public double OutstandingPayableInvoiceCount { get; set; }

        ///<![CDATA[Total invoice amount to be received]]>
        public double OutstandingReceivableInvoiceAmount { get; set; }

        ///<![CDATA[Number of invoices to be received]]>
        public double OutstandingReceivableInvoiceCount { get; set; }

        ///<![CDATA[Total payable invoice amount that is overdue]]>
        public double OverduePayableInvoiceAmount { get; set; }

        ///<![CDATA[Number of payable invoices that are overdue]]>
        public double OverduePayableInvoiceCount { get; set; }

        ///<![CDATA[Total receivable invoice amount that is overdue]]>
        public double OverdueReceivableInvoiceAmount { get; set; }

        ///<![CDATA[Number of receivable invoices that are overdue]]>
        public double OverdueReceivableInvoiceCount { get; set; }
    }
}