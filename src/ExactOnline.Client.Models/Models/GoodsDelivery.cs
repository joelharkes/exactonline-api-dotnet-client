using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, false)]
    [DataServiceKey("EntryID")]
    public class GoodsDelivery
    {
        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Reference to account for delivery]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid DeliveryAccount { get; set; }

        ///<![CDATA[Delivery account code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }

        ///<![CDATA[Account name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }

        ///<![CDATA[Reference to shipping address]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid DeliveryAddress { get; set; }

        ///<![CDATA[Reference to contact for delivery]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid DeliveryContact { get; set; }

        ///<![CDATA[Name of the contact person of the customer who will receive delivered goods]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }

        ///<![CDATA[Date of goods delivery]]>
        public DateTime DeliveryDate { get; set; }

        ///<![CDATA[Delivery number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 DeliveryNumber { get; set; }

        ///<![CDATA[Header description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Document that is manually linked to the sales order delivery]]>
        public Guid Document { get; set; }

        ///<![CDATA[Document Subject]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<GoodsDeliveryLine> GoodsDeliveryLines { get; set; }

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
        public string Remarks { get; set; }

        ///<![CDATA[Reference to shipping method]]>
        public Guid ShippingMethod { get; set; }

        ///<![CDATA[Code of shipping method]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ShippingMethodCode { get; set; }

        ///<![CDATA[Description of shipping method]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }

        ///<![CDATA[Reference to header tracking number]]>
        public string TrackingNumber { get; set; }

        ///<![CDATA[Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Warehouse { get; set; }

        ///<![CDATA[Code of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        ///<![CDATA[Description of Warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}