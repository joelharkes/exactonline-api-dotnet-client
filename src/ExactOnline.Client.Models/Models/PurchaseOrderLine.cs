using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PurchaseOrderLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        ///<![CDATA[Reference to Cost center]]>
        public string CostCenter { get; set; }

        ///<![CDATA[Description of CostCenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        ///<![CDATA[Reference to Cost unit]]>
        public string CostUnit { get; set; }

        ///<![CDATA[Description of CostUnit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of sales order delivery]]>
        public string Description { get; set; }

        ///<![CDATA[Discount in percentage for item]]>
        public double? Discount { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[The current stock level of items shown in stock unit. The information is displayed only for items with the stock property selected.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? InStock { get; set; }

        ///<![CDATA[Quantity of item that has been invoiced]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? InvoicedQuantity { get; set; }

        ///<![CDATA[Reference to the item for purchase order]]>
        public Guid Item { get; set; }

        ///<![CDATA[Item code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

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

        ///<![CDATA[The net price is the unit price (VAT code taken into account) with any discount applied]]>
        public double? NetPrice { get; set; }

        ///<![CDATA[Notes]]>
        public string Notes { get; set; }

        ///<![CDATA[The current stock level + the planned quantity to be received - the planned quantity to deliver shown in stock unit.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? ProjectedStock { get; set; }

        ///<![CDATA[Identifies the purchase order. All the lines of a purchase order have the same PurchaseOrderID]]>
        public Guid PurchaseOrderID { get; set; }

        ///<![CDATA[Quantity for the item that needs to be invoiced]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Date the goods are expected to be received]]>
        public DateTime ReceiptDate { get; set; }

        ///<![CDATA[Quantity of goods received]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? ReceivedQuantity { get; set; }

        ///<![CDATA[Sales order that is linked to a back to back sales order in purchase order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }

        ///<![CDATA[Number of sales order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }

        ///<![CDATA[Code the supplier uses for this item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SupplierItemCode { get; set; }

        ///<![CDATA[Code of item unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }

        ///<![CDATA[Description of unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        ///<![CDATA[Item price per unit]]>
        public double? UnitPrice { get; set; }

        ///<![CDATA[Amount of VAT charges calculated from total amount and vat percentage]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmount { get; set; }

        ///<![CDATA[The VAT code used when the invoice was registered]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of vat code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }

        ///<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }
}