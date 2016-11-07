using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentEndReason
    {
        ///<![CDATA[Employment end reason description]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }
    }
}