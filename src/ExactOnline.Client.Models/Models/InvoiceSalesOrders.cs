using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, false, false, false)]
    [DataServiceKey("ID")]
    public class InvoiceSalesOrders
    {
        ///<![CDATA[Invoice creation mode- 0: Per customer 1: Per sales order]]>
        public Int32 CreateMode { get; set; }

        ///<![CDATA[Stock entries entry number.]]>
        public Int32 DeliveryNumber { get; set; }

        ///<![CDATA[Stock entries entry end date.]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Errors in the process.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Errors { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.]]>
        public Int32 InvoiceMode { get; set; }

        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }

        ///<![CDATA[Number of invoices successfully created.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 NumberOfCreatedInvoices { get; set; }

        ///<![CDATA[Number of invoices failed to create.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 NumberOfFailedInvoices { get; set; }

        ///<![CDATA[Collection of Sales order IDs.]]>
        public IEnumerable<SalesOrderID> SalesOrderIDs { get; set; }

        ///<![CDATA[Stock entries entry start date.]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.]]>
        public DateTime UserInvoiceDate { get; set; }
    }
}