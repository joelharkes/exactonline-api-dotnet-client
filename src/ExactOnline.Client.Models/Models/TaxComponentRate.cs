using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxComponentRate
    {
        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division]]>
        public Int32 Division { get; set; }

        ///<![CDATA[The date untill the rate for this component is valid]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime EndDate { get; set; }

        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }

        ///<![CDATA[The sequence in which the tax rates are ordered]]>
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

        ///<![CDATA[Rate]]>
        public double Rate { get; set; }

        ///<![CDATA[The date from which the rate is active]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Tax component to which this tax rate is linked]]>
        public Guid TaxComponent { get; set; }
    }
}