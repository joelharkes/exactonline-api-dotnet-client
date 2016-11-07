using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("UserID")]
    public class User
    {
        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }

        ///<![CDATA[Birth name]]>
        public string BirthName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Customer the user belongs to]]>
        public Guid Customer { get; set; }

        ///<![CDATA[Name of Customer]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CustomerName { get; set; }

        ///<![CDATA[Email address of the user]]>
        public string Email { get; set; }

        ///<![CDATA[Date after which the user login is disabled. NULL means no enddate]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[First name]]>
        public string FirstName { get; set; }

        ///<![CDATA[Full name of the user]]>
        public string FullName { get; set; }

        ///<![CDATA[Gender: M=Male, V=Female, O=Unknown]]>
        public string Gender { get; set; }

        ///<![CDATA[Initials]]>
        public string Initials { get; set; }

        ///<![CDATA[Language (culture) that is used in Exact Online]]>
        public string Language { get; set; }

        ///<![CDATA[The last time this user logged in]]>
        public DateTime LastLogin { get; set; }

        ///<![CDATA[Last name]]>
        public string LastName { get; set; }

        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }

        ///<![CDATA[Mobile phone]]>
        public string Mobile { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }

        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }

        ///<![CDATA[Phone number extension]]>
        public string PhoneExtension { get; set; }

        ///<![CDATA[Profile code]]>
        public string ProfileCode { get; set; }

        ///<![CDATA[Startdate after which the login is allowed. If the start date is NULL the login is allowed as well]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Start Division]]>
        public Int32 StartDivision { get; set; }

        ///<![CDATA[Title]]>
        public string Title { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid UserID { get; set; }

        ///<![CDATA[Login name of the user]]>
        public string UserName { get; set; }

        ///<![CDATA[Collection of user roles]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<UserRole> UserRoles { get; set; }

        ///<![CDATA[Collection of user roles per division]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<UserRolePerDivision> UserRolesPerDivision { get; set; }

        ///<![CDATA[Obsolete]]>
        public string UserTypesList { get; set; }
    }
}