using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ManufacturingTimeTransaction
    {
        ///<![CDATA[Manufacturing time type: Setup = 10, Run = 20]]>
        public Int16 Activity { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Employee linked to the transaction]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Machine hours]]>
        public double? Hours { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Is the operation finished?]]>
        public byte? IsOperationFinished { get; set; }

        ///<![CDATA[Labor Hours on the operation]]>
        public double? LaborHours { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Notes linked to the time transaction]]>
        public string Notes { get; set; }

        ///<![CDATA[Percentage of the operation that is complete]]>
        public double? PercentComplete { get; set; }

        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Routing step linked to the transaction]]>
        public Guid RoutingStepPlan { get; set; }

        ///<![CDATA[Shop order linked to the transaction]]>
        public Guid ShopOrder { get; set; }

        ///<![CDATA[Status of the transaction: Draft = 1, Submitted = 10]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Timed time transaction linked to the transaction]]>
        public Guid TimedTimeTransaction { get; set; }

        ///<![CDATA[Workcenter linked to the transaction]]>
        public Guid WorkCenter { get; set; }
    }
}