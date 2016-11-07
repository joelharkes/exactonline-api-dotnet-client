using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("PurchaseOrderID")]
    public class PurchaseOrder
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

        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }

        ///<![CDATA[Reference to account for delivery]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid DeliveryAccount { get; set; }

        ///<![CDATA[Delivery account code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }

        ///<![CDATA[Account name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }

        ///<![CDATA[Reference to shipping address]]>
        public Guid DeliveryAddress { get; set; }

        ///<![CDATA[Reference to contact for delivery]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid DeliveryContact { get; set; }

        ///<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }

        ///<![CDATA[Description of the purchase order]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Document that is manually linked to the purchase order]]>
        public Guid Document { get; set; }

        ///<![CDATA[Subject of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Shows if it is a drop shipment purchase order]]>
        public bool? DropShipment { get; set; }

        ///<![CDATA[Allows you to set the currency for the invoice. You can only do this if you have checked the Variable: Currency and Variable: Exchange rate fields in the sales journal settings. Once a line has been created in the invoice, the currency can no longer be changed.]]>
        public double? ExchangeRate { get; set; }

        ///<![CDATA[Invoice status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 InvoiceStatus { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Order date]]>
        public DateTime OrderDate { get; set; }

        ///<![CDATA[Human readable id of the purchase order]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[Purchase order status: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 OrderStatus { get; set; }

        ///<![CDATA[The payment condition code used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[Description of payment condition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid PurchaseOrderID { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<PurchaseOrderLine> PurchaseOrderLines { get; set; }

        ///<![CDATA[This field shows the date the goods are expected to be received.]]>
        public DateTime ReceiptDate { get; set; }

        ///<![CDATA[Receipt status of purchase order: 10-Open, 20-Partial, 30-Complete, 40-Canceled]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 ReceiptStatus { get; set; }

        ///<![CDATA[Include any relevant remarks regarding the purchase order.]]>
        public string Remarks { get; set; }

        ///<![CDATA[Reference to sales order when purchase order generated via back to back sales order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }

        ///<![CDATA[Number of sales order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }

        ///<![CDATA[This shows how the purchase order was created: 1-Manual entry, 2-Import, 3-Other, 4-Purchase order, 5-Sales order, 6-Supplier's items, 7-Subcontract, 8-Purchase order advice, 9-Shop order, 10-MRP calculation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Source { get; set; }

        ///<![CDATA[Reference to supplier account]]>
        public Guid Supplier { get; set; }

        ///<![CDATA[Code of supplier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }

        ///<![CDATA[Contact of supplier]]>
        public Guid SupplierContact { get; set; }

        ///<![CDATA[Contact person full name of supplier]]>
        public string SupplierContactPersonFullName { get; set; }

        ///<![CDATA[Name of supplier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }

        ///<![CDATA[Warehouse]]>
        public Guid Warehouse { get; set; }

        ///<![CDATA[Code of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        ///<![CDATA[Description of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }

        ///<![CDATA[Shows the reference number associated with the purchase order. Enter a description and reference to make the purchase order easier to identify.]]>
        public string YourRef { get; set; }
    }
}