using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Schedule
    {
        ///<![CDATA[Indicates if the schedule is active. 0 = Inactive, 1 = Active]]>
        public byte? Active { get; set; }

        ///<![CDATA[Average hours per week in a schedule]]>
        public double? AverageHours { get; set; }

        ///<![CDATA[Schedule code]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Average days per week in the schedule]]>
        public double? Days { get; set; }

        ///<![CDATA[Description of the schedule]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Employment ID for schedule]]>
        public Guid Employment { get; set; }

        ///<![CDATA[Employment number]]>
        public Int32 EmploymentHID { get; set; }

        ///<![CDATA[End date of the schedule]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Number of hours per week in a CLA for which the schedule is built]]>
        public double? Hours { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Number of hours which are built up each week for later leave]]>
        public double? LeaveHoursCompensation { get; set; }

        ///<![CDATA[Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No]]>
        public byte? Main { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Part-time factor for payroll calculation. value between 0 and 1]]>
        public double? PaymentParttimeFactor { get; set; }

        ///<![CDATA[Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day]]>
        public Int32 ScheduleType { get; set; }

        ///<![CDATA[Description of the schedule type]]>
        public string ScheduleTypeDescription { get; set; }

        ///<![CDATA[Week in the schedule which is used to start with. By default the number will be 1.]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Week to start the schedule from for an employee]]>
        public Int32 StartWeek { get; set; }
    }
}