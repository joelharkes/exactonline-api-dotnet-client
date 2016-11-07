using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Workcenter
    {
        ///<![CDATA[Code of the work center]]>
        public string Code { get; set; }

        ///<![CDATA[Reference to CostCenters]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Description of Costcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Reference to CostUnits]]>
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

        ///<![CDATA[Description of the work center]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[General burden rate]]>
        public double? GeneralBurdenRate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if labor burden is calculated as a percentage or amount]]>
        public byte IsLaborBurdenPercent { get; set; }

        ///<![CDATA[Labor burden rate]]>
        public double? LaborBurdenRate { get; set; }

        ///<![CDATA[Machine burden rate]]>
        public double? MachineBurdenRate { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Area to which the work center belongs.]]>
        public Guid ProductionArea { get; set; }

        ///<![CDATA[Run labor rate]]>
        public double? RunLaborRate { get; set; }

        ///<![CDATA[Search code of the work center]]>
        public string SearchCode { get; set; }

        ///<![CDATA[Setup labor rate]]>
        public double? SetupLaborRate { get; set; }

        ///<![CDATA[Reference to WorkcenterStatus]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Reference to WorkcenterTypes]]>
        public Int16 Type { get; set; }
    }
}