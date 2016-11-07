using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class OperationResource
    {
        ///<![CDATA[Reference to Accounts]]>
        public Guid Account { get; set; }

        ///<![CDATA[Attended percentage]]>
        public double? AttendedPercentage { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Reference to Currencies]]>
        public string Currency { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Efficiency percentage]]>
        public double? EfficiencyPercentage { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if this is the primary operation of the workcenter]]>
        public byte? IsPrimary { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Reference to Operations]]>
        public Guid Operation { get; set; }

        ///<![CDATA[Description of Operation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OperationDescription { get; set; }

        ///<![CDATA[Lead days from purchase]]>
        public Int32 PurchaseLeadDays { get; set; }

        ///<![CDATA[Unit of purchased item from supplier]]>
        public string PurchaseUnit { get; set; }

        ///<![CDATA[VAT code used for purchased item from supplier]]>
        public string PurchaseVATCode { get; set; }

        ///<![CDATA[Used in conjuction with RunMethod and EfficiencyPercentage to determine PlannedRunHours]]>
        public double? Run { get; set; }

        ///<![CDATA[Reference to OperationRunMethods]]>
        public Int16 RunMethod { get; set; }

        ///<![CDATA[Used in conjunction with SetupCount and SetupUnit to determine PlannedSetupHours]]>
        public double? Setup { get; set; }

        ///<![CDATA[Reference to TimeUnits]]>
        public string SetupUnit { get; set; }

        ///<![CDATA[Reference to RoutingStepTypes]]>
        public Int16 Type { get; set; }

        ///<![CDATA[Reference to Workcenter]]>
        public Guid Workcenter { get; set; }

        ///<![CDATA[Description of Workcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WorkcenterDescription { get; set; }
    }
}