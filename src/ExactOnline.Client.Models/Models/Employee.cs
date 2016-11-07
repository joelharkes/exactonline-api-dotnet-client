using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    // Last generated on 2016-07-06 07:30:03Z


    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employee
    {
        ///<![CDATA[Obsolete]]>
        public byte? ActiveEmployment { get; set; }

        ///<![CDATA[Second address line]]>
        public string AddressLine2 { get; set; }

        ///<![CDATA[Third address line]]>
        public string AddressLine3 { get; set; }

        ///<![CDATA[Street of address]]>
        public string AddressStreet { get; set; }

        ///<![CDATA[Street number of address]]>
        public string AddressStreetNumber { get; set; }

        ///<![CDATA[Street number suffix of address]]>
        public string AddressStreetNumberSuffix { get; set; }

        ///<![CDATA[Birth date]]>
        public DateTime BirthDate { get; set; }

        ///<![CDATA[Birth name]]>
        public string BirthName { get; set; }

        ///<![CDATA[Birth middle name]]>
        public string BirthNamePrefix { get; set; }

        ///<![CDATA[Birth place]]>
        public string BirthPlace { get; set; }

        ///<![CDATA[Email of the employee at the office]]>
        public string BusinessEmail { get; set; }

        ///<![CDATA[Fax number of the employee at the office]]>
        public string BusinessFax { get; set; }

        ///<![CDATA[Office mobile number of the employee]]>
        public string BusinessMobile { get; set; }

        ///<![CDATA[Phone number of the employee at the office]]>
        public string BusinessPhone { get; set; }

        ///<![CDATA[Phone extension of the employee at the office]]>
        public string BusinessPhoneExtension { get; set; }

        ///<![CDATA[Obsolete]]>
        public string CASONumber { get; set; }

        ///<![CDATA[City]]>
        public string City { get; set; }

        ///<![CDATA[Code of the employee]]>
        public string Code { get; set; }

        ///<![CDATA[Country code]]>
        public string Country { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Customer ID]]>
        public Guid Customer { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Email address]]>
        public string Email { get; set; }

        ///<![CDATA[Employee number]]>
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[End date of the employee]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[First name of the employee]]>
        public string FirstName { get; set; }

        ///<![CDATA[Full name of the employee]]>
        public string FullName { get; set; }

        ///<![CDATA[Gender]]>
        public string Gender { get; set; }

        ///<![CDATA[Numeric ID of the employee]]>
        public Int32 HID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Initials]]>
        public string Initials { get; set; }

        ///<![CDATA[IsActive]]>
        public bool IsActive { get; set; }

        ///<![CDATA[Language code]]>
        public string Language { get; set; }

        ///<![CDATA[Last name]]>
        public string LastName { get; set; }

        ///<![CDATA[Description of the location of the employee (where am I?)]]>
        public string LocationDescription { get; set; }

        ///<![CDATA[Direct manager of the employee]]>
        public Guid Manager { get; set; }

        ///<![CDATA[Date of marriage]]>
        public DateTime MaritalDate { get; set; }

        ///<![CDATA[Marital status]]>
        public Int16 MaritalStatus { get; set; }

        ///<![CDATA[Middle name]]>
        public string MiddleName { get; set; }

        ///<![CDATA[Mobile phone]]>
        public string Mobile { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Municipality]]>
        public string Municipality { get; set; }

        public Int16 NameComposition { get; set; }

        ///<![CDATA[Nationality]]>
        public string Nationality { get; set; }

        ///<![CDATA[Nick name]]>
        public string NickName { get; set; }

        ///<![CDATA[Additional notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Name of partner]]>
        public string PartnerName { get; set; }

        ///<![CDATA[Middle name of partner]]>
        public string PartnerNamePrefix { get; set; }

        ///<![CDATA[Reference to the persons table in which the personal data of the employee is stored]]>
        public Guid Person { get; set; }

        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }

        ///<![CDATA[Phone number extension]]>
        public string PhoneExtension { get; set; }

        ///<![CDATA[Filename of picture]]>
        public string PictureFileName { get; set; }

        ///<![CDATA[Url of picture]]>
        public string PictureUrl { get; set; }

        ///<![CDATA[Postcode]]>
        public string Postcode { get; set; }

        ///<![CDATA[Private email address]]>
        public string PrivateEmail { get; set; }

        ///<![CDATA[Social security number]]>
        public string SocialSecurityNumber { get; set; }

        ///<![CDATA[Start date of the employee]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[State]]>
        public string State { get; set; }

        ///<![CDATA[Title]]>
        public string Title { get; set; }

        ///<![CDATA[User ID of employee]]>
        public Guid User { get; set; }

        ///<![CDATA[Name of user]]>
        public string UserFullName { get; set; }
    }
}
