using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class PurchaseEntryLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Reference to asset]]>
        public Guid Asset { get; set; }

        ///<![CDATA[Asset description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        ///<![CDATA[Reference to cost center]]>
        public string CostCenter { get; set; }

        ///<![CDATA[Description of CostCenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        ///<![CDATA[Reference to cost unit]]>
        public string CostUnit { get; set; }

        ///<![CDATA[Description of CostUnit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Reference to header of the purchase entry]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Code of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Line number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Serial number]]>
        public string SerialNumber { get; set; }

        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }

        ///<![CDATA[Description of Subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        ///<![CDATA[Reference to tracking number]]>
        public Guid TrackingNumber { get; set; }

        ///<![CDATA[Description of TrackingNumber]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }

        ///<![CDATA[Type: 30 = Purchase entry, 31 = Purchase credit note]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        ///<![CDATA[VAT amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        ///<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated.]]>
        public double? VATAmountFC { get; set; }

        ///<![CDATA[VAT base amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }

        ///<![CDATA[VAT base amount in the currency of the transaction]]>
        public double? VATBaseAmountFC { get; set; }

        ///<![CDATA[VAT code]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[VAT percentage]]>
        public double? VATPercentage { get; set; }

        ///<![CDATA[Withholding tax amount for spanish legislation]]>
        public double? WithholdingAmountDC { get; set; }

        ///<![CDATA[Withholding tax key for spanish legislation]]>
        public string WithholdingTax { get; set; }
    }
}