using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class ReviewedQuotation
    {
        ///<![CDATA[Indicates if the item prices should be copied from the original quotation or the default item prices should be used.]]>
        public bool? CopyItemPrices { get; set; }

        ///<![CDATA[The description of the new quotation.]]>
        public string Description { get; set; }

        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }

        ///<![CDATA[The document linked to the new quotation.]]>
        public Guid Document { get; set; }

        ///<![CDATA[Contains the error message if an error occurred during the reviewing of the quotation.]]>
        public string ErrorMessage { get; set; }

        ///<![CDATA[Identifier of the newly created quotation.]]>
        public Guid NewQuotationID { get; set; }

        ///<![CDATA[The account who made the order.]]>
        public Guid OrderAccount { get; set; }

        ///<![CDATA[The contact person of the account who made the order.]]>
        public Guid OrderAccountContact { get; set; }

        ///<![CDATA[The paymentcondition linked to the new quotation.]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[The date of the new quotation.]]>
        public DateTime QuotationDate { get; set; }

        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }

        ///<![CDATA[Contains information if the quotation was successfully reviewed.]]>
        public string SuccessMessage { get; set; }
    }
}