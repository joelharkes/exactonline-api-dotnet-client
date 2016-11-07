using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SubscriptionLine
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        public double AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double AmountFC { get; set; }

        ///<![CDATA[Cost center]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Cost unit]]>
        public string Costunit { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Discount percentage]]>
        public double? Discount { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Entry ID]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[From date]]>
        public DateTime FromDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to Item]]>
        public Guid Item { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Line number]]>
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Reference to LineType]]>
        public Int16 LineType { get; set; }

        ///<![CDATA[Description of LineType]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string LineTypeDescription { get; set; }

        ///<![CDATA[Net price in the currency of the transaction]]>
        public double NetPrice { get; set; }

        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Quantity]]>
        public double Quantity { get; set; }

        ///<![CDATA[To date]]>
        public DateTime ToDate { get; set; }

        ///<![CDATA[Unit code]]>
        public string UnitCode { get; set; }

        ///<![CDATA[Description of Unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        ///<![CDATA[Unit price in the currency of the transaction (price * unit factor)]]>
        public double UnitPrice { get; set; }

        ///<![CDATA[Vat Amount in the currency of the transaction]]>
        public double? VATAmountFC { get; set; }

        ///<![CDATA[VATCode]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
    }
}