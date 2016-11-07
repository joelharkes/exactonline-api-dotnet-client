using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class StorageLocation
    {
        ///<![CDATA[Code of the storage location]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the storage location]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if this is the main storage location. There's always exactly one main storage location per warehouse]]>
        public byte? Main { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Warehouse ID]]>
        public Guid Warehouse { get; set; }

        ///<![CDATA[Warehouse Code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        ///<![CDATA[Description of warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}