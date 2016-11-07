using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReopenedQuotation
    {
        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Contains the error message if an error occurred during the reopening of the quotation.]]>
        public string ErrorMessage { get; set; }

        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }

        ///<![CDATA[Contains information if the quotation was successfully reopened.]]>
        public string SuccessMessage { get; set; }
    }
}