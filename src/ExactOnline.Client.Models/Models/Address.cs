using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Address
    {
        ///<![CDATA[Account linked to the address]]>
        public Guid Account { get; set; }

        ///<![CDATA[Indicates if the account is a supplier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }

        ///<![CDATA[Name of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[First address line]]>
        public string AddressLine1 { get; set; }

        ///<![CDATA[Second address line]]>
        public string AddressLine2 { get; set; }

        ///<![CDATA[Third address line]]>
        public string AddressLine3 { get; set; }

        ///<![CDATA[City]]>
        public string City { get; set; }

        ///<![CDATA[Contact linked to Address]]>
        public Guid Contact { get; set; }

        ///<![CDATA[Contact name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ContactName { get; set; }

        ///<![CDATA[Country code]]>
        public string Country { get; set; }

        ///<![CDATA[Country name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Fax number]]>
        public string Fax { get; set; }

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

        ///<![CDATA[Free number field 1]]>
        public double? FreeNumberField_01 { get; set; }

        ///<![CDATA[Free number field 2]]>
        public double? FreeNumberField_02 { get; set; }

        ///<![CDATA[Free number field 3]]>
        public double? FreeNumberField_03 { get; set; }

        ///<![CDATA[Free number field 4]]>
        public double? FreeNumberField_04 { get; set; }

        ///<![CDATA[Free number field 5]]>
        public double? FreeNumberField_05 { get; set; }

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

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Mailbox]]>
        public string Mailbox { get; set; }

        ///<![CDATA[Indicates if the address is the main address for this type]]>
        public bool? Main { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Last 5 digits of SIRET number which is an intern sequential number of 4 digits representing the identification of the localization of the office]]>
        public string NicNumber { get; set; }

        ///<![CDATA[Notes for an address]]>
        public string Notes { get; set; }

        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }

        ///<![CDATA[Phone extension]]>
        public string PhoneExtension { get; set; }

        ///<![CDATA[Postcode]]>
        public string Postcode { get; set; }

        ///<![CDATA[State]]>
        public string State { get; set; }

        ///<![CDATA[Name of the State]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StateDescription { get; set; }

        ///<![CDATA[The type of address. Visit=1, Postal=2, Invoice=3, Delivery=4]]>
        public Int16 Type { get; set; }

        ///<![CDATA[The warehouse linked to the address, if a warehouse is linked the account will be empty. Can only be filled for type=Delivery]]>
        public Guid Warehouse { get; set; }

        ///<![CDATA[Code of the warehoude]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }

        ///<![CDATA[Description of the warehouse]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}