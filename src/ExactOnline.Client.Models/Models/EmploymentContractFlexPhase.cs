using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContractFlexPhase
    {
        ///<![CDATA[Flexible employment contract phase description]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }
    }
}