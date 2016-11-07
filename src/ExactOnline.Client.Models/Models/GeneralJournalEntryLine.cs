using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GeneralJournalEntryLine
    {
        ///<![CDATA[Reference to account]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Amount in the default currency of the company, If an 'Including' VAT code is used this amount includes the VAT amount.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction. If an 'Including' VAT code is used this amount includes the VAT amount.]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Vat amount in the default currency of the company.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? AmountVATDC { get; set; }

        ///<![CDATA[Vat amount in the currency of the transaction. If you want to set this in a POST you have to specify VATCode as well.]]>
        public double? AmountVATFC { get; set; }

        ///<![CDATA[Reference to asset]]>
        public Guid Asset { get; set; }

        ///<![CDATA[Code of Asset]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetCode { get; set; }

        ///<![CDATA[Description of Asset]]>
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

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Entry date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Reference to document]]>
        public Guid Document { get; set; }

        ///<![CDATA[Document number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DocumentNumber { get; set; }

        ///<![CDATA[Document subject]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Reference to header of the entry]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number of the header]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

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

        public Guid OffsetID { get; set; }

        ///<![CDATA[Our ref of general journal entry]]>
        public Int32 OurRef { get; set; }

        ///<![CDATA[Reference to project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Code of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }

        ///<![CDATA[VAT base amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountDC { get; set; }

        ///<![CDATA[VAT base amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATBaseAmountFC { get; set; }

        ///<![CDATA[VATCode can only be used if the general journal has VAT enabled. VAT Lines will be automatically created if the VATCode is specified when creating a new general journal entry.]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }

        ///<![CDATA[Vat percentage]]>
        public double? VATPercentage { get; set; }

        ///<![CDATA[The VAT type determines what the values are in relation to VAT returns. The following values are supported:<br>A Sales VAT to pay,<br>D Credit note extra duty to claim,<br>I Purchase basis,<br>M Credit note purchase non-deductible,<br>N Purchase non-deductible,<br>O Purchase VAT to claim,<br>P Purchase VAT to pay,<br>Q Credit note purchase VAT to claim,<br>R Extra duty to pay,<br>S No VAT,<br>V Sales basis,<br>W Credit note purchase basis,<br>X Credit note sales basis,<br>Y Credit note purchase VAT to pay,<br>Z Credit note sales VAT to claim]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATType { get; set; }
    }
}