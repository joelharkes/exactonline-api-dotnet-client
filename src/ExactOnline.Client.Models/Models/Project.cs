using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Project
    {
        ///<![CDATA[The account for this project]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Contact person of Account]]>
        public Guid AccountContact { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Is additional invoice is allowed for project]]>
        public bool? AllowAdditionalInvoicing { get; set; }

        ///<![CDATA[Block time and cost entries]]>
        public bool? BlockEntry { get; set; }

        ///<![CDATA[Block rebilling]]>
        public bool? BlockRebilling { get; set; }

        ///<![CDATA[Budgeted amount of sales in the default currency of the company]]>
        public double? BudgetedAmount { get; set; }

        ///<![CDATA[Budgeted amount of costs in the default currency of the company]]>
        public double? BudgetedCosts { get; set; }

        ///<![CDATA[Collection of budgeted hours]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectHourBudget> BudgetedHoursPerHourType { get; set; }

        ///<![CDATA[Budgeted amount of revenue in the default currency of the company]]>
        public double? BudgetedRevenue { get; set; }

        ///<![CDATA[Budget type]]>
        public Int16 BudgetType { get; set; }

        ///<![CDATA[Budget type description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BudgetTypeDescription { get; set; }

        ///<![CDATA[Used only for PSA to link a project classification to the project]]>
        public Guid Classification { get; set; }

        ///<![CDATA[Description of Classification]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }

        ///<![CDATA[Code]]>
        public string Code { get; set; }

        ///<![CDATA[Used only for PSA to store the budgetted costs of a project (except for project type Campaign and Non-billable). Positive quantities only]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? CostsAmountFC { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Used only for PSA to store the customer's PO number]]>
        public string CustomerPOnumber { get; set; }

        ///<![CDATA[Description of the project]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Name of Division]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DivisionName { get; set; }

        ///<![CDATA[End date of the project. In combination with the start date the status is determined]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Item used for fixed price invoicing. To be defined per project. If empty the functionality relies on the setting]]>
        public Guid FixedPriceItem { get; set; }

        ///<![CDATA[Description of FixedPriceItem]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string FixedPriceItemDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Is invoice as quoted]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool InvoiceAsQuoted { get; set; }

        ///<![CDATA[Collection of invoice terms]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectTerm> InvoiceTerms { get; set; }

        ///<![CDATA[Responsible person for this project]]>
        public Guid Manager { get; set; }

        ///<![CDATA[Name of Manager]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ManagerFullname { get; set; }

        ///<![CDATA[Purchase markup percentage]]>
        public double? MarkupPercentage { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[For additional information about projects]]>
        public string Notes { get; set; }

        ///<![CDATA[Used only for PSA. This item is used for prepaid invoicing. If left empty, the functionality relies on a setting]]>
        public Guid PrepaidItem { get; set; }

        ///<![CDATA[Description of PrepaidItem]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PrepaidItemDescription { get; set; }

        ///<![CDATA[Reference to ProjectPrepaidTypes]]>
        public Int16 PrepaidType { get; set; }

        ///<![CDATA[Description of PrepaidType]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PrepaidTypeDescription { get; set; }

        ///<![CDATA[Collection of employee restrictions]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionEmployee> ProjectRestrictionEmployees { get; set; }

        ///<![CDATA[Collection of item restrictions]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionItem> ProjectRestrictionItems { get; set; }

        ///<![CDATA[Collection of rebilling restrictions]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<ProjectRestrictionRebilling> ProjectRestrictionRebillings { get; set; }

        ///<![CDATA[Budgeted time. Total number of hours estimated for the fixed price project]]>
        public double? SalesTimeQuantity { get; set; }

        ///<![CDATA[Source quotation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SourceQuotation { get; set; }

        ///<![CDATA[Start date of a project. In combination with the end date the status is determined]]>
        public DateTime StartDate { get; set; }

        public double? TimeQuantityToAlert { get; set; }

        ///<![CDATA[Reference to ProjectTypes]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[Using billing milestones]]>
        public bool? UseBillingMilestones { get; set; }
    }
}