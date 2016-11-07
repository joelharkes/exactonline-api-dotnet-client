using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Year,Period,Journal")]
    public class JournalStatus
    {
        ///<![CDATA[Reference to Journal]]>
        public string Journal { get; set; }

        ///<![CDATA[Description of Journal]]>
        public string JournalDescription { get; set; }

        ///<![CDATA[Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal]]>
        public Int32 JournalType { get; set; }

        ///<![CDATA[Description of JournalType]]>
        public string JournalTypeDescription { get; set; }

        ///<![CDATA[Financial period]]>
        public Int32 Period { get; set; }

        ///<![CDATA[Journal status for this year and period 0=open, 1=closed]]>
        public Int32 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        public string StatusDescription { get; set; }

        ///<![CDATA[Financial year]]>
        public Int32 Year { get; set; }
    }
}