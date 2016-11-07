using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemVersion
    {
        ///<![CDATA[Batch Quantity of Item Version]]>
        public double? BatchQuantity { get; set; }

        ///<![CDATA[Calculated Cost Price of Item Version]]>
        public double? CalculatedCostPrice { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the item version]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if this is the default item version that will be assigned when a item is selected]]>
        public byte IsDefault { get; set; }

        ///<![CDATA[Reference to Items table]]>
        public Guid Item { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Lead time of Item version]]>
        public Int32 LeadTime { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Line notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active & 40-Historic]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe]]>
        public Int16 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[Version Number]]>
        public Int32 VersionNumber { get; set; }
    }
}