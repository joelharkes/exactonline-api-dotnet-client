using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class TimeAndBillingRecentAccount
    {
        ///<![CDATA[Primary key]]>
        public Guid AccountId { get; set; }

        ///<![CDATA[Name of account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }
    }
}