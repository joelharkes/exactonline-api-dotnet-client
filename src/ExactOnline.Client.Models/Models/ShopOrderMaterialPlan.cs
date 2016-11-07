using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderMaterialPlan
    {
        ///<![CDATA[Indicates if this is a backflush step]]>
        public byte? Backflush { get; set; }

        ///<![CDATA[Calculator type]]>
        public Int16 CalculatorType { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the material]]>
        public string Description { get; set; }

        ///<![CDATA[Detail drawing reference]]>
        public string DetailDrawing { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to Items table]]>
        public Guid Item { get; set; }

        ///<![CDATA[Item Code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }

        ///<![CDATA[Line number]]>
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

        ///<![CDATA[Line notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Planned amount in the currency of the transaction]]>
        public double? PlannedAmountFC { get; set; }

        ///<![CDATA[Date that the material is required.]]>
        public DateTime PlannedDate { get; set; }

        ///<![CDATA[Planned price of the material]]>
        public double? PlannedPriceFC { get; set; }

        ///<![CDATA[Intended quantity]]>
        public double? PlannedQuantity { get; set; }

        ///<![CDATA[Intended quantity unit factor]]>
        public double? PlannedQuantityFactor { get; set; }

        ///<![CDATA[Reference to ShopOrders table]]>
        public Guid ShopOrder { get; set; }

        ///<![CDATA[Line status]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Type]]>
        public Int16 Type { get; set; }

        ///<![CDATA[Unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }

        ///<![CDATA[Unit description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
    }
}