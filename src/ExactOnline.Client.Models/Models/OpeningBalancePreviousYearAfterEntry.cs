using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Division,ReportingYear,GLAccount")]
    public class OpeningBalancePreviousYearAfterEntry
    {
        ///<![CDATA[The opening balance amount of the G/L account.]]>
        public double? Amount { get; set; }

        ///<![CDATA[Indicates whether the G/L account is a debit or credit account. D = Debit, C = Credit.]]>
        public string BalanceSide { get; set; }

        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }

        ///<![CDATA[The balance sheet account.]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[The code of the G/L account.]]>
        public string GLAccountCode { get; set; }

        ///<![CDATA[The description of the G/L account.]]>
        public string GLAccountDescription { get; set; }

        ///<![CDATA[The reporting year of the opening balance.]]>
        public Int32 ReportingYear { get; set; }
    }
}