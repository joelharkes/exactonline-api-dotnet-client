using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("AgeGroup")]
    public class AgingOverview
    {
        ///<![CDATA[Primary key]]>
        public Int32 AgeGroup { get; set; }

        ///<![CDATA[Description of AgeGroup]]>
        public string AgeGroupDescription { get; set; }

        ///<![CDATA[Amount payable]]>
        public double AmountPayable { get; set; }

        ///<![CDATA[Amount receivable]]>
        public double AmountReceivable { get; set; }

        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }
    }
}