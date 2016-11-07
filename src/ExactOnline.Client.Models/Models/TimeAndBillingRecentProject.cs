using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingRecentProject
    {
        ///<![CDATA[Date last used]]>
        public DateTime DateLastUsed { get; set; }

        ///<![CDATA[Code of project]]>
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of project]]>
        public string ProjectDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ProjectId { get; set; }
    }
}