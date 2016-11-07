using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class TimeAndBillingRecentHourCostType
    {
        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }

        ///<![CDATA[Description of item]]>
        public string ItemDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ItemId { get; set; }
    }
}