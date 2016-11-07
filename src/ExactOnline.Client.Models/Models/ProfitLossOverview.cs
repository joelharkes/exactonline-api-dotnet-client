using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("CurrentYear")]
    public class ProfitLossOverview
    {
        ///<![CDATA[Costs in current period]]>
        public double CostsCurrentPeriod { get; set; }

        ///<![CDATA[Costs in current year]]>
        public double CostsCurrentYear { get; set; }

        ///<![CDATA[Costs in previous year]]>
        public double CostsPreviousYear { get; set; }

        ///<![CDATA[Costs in period of previous year]]>
        public double CostsPreviousYearPeriod { get; set; }

        ///<![CDATA[Currency code]]>
        public string CurrencyCode { get; set; }

        ///<![CDATA[Current period]]>
        public Int32 CurrentPeriod { get; set; }

        ///<![CDATA[Primary key, Current year]]>
        public Int32 CurrentYear { get; set; }

        ///<![CDATA[Previous year]]>
        public Int32 PreviousYear { get; set; }

        ///<![CDATA[Period in previous year]]>
        public Int32 PreviousYearPeriod { get; set; }

        ///<![CDATA[Results of current period]]>
        public double ResultCurrentPeriod { get; set; }

        public double ResultCurrentYear { get; set; }

        public double ResultPreviousYear { get; set; }

        ///<![CDATA[Results of period in previous year]]>
        public double ResultPreviousYearPeriod { get; set; }

        ///<![CDATA[Revenue in current period]]>
        public double RevenueCurrentPeriod { get; set; }

        ///<![CDATA[Revenue in current year]]>
        public double RevenueCurrentYear { get; set; }

        ///<![CDATA[Revenue in previous year]]>
        public double RevenuePreviousYear { get; set; }

        ///<![CDATA[Revenue in period of previous year]]>
        public double RevenuePreviousYearPeriod { get; set; }
    }
}