using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReportingBalance
    {
        ///<![CDATA[The sum of the amounts of all transactions in the grouping.]]>
        public double? Amount { get; set; }

        ///<![CDATA[The sum of the amounts of all credit transactions in the grouping.]]>
        public double? AmountCredit { get; set; }

        ///<![CDATA[The sum of the amounts of all debit transactions in the grouping.]]>
        public double? AmountDebit { get; set; }

        ///<![CDATA[Balance type of the G/L account: B = Balance Sheet, W = Profit & Loss.]]>
        public string BalanceType { get; set; }

        ///<![CDATA[The code of the cost center.]]>
        public string CostCenterCode { get; set; }

        ///<![CDATA[The description of the cost center.]]>
        public string CostCenterDescription { get; set; }

        ///<![CDATA[The code of the cost unit.]]>
        public string CostUnitCode { get; set; }

        ///<![CDATA[The description of the cost unit.]]>
        public string CostUnitDescription { get; set; }

        ///<![CDATA[The number of transactions in the grouping.]]>
        public Int32 Count { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[G/L account]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }

        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Record ID]]>
        public Int64 ID { get; set; }

        ///<![CDATA[The reporting period of the transactions in the grouping.]]>
        public Int32 ReportingPeriod { get; set; }

        ///<![CDATA[The reporting year of the transactions in the grouping.]]>
        public Int32 ReportingYear { get; set; }

        ///<![CDATA[Status: 20 = Open, 50 = Processed. To get 'after entry' results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.]]>
        public Int32 Status { get; set; }

        ///<![CDATA[The type of the transactions in the grouping.]]>
        public Int32 Type { get; set; }
    }
}