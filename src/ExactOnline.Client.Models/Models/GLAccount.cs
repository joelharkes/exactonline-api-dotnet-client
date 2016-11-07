using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class GLAccount
    {
        ///<![CDATA[AssimilatedVATBox (France)]]>
        public Int16 AssimilatedVATBox { get; set; }

        ///<![CDATA[The following values are supported: D (Debit) C (Credit)]]>
        public string BalanceSide { get; set; }

        ///<![CDATA[The following values are supported: B (Balance Sheet) W (Profit & Loss)]]>
        public string BalanceType { get; set; }

        ///<![CDATA[Indentify the kind of rewarding for the GL account. This is used in the official document for the fiscal fiches Belcotax]]>
        public Int32 BelcotaxType { get; set; }

        ///<![CDATA[Unique Code of the G/L Account]]>
        public string Code { get; set; }

        ///<![CDATA[Indicate if this GL account should be shown as compressed without the details in the CRW report of GL history]]>
        public bool? Compress { get; set; }

        ///<![CDATA[Cost Center linked to the G/L Account]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Description of Costcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Cost Unit linked to the G/L Account]]>
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

        ///<![CDATA[Name of the G/L Account]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[GLTransactions on this GLAccount should not appear on the VAT listing]]>
        public byte ExcludeVATListing { get; set; }

        ///<![CDATA[Expenses on this GLAccount can not be used to reduce the incomes]]>
        public double? ExpenseNonDeductiblePercentage { get; set; }

        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }

        ///<![CDATA[When blocked you can't use this general ledger account anymore for new entries]]>
        public bool? IsBlocked { get; set; }

        ///<![CDATA[Allow entries on this general ledger account to be matched via the GL Account card]]>
        public bool? Matching { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[If a private use percentage is defined, you need to specify the GL used for the re-invoice of the private use to the owner of the company]]>
        public Guid PrivateGLAccount { get; set; }

        ///<![CDATA[Specify the percentage of the cost that should be re-invoiced to the owner of the company as private use of the costs]]>
        public double? PrivatePercentage { get; set; }

        ///<![CDATA[Used in the export of yearly report]]>
        public string ReportingCode { get; set; }

        ///<![CDATA[Indicates if the amounts booked on this general ledger account will be recalculated when currency revaluation is done]]>
        public bool? RevalueCurrency { get; set; }

        ///<![CDATA[Search Code]]>
        public string SearchCode { get; set; }

        ///<![CDATA[Type of G/L Account (for example, 110 = Revenue)]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[Indicates if cost centers can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
        public byte? UseCostcenter { get; set; }

        ///<![CDATA[Indicates if cost units can be used when using this general ledger account. The following values are supported: 0 (Optional) 1 (Mandatory) 2 (No)]]>
        public byte? UseCostunit { get; set; }

        ///<![CDATA[VAT Code linked to the G/L Account (for example, 2 or 4)]]>
        public string VATCode { get; set; }

        ///<![CDATA[Description of VAT]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string VATDescription { get; set; }

        ///<![CDATA[Specify the kind of purchase this GL account is used for. This is important for the Belgian VAT return to indicate in which VAT box the base amount of purchase should go]]>
        public string VATGLAccountType { get; set; }

        ///<![CDATA[If you use a percentage of non deductible VAT, you can specify another GL account that will be used for the non deductible part of the VAT amount. This is used directly in the entry application of purchase invoices.]]>
        public Guid VATNonDeductibleGLAccount { get; set; }

        ///<![CDATA[If not the full amount of the VAT is deductible, you can indicate a percentage for the non decuctible part. This is used during the entry of purchase invoices]]>
        public double? VATNonDeductiblePercentage { get; set; }

        ///<![CDATA[The following values are supported: I (Invoice) C (Cash) (France)]]>
        public string VATSystem { get; set; }

        ///<![CDATA[Indicates the costing account for year end calculations]]>
        public Guid YearEndCostGLAccount { get; set; }

        ///<![CDATA[Indicates the reflection account that is used by year end application]]>
        public Guid YearEndReflectionGLAccount { get; set; }
    }
}