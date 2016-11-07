using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingAccountDetails
    {
        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Name]]>
        public string Name { get; set; }
    }
}