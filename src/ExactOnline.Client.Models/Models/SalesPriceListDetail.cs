using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceListDetail
    {
        ///<![CDATA[Customer account Id]]>
        public Guid Account { get; set; }

        ///<![CDATA[Customer account name]]>
        public string AccountName { get; set; }

        ///<![CDATA[Standard price]]>
        public Guid BasePrice { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency]]>
        public string Currency { get; set; }

        ///<![CDATA[Discount]]>
        public double? Discount { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Item]]>
        public Guid Item { get; set; }

        ///<![CDATA[Description of the item]]>
        public string ItemDescription { get; set; }

        ///<![CDATA[ItemGroup]]>
        public Guid ItemGroup { get; set; }

        ///<![CDATA[Default sales unit of the item]]>
        public string ItemUnit { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[New price after discount]]>
        public double? NewPrice { get; set; }

        ///<![CDATA[Number of the item per unit]]>
        public double? NumberOfItemsPerUnit { get; set; }

        ///<![CDATA[Code of the PriceList]]>
        public string PriceListCode { get; set; }

        ///<![CDATA[Id of the PriceList]]>
        public Guid PriceListId { get; set; }

        ///<![CDATA[Quantity]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Unit]]>
        public string Unit { get; set; }
    }
}