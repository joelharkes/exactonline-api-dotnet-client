using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Year,Period")]
    public class PeriodRevenue
    {
        ///<![CDATA[Total amount in the default currency of the company]]>
        public double Amount { get; set; }

        ///<![CDATA[Reporting period]]>
        public Int32 Period { get; set; }

        ///<![CDATA[Reporting year]]>
        public Int32 Year { get; set; }
    }
}