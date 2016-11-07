using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesInvoiceLine
    {
        ///<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[For normal lines it's the amount excluding VAT]]>
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

        ///<![CDATA[Delivery date of an item in a sales invoice. This is used for VAT on prepayments, only if sales order is not used in the license.]]>
        public DateTime DeliveryDate { get; set; }

        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }

        ///<![CDATA[Discount given on the default price. Discount = (DefaultPrice of Item - PriceItem in line) / DefaultPrice of Item]]>
        public double? Discount { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Link to Employee originating from time and cost transactions]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Name of employee]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }

        ///<![CDATA[EndTime is used to store the last date of a period. EndTime is used in combination with StartTime]]>
        public DateTime EndTime { get; set; }

        ///<![CDATA[The GL Account of the sales invoice line. This field is mandatory. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[The InvoiceID identifies the sales invoice. All the lines of a sales invoice have the same InvoiceID]]>
        public Guid InvoiceID { get; set; }

        ///<![CDATA[Reference to the item that is sold in this sales invoice line]]>
        public Guid Item { get; set; }

        ///<![CDATA[Item code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Indicates the sequence of the lines within one invoice]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Net price of the sales invoice line]]>
        public double? NetPrice { get; set; }

        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Price list]]>
        public Guid Pricelist { get; set; }

        ///<![CDATA[Description of Pricelist]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PricelistDescription { get; set; }

        ///<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
        public Guid Project { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Identifies the sales order this invoice line is based on]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SalesOrder { get; set; }

        ///<![CDATA[Identifies the sales order line this sales invoice line is based on]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SalesOrderLine { get; set; }

        ///<![CDATA[Then line number of the sales order line on which this invoice line is based on]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderLineNumber { get; set; }

        ///<![CDATA[The order number of the sales order on which this invoice line is based on]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SalesOrderNumber { get; set; }

        ///<![CDATA[StartTime is used to store the first date of a period. StartTime is used in combination with EndTime]]>
        public DateTime StartTime { get; set; }

        ///<![CDATA[Obsolete. When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
        public Guid Subscription { get; set; }

        ///<![CDATA[Description of Subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        ///<![CDATA[Tax schedule linked]]>
        public Guid TaxSchedule { get; set; }

        ///<![CDATA[Code of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleCode { get; set; }

        ///<![CDATA[Description of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxScheduleDescription { get; set; }

        ///<![CDATA[Code of Unit]]>
        public string UnitCode { get; set; }

        ///<![CDATA[Description of Unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        ///<![CDATA[Price per unit]]>
        public double? UnitPrice { get; set; }

        ///<![CDATA[VAT amount in the default currency of the company]]>
        public double? VATAmountDC { get; set; }

        ///<![CDATA[VAT amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }

        ///<![CDATA[The VAT code that is used when the invoice is registered]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[The vat percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used for the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }
}