using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PaymentCondition
    {
        ///<![CDATA[Code of the payment condition]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Default credit management scenario to be used for new payment terms]]>
        public Guid CreditManagementScenario { get; set; }

        ///<![CDATA[Code of CreditManagementScenario]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioCode { get; set; }

        ///<![CDATA[Description of CreditManagementScenario]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioDescription { get; set; }

        ///<![CDATA[Description of the payment condition]]>
        public string Description { get; set; }

        ///<![CDATA[Indicates how the discount amount is calculated. values: E = Excluding VAT, I = Including VAT]]>
        public string DiscountCalculation { get; set; }

        ///<![CDATA[Number of days to pay within, to have the right to take the discount]]>
        public Int32 DiscountPaymentDays { get; set; }

        ///<![CDATA[Discount percentage]]>
        public double? DiscountPercentage { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 => 31/03 PaymentDays = 15 => 15/04]]>
        public Int32 PaymentDays { get; set; }

        ///<![CDATA[Type of payment discount. values: B = Settlement discount, K = Credit surcharge]]>
        public string PaymentDiscountType { get; set; }

        ///<![CDATA[Number of month endings to be included in the due date calculation]]>
        public Int32 PaymentEndOfMonths { get; set; }

        ///<![CDATA[Method of payment. values: B = On credit, I = Collection, K = Cash]]>
        public string PaymentMethod { get; set; }

        ///<![CDATA[Percentage (stored as fraction) of total invoice amount]]>
        public double? Percentage { get; set; }

        ///<![CDATA[Indicates how the VAT amount is calculated values: E = Excluding discount, I = Including discount]]>
        public string VATCalculation { get; set; }
    }
}