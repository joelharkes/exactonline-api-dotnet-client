using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ProjectId")]
    public class TimeAndBillingProject
    {
        ///<![CDATA[Code]]>
        public string ProjectCode { get; set; }

        ///<![CDATA[Description]]>
        public string ProjectDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ProjectId { get; set; }
    }
}