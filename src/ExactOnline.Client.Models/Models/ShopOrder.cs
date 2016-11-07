using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrder
    {
        ///<![CDATA[The cost center linked to the shop order]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Description of Costcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[The cost unit linked to the shop order]]>
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

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Date on which the shop order was placed]]>
        public DateTime EntryDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicator that Shop order is in planning]]>
        public byte IsInPlanning { get; set; }

        ///<![CDATA[Indicator if the Shop order is on hold]]>
        public byte IsOnHold { get; set; }

        ///<![CDATA[Indicator that the Shop order has been released to production]]>
        public byte IsReleased { get; set; }

        ///<![CDATA[Reference to the item]]>
        public Guid Item { get; set; }

        ///<![CDATA[Reference to ItemVersion]]>
        public Guid ItemVersion { get; set; }

        ///<![CDATA[Description of Item Version]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemVersionDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Notes - only viewed internally]]>
        public string Notes { get; set; }

        ///<![CDATA[Planned date]]>
        public DateTime PlannedDate { get; set; }

        ///<![CDATA[Planned quantity]]>
        public double? PlannedQuantity { get; set; }

        ///<![CDATA[Planned end date]]>
        public DateTime PlannedStartDate { get; set; }

        ///<![CDATA[Produced quantity]]>
        public double? ProducedQuantity { get; set; }

        ///<![CDATA[Reference to Project]]>
        public Guid Project { get; set; }

        ///<![CDATA[Description of Project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA[Quantity ready to ship]]>
        public double? ReadyToShipQuantity { get; set; }

        ///<![CDATA[Collection of Sales order lines]]>
        public IEnumerable<SalesOrderLine> SalesOrderLines { get; set; }

        ///<![CDATA[Shop order main]]>
        public Guid ShopOrderMain { get; set; }

        ///<![CDATA[Shop order main number]]>
        public Int32 ShopOrderMainNumber { get; set; }

        ///<![CDATA[Collection of Shop order Material plans]]>
        public IEnumerable<ShopOrderMaterialPlan> ShopOrderMaterialPlans { get; set; }

        ///<![CDATA[Unique number to indentify the shop order]]>
        public Int32 ShopOrderNumber { get; set; }

        ///<![CDATA[Shop order parent]]>
        public Guid ShopOrderParent { get; set; }

        ///<![CDATA[Shop order parent number]]>
        public Int32 ShopOrderParentNumber { get; set; }

        ///<![CDATA[Collection of Shop order Routing step plans]]>
        public IEnumerable<ShopOrderRoutingStepPlan> ShopOrderRoutingStepPlans { get; set; }

        ///<![CDATA[Indicates the type of Shop Order: 10 Open, 20 In process, 30 Finished, 40 Completed]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Overall status of the line: 9040 Regular]]>
        public Int16 Type { get; set; }

        ///<![CDATA[Reference to the Warehouse associated with the Shop order]]>
        public Guid Warehouse { get; set; }

        ///<![CDATA[Your reference (of the customer)]]>
        public string YourRef { get; set; }
    }
}