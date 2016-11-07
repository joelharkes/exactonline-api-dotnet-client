using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesItemPrice
    {
        ///<![CDATA[ID of the customer]]>
        public Guid Account { get; set; }

        ///<![CDATA[Name of the customer account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[The currency of the price]]>
        public string Currency { get; set; }

        ///<![CDATA[The default unit of the item]]>
        public string DefaultItemUnit { get; set; }

        ///<![CDATA[The description of the default item unit]]>
        public string DefaultItemUnitDescription { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Together with StartDate this determines whether the price is active]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Item ID]]>
        public Guid Item { get; set; }

        ///<![CDATA[Code of Item]]>
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
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

        ///<![CDATA[This is the multiplication factor when going from default item unit to the unit of this price.For example if the default item unit is 'gram' and the price unit is 'kilogram' then the value of this property is 1000.]]>
        public double? NumberOfItemsPerUnit { get; set; }

        ///<![CDATA[The actual price of this sales item]]>
        public double? Price { get; set; }

        ///<![CDATA[Minimum quantity to which the price is applicable]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Together with EndDate this determines whether the price is active]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[The unit code of the price]]>
        public string Unit { get; set; }

        ///<![CDATA[Description of the price unit]]>
        public string UnitDescription { get; set; }
    }
}