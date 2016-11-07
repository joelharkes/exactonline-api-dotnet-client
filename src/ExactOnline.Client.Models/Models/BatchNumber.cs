using System;
using Newtonsoft.Json;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class BatchNumber
    {
        ///<![CDATA[Available quantity of this batch number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AvailableQuantity { get; set; }

        ///<![CDATA[Human readable batch number]]>
        [JsonProperty(PropertyName = "BatchNumber")]

        public string BatchNumber_1 { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Expiry date of effective period for batch number]]>
        public DateTime ExpiryDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Blocking state]]>
        public byte? IsBlocked { get; set; }

        ///<![CDATA[Item]]>
        public Guid Item { get; set; }

        ///<![CDATA[Item code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }
    }
}