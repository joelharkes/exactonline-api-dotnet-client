using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, false)]
    [DataServiceKey("ID")]
    public class GoodsDeliveryLine
    {
        ///<![CDATA[Collection of batch numbers]]>
        public IEnumerable<StockBatchNumber> BatchNumbers { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Date of goods delivery]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime DeliveryDate { get; set; }

        ///<![CDATA[Description of sales order delivery]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[The EntryID identifies the goods delivery. All the lines of a goods delivery have the same EntryID]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Item { get; set; }

        ///<![CDATA[Item code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

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

        ///<![CDATA[Notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Quantity delivered]]>
        public double? QuantityDelivered { get; set; }

        ///<![CDATA[Quantity ordered]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? QuantityOrdered { get; set; }

        ///<![CDATA[Reference to sales order]]>
        public Guid SalesOrderLineID { get; set; }

        ///<![CDATA[Sales order line number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineNumber { get; set; }

        ///<![CDATA[Sales order number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }

        ///<![CDATA[Collection of serial numbers]]>
        public IEnumerable<StockSerialNumber> SerialNumbers { get; set; }

        ///<![CDATA[Reference to storage location for warehouse]]>
        public Guid StorageLocation { get; set; }

        ///<![CDATA[Reference to tracking number]]>
        public string TrackingNumber { get; set; }

        ///<![CDATA[Code of item unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Unitcode { get; set; }
    }
}