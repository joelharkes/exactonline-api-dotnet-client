using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ActiveEmployment
    {
        ///<![CDATA[The average number of contract days that an employee works per week]]>
        public double? AverageDaysPerWeek { get; set; }

        ///<![CDATA[The average number of contract hours that an employee works per week]]>
        public double? AverageHoursPerWeek { get; set; }

        ///<![CDATA[Employment contract ID]]>
        public Guid Contract { get; set; }

        ///<![CDATA[Document ID of the employment contract]]>
        public Guid ContractDocument { get; set; }

        ///<![CDATA[End date of employment contract]]>
        public DateTime ContractEndDate { get; set; }

        ///<![CDATA[Employment probation end date]]>
        public DateTime ContractProbationEndDate { get; set; }

        ///<![CDATA[Employment probation period]]>
        public Int32 ContractProbationPeriod { get; set; }

        ///<![CDATA[Start date of employment contract]]>
        public DateTime ContractStartDate { get; set; }

        ///<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
        public Int32 ContractType { get; set; }

        ///<![CDATA[Description of employment contract type]]>
        public string ContractTypeDescription { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Department of employee]]>
        public Guid Department { get; set; }

        ///<![CDATA[Department code of employee]]>
        public string DepartmentCode { get; set; }

        ///<![CDATA[Description of department]]>
        public string DepartmentDescription { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Employee ID]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }

        ///<![CDATA[Numeric number of Employee]]>
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[Organization of employment]]>
        public Guid EmploymentOrganization { get; set; }

        ///<![CDATA[End date of employment]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 HID { get; set; }

        ///<![CDATA[Hourly wage]]>
        public double? HourlyWage { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Internal rate for time & billing or professional service user]]>
        public double? InternalRate { get; set; }

        ///<![CDATA[Job title of employee]]>
        public Guid Jobtitle { get; set; }

        ///<![CDATA[Description of job title]]>
        public string JobtitleDescription { get; set; }

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

        ///<![CDATA[Employment salary]]>
        public Guid Salary { get; set; }

        ///<![CDATA[Work schedule]]>
        public Guid Schedule { get; set; }

        ///<![CDATA[Average hours per week in a schedule.]]>
        public double? ScheduleAverageHours { get; set; }

        ///<![CDATA[Work schedule code]]>
        public string ScheduleCode { get; set; }

        ///<![CDATA[Number of days of work per week]]>
        public double? ScheduleDays { get; set; }

        ///<![CDATA[Description of work schedule]]>
        public string ScheduleDescription { get; set; }

        ///<![CDATA[Number of work hours per week.]]>
        public double? ScheduleHours { get; set; }

        ///<![CDATA[Start date of employment]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Start date of the employee in the organization. This field is used to count the years in service.]]>
        public DateTime StartDateOrganization { get; set; }
    }
}