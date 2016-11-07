using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ItemWarehouse
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[This is a default storage location]]>
        public Guid DefaultStorageLocation { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Item ID]]>
        public Guid Item { get; set; }

        ///<![CDATA[Description of item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
        public bool? ItemIsFractionAllowedItem { get; set; }

        ///<![CDATA[The standard unit code of this item]]>
        public string ItemUnit { get; set; }

        ///<![CDATA[Description of item's unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemUnitDescription { get; set; }

        ///<![CDATA[Maximum number of stock could enter warehouse]]>
        public double? MaximumStock { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Reorder point when stock depletes]]>
        public double? ReorderPoint { get; set; }

        ///<![CDATA[Safety stock]]>
        public double? SafetyStock { get; set; }

        ///<![CDATA[Warehouse ID]]>
        public Guid Warehouse { get; set; }

        ///<![CDATA[Description of warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}