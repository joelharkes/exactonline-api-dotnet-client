using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("ID")]
    public class StockCountLine
    {
        ///<![CDATA[The collection of batch numbers that belong to the items included in this stock count]]>
        public IEnumerable<StockBatchNumber> BatchNumbers { get; set; }

        ///<![CDATA[Cost price of the item that is used to create the stock count]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? CostPrice { get; set; }

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

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to the item for which the stock is counted]]>
        public Guid Item { get; set; }

        ///<![CDATA[Item code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Current standard/actual item cost price]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? ItemCostPrice { get; set; }

        ///<![CDATA[Description of item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Indicates if fractional quantities of the item can be used, for example quantity = 0.4]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? ItemDivisable { get; set; }

        ///<![CDATA[Line number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Shows quantity difference between current and new stock]]>
        public double? QuantityDifference { get; set; }

        ///<![CDATA[Shows current quantity available in stock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? QuantityInStock { get; set; }

        ///<![CDATA[Shows new amended quantity in stock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? QuantityNew { get; set; }

        ///<![CDATA[The collection of serial numbers that belong to the items included in this stock count]]>
        public IEnumerable<StockSerialNumber> SerialNumbers { get; set; }

        ///<![CDATA[Identifies the stock count. All the lines of a stock count have the same StockCountID]]>
        public Guid StockCountID { get; set; }

        ///<![CDATA[Stock item's unit description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StockKeepingUnit { get; set; }

        ///<![CDATA[Storage location]]>
        public Guid StorageLocation { get; set; }

        ///<![CDATA[Storage location code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }

        ///<![CDATA[Storage location description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
    }
}