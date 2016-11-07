using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingAmountsPayable
    {
        ///<![CDATA[Code of Account]]>
        public string AccountCode { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid AccountId { get; set; }

        ///<![CDATA[Name of Account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Age group 1]]>
        public Int32 AgeGroup1 { get; set; }

        ///<![CDATA[Amount of age group 1]]>
        public double AgeGroup1Amount { get; set; }

        ///<![CDATA[Description of AgeGroup1]]>
        public string AgeGroup1Description { get; set; }

        ///<![CDATA[Age group 2]]>
        public Int32 AgeGroup2 { get; set; }

        ///<![CDATA[Amount of age group 2]]>
        public double AgeGroup2Amount { get; set; }

        ///<![CDATA[Description of AgeGroup2]]>
        public string AgeGroup2Description { get; set; }

        ///<![CDATA[Age group 3]]>
        public Int32 AgeGroup3 { get; set; }

        ///<![CDATA[Amount of age group 3]]>
        public double AgeGroup3Amount { get; set; }

        ///<![CDATA[Description of AgeGroup3]]>
        public string AgeGroup3Description { get; set; }

        ///<![CDATA[Age group 4]]>
        public Int32 AgeGroup4 { get; set; }

        ///<![CDATA[Amount of age group 4]]>
        public double AgeGroup4Amount { get; set; }

        ///<![CDATA[Description of AgeGroup4]]>
        public string AgeGroup4Description { get; set; }

        ///<![CDATA[Code of Currency]]>
        public string CurrencyCode { get; set; }

        ///<![CDATA[Total amount of all age groups]]>
        public double TotalAmount { get; set; }
    }
}