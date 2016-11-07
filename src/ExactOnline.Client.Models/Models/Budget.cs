using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Budget
    {
        ///<![CDATA[Budget amount (always in the default currency of the company)]]>
        public double? AmountDC { get; set; }

        ///<![CDATA[Budget scenario]]>
        public Guid BudgetScenario { get; set; }

        ///<![CDATA[Code of BudgetScenario]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioCode { get; set; }

        ///<![CDATA[Description of BudgetScenario]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioDescription { get; set; }

        ///<![CDATA[Used for cost center-specific budgets - NULL otherwise]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Description of Costcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Used for cost unit-specific budgets - NULL otherwise]]>
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

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[G/L account]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Code of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Numerical ID. Never displayed to the user, but it may have its use for performance reasons]]>
        public Int64 HID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Used for item-specific budgets - NULL otherwise]]>
        public Guid Item { get; set; }

        ///<![CDATA[Code of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Period (combined with financial year)]]>
        public Int16 ReportingPeriod { get; set; }

        ///<![CDATA[Financial year]]>
        public Int16 ReportingYear { get; set; }
    }
}