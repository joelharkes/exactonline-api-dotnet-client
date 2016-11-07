using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Division
    {
        ///<![CDATA[values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed]]>
        public Int32 BlockingStatus { get; set; }

        ///<![CDATA[Primary key]]>
        public Int32 Code { get; set; }

        ///<![CDATA[Country of the division. Is used for determination of legislation]]>
        public string Country { get; set; }

        ///<![CDATA[Description of Country]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CountryDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Default currency of the division]]>
        public string Currency { get; set; }

        ///<![CDATA[Description of Currency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }

        ///<![CDATA[Owner account of the division]]>
        public Guid Customer { get; set; }

        ///<![CDATA[Owner account code of the division]]>
        public string CustomerCode { get; set; }

        ///<![CDATA[Owner account name of the division]]>
        public string CustomerName { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Number that customers give to the division]]>
        public Int64 HID { get; set; }

        ///<![CDATA[True for the main (hosting) division]]>
        public bool? Main { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Siret Number of the division (France)]]>
        public string SiretNumber { get; set; }

        ///<![CDATA[Date on which the division becomes active]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Regular administrations will have status 0.  Currently, the only other possibility is 'archived' (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Number of your local tax authority (Germany)]]>
        public string TaxOfficeNumber { get; set; }

        ///<![CDATA[Local tax reference number (Germany)]]>
        public string TaxReferenceNumber { get; set; }

        ///<![CDATA[VAT number]]>
        public string VATNumber { get; set; }

        ///<![CDATA[Customer value, hyperlink to external website]]>
        public string Website { get; set; }
    }
}