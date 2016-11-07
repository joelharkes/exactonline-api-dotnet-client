using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUser
    {
        ///<![CDATA[ID of the account the user is involved with]]>
        public Guid Account { get; set; }

        ///<![CDATA[City of the account]]>
        public string AccountCity { get; set; }

        ///<![CDATA[Code of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Supplier flag of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }

        ///<![CDATA[Logo thumbnail url of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountLogoThumbnailUrl { get; set; }

        ///<![CDATA[Name of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Status of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountStatus { get; set; }

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

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[ID of the user role]]>
        public Guid InvolvedUserRole { get; set; }

        ///<![CDATA[Description of the user role]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvolvedUserRoleDescription { get; set; }

        ///<![CDATA[Main contact flag of the involved user]]>
        public bool? IsMainContact { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Email of a person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PersonEmail { get; set; }

        ///<![CDATA[Phone of a person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PersonPhone { get; set; }

        ///<![CDATA[Phone extension of a person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PersonPhoneExtension { get; set; }

        ///<![CDATA[Picture thumbnail url of a person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PersonPictureThumbnailUrl { get; set; }

        ///<![CDATA[ID of the involved user]]>
        public Guid User { get; set; }

        ///<![CDATA[User name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string UserFullName { get; set; }
    }
}