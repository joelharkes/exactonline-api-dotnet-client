using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentHours
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }

        ///<![CDATA[Reference to Account]]>
        public Guid AccountId { get; set; }

        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Reference to Activity]]>
        public Guid Activity { get; set; }

        ///<![CDATA[Description of Activity]]>
        public string ActivityDescription { get; set; }

        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Entry ID]]>
        public Guid EntryId { get; set; }

        ///<![CDATA[Hours approved]]>
        public double HoursApproved { get; set; }

        ///<![CDATA[Billable hours approved]]>
        public double HoursApprovedBillable { get; set; }

        ///<![CDATA[Hours draft]]>
        public double HoursDraft { get; set; }

        ///<![CDATA[Billable hours draft]]>
        public double HoursDraftBillable { get; set; }

        ///<![CDATA[Hours rejected]]>
        public double HoursRejected { get; set; }

        ///<![CDATA[Billable hours rejected]]>
        public double HoursRejectedBillable { get; set; }

        ///<![CDATA[Hours submitted]]>
        public double HoursSubmitted { get; set; }

        ///<![CDATA[Billable hours submitted]]>
        public double HoursSubmittedBillable { get; set; }

        ///<![CDATA[Primary key]]>
        public Int32 Id { get; set; }

        ///<![CDATA[Code of Item]]>
        public string ItemCode { get; set; }

        ///<![CDATA[Description of Item]]>
        public string ItemDescription { get; set; }

        ///<![CDATA[Reference to Item]]>
        public Guid ItemId { get; set; }

        ///<![CDATA[Remarks]]>
        public string Notes { get; set; }

        ///<![CDATA[Code of Project]]>
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of Project]]>
        public string ProjectDescription { get; set; }

        ///<![CDATA[Reference to Project]]>
        public Guid ProjectId { get; set; }

        ///<![CDATA[Week number]]>
        public Int32 WeekNumber { get; set; }
    }
}