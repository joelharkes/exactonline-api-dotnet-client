using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentCosts
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }

        ///<![CDATA[Reference to Account]]>
        public Guid AccountId { get; set; }

        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Amount approved]]>
        public double AmountApproved { get; set; }

        ///<![CDATA[Amount draft]]>
        public double AmountDraft { get; set; }

        ///<![CDATA[Amount rejected]]>
        public double AmountRejected { get; set; }

        ///<![CDATA[Amount submitted]]>
        public double AmountSubmitted { get; set; }

        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }

        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Entry ID]]>
        public Guid EntryId { get; set; }

        ///<![CDATA[Reference to Expense]]>
        public Guid Expense { get; set; }

        ///<![CDATA[Description of Expense]]>
        public string ExpenseDescription { get; set; }

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

        ///<![CDATA[Quantity approved]]>
        public double QuantityApproved { get; set; }

        ///<![CDATA[Quantity draft]]>
        public double QuantityDraft { get; set; }

        ///<![CDATA[Quantity rejected]]>
        public double QuantityRejected { get; set; }

        ///<![CDATA[Quantity submitted]]>
        public double QuantitySubmitted { get; set; }

        ///<![CDATA[Week number]]>
        public Int32 WeekNumber { get; set; }
    }
}