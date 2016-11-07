using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ProjectBudgetType
    {
        ///<![CDATA[Description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Int16 ID { get; set; }
    }
}