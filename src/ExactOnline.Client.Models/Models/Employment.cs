using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employment
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Employee ID]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }

        ///<![CDATA[Numeric number of Employee]]>
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[End date of employment]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 HID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[ID of employment ended]]>
        public Int32 ReasonEnd { get; set; }

        ///<![CDATA[Reason of end of employment]]>
        public string ReasonEndDescription { get; set; }

        ///<![CDATA[Reason of ended flexible employment]]>
        public Int32 ReasonEndFlex { get; set; }

        ///<![CDATA[Other reason for end of employment]]>
        public string ReasonEndFlexDescription { get; set; }

        ///<![CDATA[Start date of employment]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
        public DateTime StartDateOrganization { get; set; }
    }
}