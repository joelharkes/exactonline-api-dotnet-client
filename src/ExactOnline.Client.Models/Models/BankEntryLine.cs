using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("ID")]
    public class BankEntryLine
    {
        ///<![CDATA[Reference to Account]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Vat amount in the currency of the transaction]]>
        public double? AmountVATFC { get; set; }

        ///<![CDATA[Reference to an asset]]>
        public Guid Asset { get; set; }

        ///<![CDATA[Code of Asset]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        ///<![CDATA[Description of Asset]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetDescription { get; set; }

        ///<![CDATA[Reference to a cost center]]>
        public string CostCenter { get; set; }

        ///<![CDATA[Description of CostCenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostCenterDescription { get; set; }

        ///<![CDATA[Reference to a cost unit]]>
        public string CostUnit { get; set; }

        ///<![CDATA[Description of CostUnit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostUnitDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        public DateTime Date { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Reference to a document]]>
        public Guid Document { get; set; }

        ///<![CDATA[Number of Document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        ///<![CDATA[Subject of Document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Reference to the header]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number of the header]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }

        ///<![CDATA[General ledger account]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Code of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Primary key]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }

        ///<![CDATA[Line number]]>
        [SdkFieldType(FieldType.ReadOnly)]
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

        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Reference to offset line]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid OffsetID { get; set; }

        public Int32 OurRef { get; set; }

        ///<![CDATA[Reference to a project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Code of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Reference to vat code]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[Vat code percentage]]>
        public double? VATPercentage { get; set; }

        ///<![CDATA[Type of vat code]]>
        public string VATType { get; set; }
    }
}