using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Asset
    {
        ///<![CDATA[Indicates if an asset was already depreciated before registering it in Exact Online]]>
        public byte AlreadyDepreciated { get; set; }

        ///<![CDATA[In case of a transfer or a split, the original asset ID is saved in this field. This is done to provide tracability of the Asset]]>
        public Guid AssetFrom { get; set; }

        ///<![CDATA[Description of AssetFrom]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetFromDescription { get; set; }

        ///<![CDATA[Asset group identifies GLAccounts to be used for Asset transactions]]>
        public Guid AssetGroup { get; set; }

        ///<![CDATA[Description of AssetGroup]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AssetGroupDescription { get; set; }

        ///<![CDATA[The catalogue value of the asset]]>
        public double? Cataloguevalue { get; set; }

        ///<![CDATA[This is the code of the asset]]>
        public string Code { get; set; }

        ///<![CDATA[Assets can be linked to a cost center]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Description of Costcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Assets can be linked to a cost unit]]>
        public string Costunit { get; set; }

        ///<![CDATA[Description of Costunit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Used for Belgium legislation. Used to produce the official 'Investment deduction' report]]>
        public double? DeductionPercentage { get; set; }

        ///<![CDATA[Amount that is already depreciated when adding an existing asset. Can only be filled when 'Alreadydepreciated' is on]]>
        public double? DepreciatedAmount { get; set; }

        ///<![CDATA[Number of periods that already have been depreciated for the asset. Can only be filled when 'Alreadydepreciated' is on]]>
        public Int32 DepreciatedPeriods { get; set; }

        ///<![CDATA[StartDate of depreciating. Can only be filled when 'Alreadydepreciated' is on]]>
        public DateTime DepreciatedStartDate { get; set; }

        ///<![CDATA[This is the description of the Asset]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Asset EndDate is filled when asset is Sold or Inactive]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Engine emission of the asset, needed to calculate the co² report]]>
        public Int16 EngineEmission { get; set; }

        ///<![CDATA[Engine type of the asset, Needed to generate a co² report]]>
        public Int16 EngineType { get; set; }

        ///<![CDATA[Links to the gltransactions.id. GL transaction line based on which the asset is created]]>
        public Guid GLTransactionLine { get; set; }

        ///<![CDATA[Description of GLTransactionLine]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLTransactionLineDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Supplier of the asset]]>
        public Guid InvestmentAccount { get; set; }

        ///<![CDATA[Code of InvestmentAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountCode { get; set; }

        ///<![CDATA[Name of InvestmentAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvestmentAccountName { get; set; }

        ///<![CDATA[Investment amount in the default currency of the company]]>
        public double? InvestmentAmountDC { get; set; }

        ///<![CDATA[Investment value of the asset. Currently the field is filled with the PurchasePriceLocal. Can be status 'Not used' after sources have been cleaned]]>
        public double? InvestmentAmountFC { get; set; }

        ///<![CDATA[Indicates the currency of the investment amount]]>
        public string InvestmentCurrency { get; set; }

        ///<![CDATA[Description of InvestmentCurrency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvestmentCurrencyDescription { get; set; }

        ///<![CDATA[Refers to the original date when the asset was bought]]>
        public DateTime InvestmentDate { get; set; }

        ///<![CDATA[Belgian functionality, to determine how a local legal report regarding investment deduction must be created]]>
        public Int16 InvestmentDeduction { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Extra remarks for the asset]]>
        public string Notes { get; set; }

        ///<![CDATA[Parent asset]]>
        public Guid Parent { get; set; }

        ///<![CDATA[Code of Parent]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ParentCode { get; set; }

        ///<![CDATA[Description of Parent]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ParentDescription { get; set; }

        ///<![CDATA[Image for an asset]]>
        public byte[] Picture { get; set; }

        ///<![CDATA[Filename of the image]]>
        public string PictureFileName { get; set; }

        ///<![CDATA[First method of depreciation. Currently, it is the only one used]]>
        public Guid PrimaryMethod { get; set; }

        ///<![CDATA[Code of PrimaryMethod]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodCode { get; set; }

        ///<![CDATA[Description of PrimaryMethod]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PrimaryMethodDescription { get; set; }

        ///<![CDATA[Indicates the residual value of the asset at the end of the depreciation]]>
        public double? Residualvalue { get; set; }

        ///<![CDATA[Asset Depreciation StartDate]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Identifies the status of the Asset. (see AssetStatus table to see the possibilities)]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Reference to Transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid TransactionEntryID { get; set; }

        ///<![CDATA[Entry number of transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 TransactionEntryNo { get; set; }
    }
}