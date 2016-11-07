using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingItemDetails
    {
        ///<![CDATA[Item code]]>
        public string Code { get; set; }

        ///<![CDATA[Description of the item code]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if fractions are allowed for quantities of this item]]>
        public bool IsFractionAllowedItem { get; set; }

        ///<![CDATA[Indicates if the item can be sold]]>
        public bool IsSalesItem { get; set; }

        ///<![CDATA[Sales currency code]]>
        public string SalesCurrency { get; set; }

        ///<![CDATA[Sales price]]>
        public double SalesPrice { get; set; }
    }
}