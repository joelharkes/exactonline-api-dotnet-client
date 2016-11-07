using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderRoutingStepPlan
    {
        ///<![CDATA[Reference to Account providing the Outsourced item]]>
        public Guid Account { get; set; }

        ///<![CDATA[Account name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Account number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountNumber { get; set; }

        ///<![CDATA[Attended Percentage]]>
        public double? AttendedPercentage { get; set; }

        ///<![CDATA[Indicates if this is a backflush step]]>
        public byte? Backflush { get; set; }

        ///<![CDATA[Total cost / Shop order planned quantity]]>
        public double? CostPerItem { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the operation]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Efficiency Percentage]]>
        public double? EfficiencyPercentage { get; set; }

        ///<![CDATA[Conversion factor type between Shop order Item and Subcontract purchase Unit]]>
        public Int16 FactorType { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Sequential order of the operation]]>
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

        ///<![CDATA[Notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Reference to Operations]]>
        public Guid Operation { get; set; }

        ///<![CDATA[Code of the routing step operation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OperationCode { get; set; }

        ///<![CDATA[Description of the operation step]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }

        ///<![CDATA[Reference to OperationResources]]>
        public Guid OperationResource { get; set; }

        ///<![CDATA[Planned end date]]>
        public DateTime PlannedEndDate { get; set; }

        ///<![CDATA[Planned run hours]]>
        public double? PlannedRunHours { get; set; }

        ///<![CDATA[Planned setup hours]]>
        public double? PlannedSetupHours { get; set; }

        ///<![CDATA[Planned start date]]>
        public DateTime PlannedStartDate { get; set; }

        ///<![CDATA[Setup hours + Run hours]]>
        public double? PlannedTotalHours { get; set; }

        ///<![CDATA[Reference to Units]]>
        public string PurchaseUnit { get; set; }

        ///<![CDATA[Purchase Unit Factor]]>
        public double? PurchaseUnitFactor { get; set; }

        ///<![CDATA[Purchase Unit Price in the currency of the transaction]]>
        public double? PurchaseUnitPriceFC { get; set; }

        ///<![CDATA[Purchase unit quantity of the plan]]>
        public double? PurchaseUnitQuantity { get; set; }

        ///<![CDATA[Reference to RoutingStepTypes]]>
        public Int16 RoutingStepType { get; set; }

        ///<![CDATA[Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours]]>
        public double? Run { get; set; }

        ///<![CDATA[Reference to OperationMethod]]>
        public Int16 RunMethod { get; set; }

        ///<![CDATA[Description of RunMethod]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string RunMethodDescription { get; set; }

        ///<![CDATA[Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours]]>
        public double? Setup { get; set; }

        ///<![CDATA[Reference to TimeUnits]]>
        public string SetupUnit { get; set; }

        ///<![CDATA[Reference to Shop orders]]>
        public Guid ShopOrder { get; set; }

        ///<![CDATA[Reference to OperationStatus]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Subcontracted lead days]]>
        public Int32 SubcontractedLeadDays { get; set; }

        ///<![CDATA[Collection of TimeTransactions]]>
        public IEnumerable<ManufacturingTimeTransaction> TimeTransactions { get; set; }

        ///<![CDATA[Total cost of the routing line]]>
        public double? TotalCostDC { get; set; }

        ///<![CDATA[Reference to Workcenters]]>
        public Guid Workcenter { get; set; }

        ///<![CDATA[Workcenter code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WorkcenterCode { get; set; }

        ///<![CDATA[Workcenter description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }
}