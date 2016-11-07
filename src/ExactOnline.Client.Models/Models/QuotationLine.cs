using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class QuotationLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }

        ///<![CDATA[By default this contains the item description]]>
        public string Description { get; set; }

        ///<![CDATA[Discount given on the default price]]>
        public double? Discount { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to the item that is sold in this quotation line]]>
        public Guid Item { get; set; }

        ///<![CDATA[Description of the item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Indicates the sequence of the lines within one quotation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Net price of the quotation line]]>
        public double? NetPrice { get; set; }

        ///<![CDATA[Extra notes]]>
        public string Notes { get; set; }

        ///<![CDATA[The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Identifies the quotation. All the lines of a quotation have the same QuotationID]]>
        public Guid QuotationID { get; set; }

        ///<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 QuotationNumber { get; set; }

        ///<![CDATA[Code of the item unit]]>
        public string UnitCode { get; set; }

        ///<![CDATA[Description of the item unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        ///<![CDATA[Price per item unit]]>
        public double? UnitPrice { get; set; }

        ///<![CDATA[VAT amount of the line in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }

        ///<![CDATA[The VAT code that is used when the quotation is invoiced]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of the VAT code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }

        ///<![CDATA[The VAT percentage of the VAT code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }

        ///<![CDATA[Number indicating the different reviews which are made for the quotation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 VersionNumber { get; set; }
    }
}