using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ItemId")]
    public class HourCostType
    {
        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ItemId { get; set; }
    }
}