using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Contact
    {
        ///<![CDATA[The account to which the contact belongs]]>
        public Guid Account { get; set; }

        ///<![CDATA[Indicates if account is a customer]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool AccountIsCustomer { get; set; }

        ///<![CDATA[Indicates if account is a supplier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }

        ///<![CDATA[Reference to the main contact of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid AccountMainContact { get; set; }

        ///<![CDATA[Name of the account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Second address line]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AddressLine2 { get; set; }

        ///<![CDATA[Street name of the address]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AddressStreet { get; set; }

        ///<![CDATA[Street number of the address]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumber { get; set; }

        ///<![CDATA[Street number suffix of the address]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AddressStreetNumberSuffix { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 AllowMailing { get; set; }

        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }

        ///<![CDATA[Last birth name]]>
        public string BirthName { get; set; }

        ///<![CDATA[Middle birth name]]>
        public string BirthNamePrefix { get; set; }

        ///<![CDATA[Birth place]]>
        public string BirthPlace { get; set; }

        ///<![CDATA[Email address of the contact]]>
        public string BusinessEmail { get; set; }

        ///<![CDATA[Fax of the contact]]>
        public string BusinessFax { get; set; }

        ///<![CDATA[Mobile of the contact]]>
        public string BusinessMobile { get; set; }

        ///<![CDATA[Phone of the contact]]>
        public string BusinessPhone { get; set; }

        ///<![CDATA[Phone extension of the contact]]>
        public string BusinessPhoneExtension { get; set; }

        ///<![CDATA[City]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string City { get; set; }

        ///<![CDATA[Code of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Code { get; set; }

        ///<![CDATA[Country code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Email address of the contact]]>
        public string Email { get; set; }

        ///<![CDATA[End date]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[First name. Provide at least first name or last name to create a new contact]]>
        public string FirstName { get; set; }

        ///<![CDATA[Full name (First name Middle name Last name)]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string FullName { get; set; }

        ///<![CDATA[Gender]]>
        public string Gender { get; set; }

        ///<![CDATA[Contact ID]]>
        public Int32 HID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Identification date]]>
        public DateTime IdentificationDate { get; set; }

        ///<![CDATA[Reference to the identification document of the contact]]>
        public Guid IdentificationDocument { get; set; }

        ///<![CDATA[Reference to the user responsible for identification]]>
        public Guid IdentificationUser { get; set; }

        ///<![CDATA[Initials]]>
        public string Initials { get; set; }

        ///<![CDATA[Indicates whether contacts are excluded from the marketing list]]>
        public bool? IsMailingExcluded { get; set; }

        ///<![CDATA[Indicates if this is the main contact of the linked account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? IsMainContact { get; set; }

        ///<![CDATA[Jobtitle of the contact]]>
        public string JobTitleDescription { get; set; }

        ///<![CDATA[Language code]]>
        public string Language { get; set; }

        ///<![CDATA[Last name. Provide at least first name or last name to create a new contact]]>
        public string LastName { get; set; }

        ///<![CDATA[The user should be able to do a full text search on these notes to gather contacts for a marketing campaign]]>
        public string MarketingNotes { get; set; }

        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }

        ///<![CDATA[Business phone of the contact]]>
        public string Mobile { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }

        ///<![CDATA[Extra remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Last name of partner]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PartnerName { get; set; }

        ///<![CDATA[Middlename of partner]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PartnerNamePrefix { get; set; }

        ///<![CDATA[Reference to the personal information of this contact such as name, gender, address etc.]]>
        public Guid Person { get; set; }

        ///<![CDATA[Phone of the contact]]>
        public string Phone { get; set; }

        ///<![CDATA[Phone extension of the contact]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PhoneExtension { get; set; }

        ///<![CDATA[This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.]]>
        public byte[] Picture { get; set; }

        ///<![CDATA[Filename of the picture]]>
        public string PictureName { get; set; }

        ///<![CDATA[Url to retrieve the picture thumbnail]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PictureThumbnailUrl { get; set; }

        ///<![CDATA[Url to retrieve the picture]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PictureUrl { get; set; }

        ///<![CDATA[Postcode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Postcode { get; set; }

        ///<![CDATA[Social security number]]>
        public string SocialSecurityNumber { get; set; }

        ///<![CDATA[Start date]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[State]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string State { get; set; }

        ///<![CDATA[Title]]>
        public string Title { get; set; }
    }
}