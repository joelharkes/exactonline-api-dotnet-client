using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentOrganization
    {
        ///<![CDATA[Cost center code]]>
        public string CostCenter { get; set; }

        ///<![CDATA[Description of cost center]]>
        public string CostCenterDescription { get; set; }

        ///<![CDATA[Cost unit code]]>
        public string CostUnit { get; set; }

        ///<![CDATA[Description of cost unit]]>
        public string CostUnitDescription { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[ID of department]]>
        public Guid Department { get; set; }

        ///<![CDATA[Department code]]>
        public string DepartmentCode { get; set; }

        ///<![CDATA[Department description for organization]]>
        public string DepartmentDescription { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[ID of employee]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }

        ///<![CDATA[Numeric ID of the employee]]>
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[Employement ID]]>
        public Guid Employment { get; set; }

        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 EmploymentHID { get; set; }

        ///<![CDATA[Organization end date]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[ID of job title]]>
        public Guid JobTitle { get; set; }

        ///<![CDATA[Job title code]]>
        public string JobTitleCode { get; set; }

        ///<![CDATA[Job title description]]>
        public string JobTitleDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Organization start date]]>
        public DateTime StartDate { get; set; }
    }
}