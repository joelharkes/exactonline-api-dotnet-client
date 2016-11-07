using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("StockCountID")]
    public class StockCount
    {
        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the stock count]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Entry number of the stock transactions]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Offset GL account of inventory]]>
        public Guid OffsetGLInventory { get; set; }

        ///<![CDATA[GLAccount code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OffsetGLInventoryCode { get; set; }

        ///<![CDATA[GLAccount description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OffsetGLInventoryDescription { get; set; }

        ///<![CDATA[Source of stock count entry: 1-Manual entry, 2-Import, 3-Stock count, 4-Web service]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Source { get; set; }

        ///<![CDATA[Stock count status: 12-Draft, 21-Processed]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Stock count date]]>
        public DateTime StockCountDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid StockCountID { get; set; }

        ///<![CDATA[Collection of stock count lines]]>
        public IEnumerable<StockCountLine> StockCountLines { get; set; }

        ///<![CDATA[Human readable id of the stock count]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 StockCountNumber { get; set; }

        ///<![CDATA[Warehouse]]>
        public Guid Warehouse { get; set; }

        ///<![CDATA[Code of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        ///<![CDATA[Description of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}