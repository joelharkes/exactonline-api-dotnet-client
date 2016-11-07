using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Currency
    {
        ///<![CDATA[Amount precision]]>
        public double AmountPrecision { get; set; }

        ///<![CDATA[Primary key]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[Description of the currency]]>
        public string Description { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[Price precision]]>
        public double PricePrecision { get; set; }
    }
}