using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingActivitiesAndExpenses
    {
        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Description of Parent]]>
        public string ParentDescription { get; set; }
    }
}