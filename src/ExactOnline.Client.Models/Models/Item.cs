using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Item
    {
        ///<![CDATA[Barcode of the item (numeric string)]]>
        public string Barcode { get; set; }

        ///<![CDATA[Item class code referring to ItemClasses with ClassID 1]]>
        public string Class_01 { get; set; }

        ///<![CDATA[Item class code referring to ItemClasses with ClassID 2]]>
        public string Class_02 { get; set; }

        ///<![CDATA[Item class code referring to ItemClasses with ClassID 3]]>
        public string Class_03 { get; set; }

        ///<![CDATA[Item class code referring to ItemClasses with ClassID 4]]>
        public string Class_04 { get; set; }

        ///<![CDATA[Item class code referring to ItemClasses with ClassID 5]]>
        public string Class_05 { get; set; }

        ///<![CDATA[Item code]]>
        public string Code { get; set; }

        ///<![CDATA[Copy remarks to sales lines]]>
        public byte CopyRemarks { get; set; }

        ///<![CDATA[The currency of the current and proposed cost price]]>
        public string CostPriceCurrency { get; set; }

        ///<![CDATA[Proposed cost price]]>
        public double? CostPriceNew { get; set; }

        ///<![CDATA[The current standard cost price]]>
        public double? CostPriceStandard { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the item]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Together with StartDate this determines if the item is active]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Extra description text, slightly longer than the regular description (255 instead of 60)]]>
        public string ExtraDescription { get; set; }

        ///<![CDATA[Free boolean field 1]]>
        public bool? FreeBoolField_01 { get; set; }

        ///<![CDATA[Free boolean field 2]]>
        public bool? FreeBoolField_02 { get; set; }

        ///<![CDATA[Free boolean field 3]]>
        public bool? FreeBoolField_03 { get; set; }

        ///<![CDATA[Free boolean field 4]]>
        public bool? FreeBoolField_04 { get; set; }

        ///<![CDATA[Free boolean field 5]]>
        public bool? FreeBoolField_05 { get; set; }

        ///<![CDATA[Free date field 1]]>
        public DateTime FreeDateField_01 { get; set; }

        ///<![CDATA[Free date field 2]]>
        public DateTime FreeDateField_02 { get; set; }

        ///<![CDATA[Free date field 3]]>
        public DateTime FreeDateField_03 { get; set; }

        ///<![CDATA[Free date field 4]]>
        public DateTime FreeDateField_04 { get; set; }

        ///<![CDATA[Free date field 5]]>
        public DateTime FreeDateField_05 { get; set; }

        ///<![CDATA[Free numeric field 1]]>
        public double? FreeNumberField_01 { get; set; }

        ///<![CDATA[Free numeric field 2]]>
        public double? FreeNumberField_02 { get; set; }

        ///<![CDATA[Free numeric field 3]]>
        public double? FreeNumberField_03 { get; set; }

        ///<![CDATA[Free numeric field 4]]>
        public double? FreeNumberField_04 { get; set; }

        ///<![CDATA[Free numeric field 5]]>
        public double? FreeNumberField_05 { get; set; }

        ///<![CDATA[Free numeric field 6]]>
        public double? FreeNumberField_06 { get; set; }

        ///<![CDATA[Free numeric field 7]]>
        public double? FreeNumberField_07 { get; set; }

        ///<![CDATA[Free numeric field 8]]>
        public double? FreeNumberField_08 { get; set; }

        ///<![CDATA[Free text field 1]]>
        public string FreeTextField_01 { get; set; }

        ///<![CDATA[Free text field 2]]>
        public string FreeTextField_02 { get; set; }

        ///<![CDATA[Free text field 3]]>
        public string FreeTextField_03 { get; set; }

        ///<![CDATA[Free text field 4]]>
        public string FreeTextField_04 { get; set; }

        ///<![CDATA[Free text field 5]]>
        public string FreeTextField_05 { get; set; }

        ///<![CDATA[Free text field 6]]>
        public string FreeTextField_06 { get; set; }

        ///<![CDATA[Free text field 7]]>
        public string FreeTextField_07 { get; set; }

        ///<![CDATA[Free text field 8]]>
        public string FreeTextField_08 { get; set; }

        ///<![CDATA[Free text field 9]]>
        public string FreeTextField_09 { get; set; }

        ///<![CDATA[Free text field 10]]>
        public string FreeTextField_10 { get; set; }

        ///<![CDATA[GL account the cost entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
        public Guid GLCosts { get; set; }

        ///<![CDATA[Code of GL account for costs]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLCostsCode { get; set; }

        ///<![CDATA[Description of GLCosts]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLCostsDescription { get; set; }

        ///<![CDATA[GL account the revenue will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
        public Guid GLRevenue { get; set; }

        ///<![CDATA[Code of GLRevenue]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLRevenueCode { get; set; }

        ///<![CDATA[Description of GLRevenue]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLRevenueDescription { get; set; }

        ///<![CDATA[GL account the stock entries will be booked on. This overrules the GL account from the item group. If the license contains 'Intuit integration' this property overrides the value in Settings, not the item group.]]>
        public Guid GLStock { get; set; }

        ///<![CDATA[Code of GL account for stock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLStockCode { get; set; }

        ///<![CDATA[Description of GLStock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLStockDescription { get; set; }

        ///<![CDATA[Gross weight for international goods shipments]]>
        public double? GrossWeight { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if batches are used for this item]]>
        public byte IsBatchItem { get; set; }

        ///<![CDATA[Used with Batch number feature. Indicates if the item can have a batch number]]>
        public byte IsBatchNumberItem { get; set; }

        ///<![CDATA[Indicates if fractions (for example 0.35) are allowed for quantities of this item]]>
        public bool? IsFractionAllowedItem { get; set; }

        ///<![CDATA[Indicates that an Item is produced to Inventory, not purchased]]>
        public byte IsMakeItem { get; set; }

        ///<![CDATA[Only used for packages (IsPackageItem=1). To indicate if this package is a new contract type package]]>
        public byte IsNewContract { get; set; }

        ///<![CDATA[Is On demand Item]]>
        public byte IsOnDemandItem { get; set; }

        ///<![CDATA[Indicates if the item is a package item. Can only be created in the hosting administration]]>
        public bool? IsPackageItem { get; set; }

        ///<![CDATA[Indicates if the item can be purchased]]>
        public bool? IsPurchaseItem { get; set; }

        ///<![CDATA[Indicated if the item is used in voucher functionality]]>
        public byte IsRegistrationCodeItem { get; set; }

        ///<![CDATA[Indicates if the item can be sold]]>
        public bool? IsSalesItem { get; set; }

        ///<![CDATA[Indicates that serial numbers are used for this item]]>
        public bool? IsSerialItem { get; set; }

        ///<![CDATA[Used with Serial number feature. Indicates if the item can have a serial number]]>
        public bool? IsSerialNumberItem { get; set; }

        ///<![CDATA[If you have the Trade or Manufacturing license and you check this property the item will be shown in the stock positions overview, stock counts and transaction lists. If you have the Invoice module and you check this property you will get a general journal entry based on the Stock and Costs G/L accounts of the item group. If you don’t want the general journal entry to be created you should change the Stock/Costs G/L account on the Item group page to the type Costs instead of Inventory.]]>
        public bool? IsStockItem { get; set; }

        ///<![CDATA[Indicates if the item is provided by an outside supplier]]>
        public bool? IsSubcontractedItem { get; set; }

        ///<![CDATA[Indicates if tax needs to be calculated for this item]]>
        public byte? IsTaxableItem { get; set; }

        ///<![CDATA[Indicates if the item is a time unit item (for example a labor hour item)]]>
        public byte IsTime { get; set; }

        ///<![CDATA[Indicates if the item can be exported to a web shop]]>
        public byte IsWebshopItem { get; set; }

        ///<![CDATA[GUID of Item group of the item]]>
        public Guid ItemGroup { get; set; }

        ///<![CDATA[Code of ItemGroup]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemGroupCode { get; set; }

        ///<![CDATA[Description of ItemGroup]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ItemGroupDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Net weight for international goods shipments]]>
        public double? NetWeight { get; set; }

        ///<![CDATA[Notes]]>
        public string Notes { get; set; }

        ///<![CDATA[File name of picture]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PictureName { get; set; }

        ///<![CDATA[Url where thumbnail picture can be retrieved]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }

        ///<![CDATA[Url where picture can be retrieved]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }

        ///<![CDATA[Code of SalesVat]]>
        public string SalesVatCode { get; set; }

        ///<![CDATA[Description of SalesVatCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesVatCodeDescription { get; set; }

        ///<![CDATA[Search code of the item]]>
        public string SearchCode { get; set; }

        ///<![CDATA[Security level (0 - 100)]]>
        public Int32 SecurityLevel { get; set; }

        ///<![CDATA[Together with EndDate this determines if the item is active]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Quantity that is in stock]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? Stock { get; set; }

        ///<![CDATA[The standard unit of this item]]>
        public string Unit { get; set; }

        ///<![CDATA[Description of Unit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }

        ///<![CDATA[Type of unit: A=Area, L=Length, O=Other, T=Time, V=Volume, W=Weight]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UnitType { get; set; }
    }
}