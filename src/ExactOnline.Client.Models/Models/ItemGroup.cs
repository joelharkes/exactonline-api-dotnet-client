using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemGroup
    {
        ///<![CDATA[Code of the item group]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the item group]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[GL account on which the costs of items of this group will be booked]]>
        public Guid GLCosts { get; set; }

        ///<![CDATA[Code of GLCosts]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }

        ///<![CDATA[Description of GLCosts]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }

        ///<![CDATA[GL Purchase account for purchase invoicing according to (non-) perpetual inventory method]]>
        public Guid GLPurchaseAccount { get; set; }

        ///<![CDATA[Code of GLPurchase]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountCode { get; set; }

        ///<![CDATA[Description of GLPurchaseAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLPurchaseAccountDescription { get; set; }

        ///<![CDATA[GL account that will be used for the 'Standard cost price' valuation method to balance the difference between purchase price and cost price]]>
        public Guid GLPurchasePriceDifference { get; set; }

        ///<![CDATA[Code of GLPurchasePriceDifference]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceCode { get; set; }

        ///<![CDATA[Description of GLPurchasePriceDifference]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLPurchasePriceDifferenceDescr { get; set; }

        ///<![CDATA[GL account on which the revenue for items of this group will be booked]]>
        public Guid GLRevenue { get; set; }

        ///<![CDATA[Code of GLRevenue]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }

        ///<![CDATA[Description of GLRevenue]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }

        ///<![CDATA[GL account on which stock entries will be booked for items of this group]]>
        public Guid GLStock { get; set; }

        ///<![CDATA[Code of GLStock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }

        ///<![CDATA[Description of GLStock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }

        ///<![CDATA[GL stock variance account for perpetual inventory]]>
        public Guid GLStockVariance { get; set; }

        ///<![CDATA[Code of GLStockVariance]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceCode { get; set; }

        ///<![CDATA[Description of GLStockVariance]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLStockVarianceDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if this is the default item group that will be assigned when a new item is created]]>
        public byte IsDefault { get; set; }

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
    }
}