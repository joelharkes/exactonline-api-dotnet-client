using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingProjectDetails
    {
        ///<![CDATA[The account for this project]]>
        public Guid Account { get; set; }

        public string AccountName { get; set; }

        ///<![CDATA[Code of project]]>
        public string Code { get; set; }

        ///<![CDATA[Description of the project]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to ProjectTypes]]>
        public Int32 Type { get; set; }
    }
}