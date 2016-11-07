using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, false, false, false)]
    [DataServiceKey("OrderId")]
    public class PrintedSalesOrder
    {
        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Contains the id of the document that was created]]>
        public Guid Document { get; set; }

        ///<![CDATA[Contains the error message if an error occurred during the creation of the document]]>
        public string DocumentCreationError { get; set; }

        ///<![CDATA[Contains information if a document was succesfully created]]>
        public string DocumentCreationSuccess { get; set; }

        ///<![CDATA[Based on this layout a PDF is created and attached to an Exact Online document and an email]]>
        public Guid DocumentLayout { get; set; }

        ///<![CDATA[Contains the error message if an error occurred during the creation of the email]]>
        public string EmailCreationError { get; set; }

        ///<![CDATA[Contains confirmation that an email was sent. If an email cannot be delivered this property will still show confirmation that the email was sent.]]>
        public string EmailCreationSuccess { get; set; }

        ///<![CDATA[Based on this layout the email text is produced]]>
        public Guid EmailLayout { get; set; }

        ///<![CDATA[Extra text that can be added to the printed document and email]]>
        public string ExtraText { get; set; }

        ///<![CDATA[Primary key, Reference to OrderID of SalesOrder]]>
        public Guid OrderId { get; set; }

        ///<![CDATA[Set to True if an email containing the sales order should be sent to the customer]]>
        public bool? SendEmailToCustomer { get; set; }

        ///<![CDATA[Email address from which the email will be sent. If not specified, the company email address will be used.]]>
        public string SenderEmailAddress { get; set; }
    }
}