using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("OrderID")]
    public class SalesOrder
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountFC { get; set; }

        ///<![CDATA[Shows if this sales order is approved]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 ApprovalStatus { get; set; }

        ///<![CDATA[Description of ApprovalStatus]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ApprovalStatusDescription { get; set; }

        ///<![CDATA[Approval datetime]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Approved { get; set; }

        ///<![CDATA[User who approved the sales order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Approver { get; set; }

        ///<![CDATA[Name of approver]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ApproverFullName { get; set; }

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

        ///<![CDATA[Reference to delivery customer]]>
        public Guid DeliverTo { get; set; }

        ///<![CDATA[Reference to contact person of delivery customer]]>
        public Guid DeliverToContactPerson { get; set; }

        ///<![CDATA[Name of contact person of delivery customer]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliverToContactPersonFullName { get; set; }

        ///<![CDATA[Name of delivery customer]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliverToName { get; set; }

        ///<![CDATA[Delivery address]]>
        public Guid DeliveryAddress { get; set; }

        ///<![CDATA[Delivery date]]>
        public DateTime DeliveryDate { get; set; }

        ///<![CDATA[Shipping status]]>
        public Int16 DeliveryStatus { get; set; }

        ///<![CDATA[Description of DeliveryStatus]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryStatusDescription { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Document that is manually linked to the sales order]]>
        public Guid Document { get; set; }

        ///<![CDATA[Number of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        ///<![CDATA[Subject of the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Invoice status]]>
        public Int16 InvoiceStatus { get; set; }

        ///<![CDATA[Description of InvoiceStatus]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceStatusDescription { get; set; }

        ///<![CDATA[Reference to the Customer who will receive the invoice]]>
        public Guid InvoiceTo { get; set; }

        ///<![CDATA[Reference to the Contact person of the customer who will receive the invoice]]>
        public Guid InvoiceToContactPerson { get; set; }

        ///<![CDATA[Name of the contact person of the customer who will receive the invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceToContactPersonFullName { get; set; }

        ///<![CDATA[Name of the customer who will receive the invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceToName { get; set; }

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

        ///<![CDATA[Customer who ordered the sales order]]>
        public Guid OrderedBy { get; set; }

        ///<![CDATA[Contact person of the customer who ordered the sales order]]>
        public Guid OrderedByContactPerson { get; set; }

        ///<![CDATA[Name of contact person of the customer who ordered the sales order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderedByContactPersonFullName { get; set; }

        ///<![CDATA[Name of the customer who ordered the sales order]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderedByName { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid OrderID { get; set; }

        ///<![CDATA[Number of sales order]]>
        public Int32 OrderNumber { get; set; }

        ///<![CDATA[The payment condition used for due date and discount calculation]]>
        public string PaymentCondition { get; set; }

        ///<![CDATA[Description of PaymentCondition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        ///<![CDATA[Payment reference for sales order]]>
        public string PaymentReference { get; set; }

        ///<![CDATA[Extra remarks]]>
        public string Remarks { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }

        ///<![CDATA[Sales representative]]>
        public Guid Salesperson { get; set; }

        ///<![CDATA[Name of sales representative]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalespersonFullName { get; set; }

        ///<![CDATA[ShippingMethod]]>
        public Guid ShippingMethod { get; set; }

        ///<![CDATA[Description of ShippingMethod]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }

        ///<![CDATA[The status of the sales order. 12 = Open, 20 = Partial, 21 = Complete, 45 = Cancelled.]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }

        ///<![CDATA[Code of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        ///<![CDATA[Description of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        ///<![CDATA[Code of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        ///<![CDATA[Description of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }

        ///<![CDATA[Warehouse]]>
        public Guid WarehouseID { get; set; }

        ///<![CDATA[The reference number of the customer]]>
        public string YourRef { get; set; }
    }
}