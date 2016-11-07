using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectTerm
    {
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[WBS's deliverable linked to invoice term]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Deliverable { get; set; }

        ///<![CDATA[Description of invoice term]]>
        public string Description { get; set; }

        ///<![CDATA[Division number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Invoice date]]>
        public DateTime InvoiceDate { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Percentage of amount per project's budgeted amount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }

        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Description of project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Reference to VATCode]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[VATCode percentage]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATPercentage { get; set; }
    }
}