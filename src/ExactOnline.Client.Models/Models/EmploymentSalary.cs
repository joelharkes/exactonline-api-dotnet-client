using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentSalary
    {
        ///<![CDATA[The average number of contract days that an employee works per week]]>
        public double? AverageDaysPerWeek { get; set; }

        ///<![CDATA[The average number of contract hours that an employee works per week]]>
        public double? AverageHoursPerWeek { get; set; }

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

        ///<![CDATA[Employee number]]>
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[Employment]]>
        public Guid Employment { get; set; }

        ///<![CDATA[Employment number]]>
        public Int32 EmploymentHID { get; set; }

        ///<![CDATA[Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)]]>
        public Int32 EmploymentSalaryType { get; set; }

        ///<![CDATA[Salary type description]]>
        public string EmploymentSalaryTypeDescription { get; set; }

        ///<![CDATA[Salary record end date]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Salary when working fulltime]]>
        public double? FulltimeAmount { get; set; }

        ///<![CDATA[Hourly wage]]>
        public double? HourlyWage { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Internal rate for time & billing or professional service user]]>
        public double? InternalRate { get; set; }

        ///<![CDATA[Employee job level in context of a wage scale]]>
        public Int32 JobLevel { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Salary when working parttime]]>
        public double? ParttimeAmount { get; set; }

        ///<![CDATA[Contract hours / Fulltime contract hours]]>
        public double? ParttimeFactor { get; set; }

        ///<![CDATA[Employee wage scale]]>
        public string Scale { get; set; }

        ///<![CDATA[Employment schedule]]>
        public Guid Schedule { get; set; }

        ///<![CDATA[Employment schedule code]]>
        public string ScheduleCode { get; set; }

        ///<![CDATA[Description of employment schedule]]>
        public string ScheduleDescription { get; set; }

        ///<![CDATA[Salary record start date]]>
        public DateTime StartDate { get; set; }
    }
}