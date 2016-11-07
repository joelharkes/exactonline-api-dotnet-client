using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesEntryLine
    {
        ///<![CDATA[Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[For normal lines it's the amount excluding VAT]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Reference to Asset]]>
        public Guid Asset { get; set; }

        ///<![CDATA[Description of Asset]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

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

        ///<![CDATA[Description. Can be different for header and lines]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.]]>
        public double? ExtraDutyAmountFC { get; set; }

        ///<![CDATA[Extra duty percentage for the item]]>
        public double? ExtraDutyPercentage { get; set; }

        ///<![CDATA[The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Code of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates the sequence of the lines within one entry]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }

        ///<![CDATA[The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used]]>
        public Guid Project { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Serial number]]>
        public string SerialNumber { get; set; }

        ///<![CDATA[When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines]]>
        public Guid Subscription { get; set; }

        ///<![CDATA[Description of Subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        ///<![CDATA[Reference to TrackingNumber]]>
        public Guid TrackingNumber { get; set; }

        ///<![CDATA[Description of TrackingNumber]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TrackingNumberDescription { get; set; }

        ///<![CDATA[Type: 20 = Sales entry, 21 = Sales credit note]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        ///<![CDATA[VAT amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountDC { get; set; }

        ///<![CDATA[VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. ]]>
        public double? VATAmountFC { get; set; }

        ///<![CDATA[The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC]]>
        public double? VATBaseAmountDC { get; set; }

        ///<![CDATA[The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It's an internal value]]>
        public double? VATBaseAmountFC { get; set; }

        ///<![CDATA[The VAT code used when the invoice was registered]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It's also used by the default calculation of VAT amounts and VAT base amounts]]>
        public double? VATPercentage { get; set; }
    }
}