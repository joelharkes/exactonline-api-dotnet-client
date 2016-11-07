using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesOrderLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Reference to Cost center]]>
        public string CostCenter { get; set; }

        ///<![CDATA[Description of CostCenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        ///<![CDATA[Item cost price]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? CostPriceFC { get; set; }

        ///<![CDATA[Reference to Cost unit]]>
        public string CostUnit { get; set; }

        ///<![CDATA[Description of CostUnit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        ///<![CDATA[Delivery date of this line]]>
        public DateTime DeliveryDate { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
        public double? Discount { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to the item that is sold in this sales order line]]>
        public Guid Item { get; set; }

        ///<![CDATA[Code of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Item Version]]>
        public Guid ItemVersion { get; set; }

        ///<![CDATA[Description of Item Version]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }

        ///<![CDATA[Line number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Sales margin of the sales order line]]>
        public double? Margin { get; set; }

        ///<![CDATA[Net price of the sales order line]]>
        public double? NetPrice { get; set; }

        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }

        ///<![CDATA[The OrderID identifies the sales order. All the lines of a sales order have the same OrderID]]>
        public Guid OrderID { get; set; }

        ///<![CDATA[Number of sales order]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[Price list]]>
        public Guid Pricelist { get; set; }

        ///<![CDATA[Description of Pricelist]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }

        ///<![CDATA[The project to which the sales order line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
        public Guid Project { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }

        ///<![CDATA[The number of items delivered]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? QuantityDelivered { get; set; }

        ///<![CDATA[The number of items invoiced]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? QuantityInvoiced { get; set; }

        ///<![CDATA[Reference to ShopOrder]]>
        public Guid ShopOrder { get; set; }

        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }

        ///<![CDATA[Code of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        ///<![CDATA[Description of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        ///<![CDATA[Code of item unit]]>
        public string UnitCode { get; set; }

        ///<![CDATA[Description of Unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        ///<![CDATA[Price per unit in the currency of the transaction]]>
        public double? UnitPrice { get; set; }

        ///<![CDATA[Indicates if drop shipment is used (delivery directly to customer, invoice to wholesaler)]]>
        public byte UseDropShipment { get; set; }

        ///<![CDATA[VAT amount in the currency of the transaction]]>
        public double? VATAmount { get; set; }

        ///<![CDATA[VAT code]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the sales order is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }
}