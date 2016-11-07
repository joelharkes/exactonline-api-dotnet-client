using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ExchangeRate
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

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY]]>
        public double? Rate { get; set; }

        ///<![CDATA[The foreign currency]]>
        public string SourceCurrency { get; set; }

        ///<![CDATA[Description of SourceCurrency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SourceCurrencyDescription { get; set; }

        ///<![CDATA[The date as of which the rate is valid. The rate is valid until a next rate is defined]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[The default currency of the division]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TargetCurrency { get; set; }

        ///<![CDATA[Description of TargetCurrency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TargetCurrencyDescription { get; set; }
    }
}