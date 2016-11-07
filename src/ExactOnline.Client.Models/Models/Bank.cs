using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Bank
    {
        ///<![CDATA[The name of the bank]]>
        public string BankName { get; set; }

        ///<![CDATA[The bank identification code of the bank]]>
        public string BICCode { get; set; }

        ///<![CDATA[The country in which the bank is based]]>
        public string Country { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[The extended description of the bank]]>
        public string Description { get; set; }

        ///<![CDATA[The account format used by the bank]]>
        public string Format { get; set; }

        ///<![CDATA[The website of the bank]]>
        public string HomePageAddress { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[The status of the bank. A = Active, P = Passive]]>
        public string Status { get; set; }
    }
}