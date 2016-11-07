using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Journal
    {
        ///<![CDATA[Indicates if the journal allows variable currency]]>
        public bool? AllowVariableCurrency { get; set; }

        ///<![CDATA[Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed]]>
        public bool? AllowVariableExchangeRate { get; set; }

        ///<![CDATA[Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals]]>
        public bool? AllowVAT { get; set; }

        ///<![CDATA[Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines]]>
        public bool? AutoSave { get; set; }

        ///<![CDATA[Reference to bank account]]>
        public Guid Bank { get; set; }

        ///<![CDATA[BIC code of the bank where the bank account is held]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankAccountBICCode { get; set; }

        ///<![CDATA[Country of bank account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankAccountCountry { get; set; }

        ///<![CDATA[Description of BankAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankAccountDescription { get; set; }

        ///<![CDATA[IBAN of the bank account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankAccountIBAN { get; set; }

        ///<![CDATA[Reference to the Bank Account linked to the Journal]]>
        public Guid BankAccountID { get; set; }

        ///<![CDATA[Bank account number. Is mandatory for Journals that have Type = Bank]]>
        public string BankAccountIncludingMask { get; set; }

        ///<![CDATA[Obsolete. Whether or not use SEPA for the bank account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSEPA { get; set; }

        ///<![CDATA[Obsolete. Whether or not use SEPA direct debit for the bank account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSepaDirectDebit { get; set; }

        ///<![CDATA[Name of bank account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }

        ///<![CDATA[Primary key]]>
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

        ///<![CDATA[Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used]]>
        public string Currency { get; set; }

        ///<![CDATA[Description of Currency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }

        ///<![CDATA[Name of the Journal]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Suspense general ledger account]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Code of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }

        ///<![CDATA[Description of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }

        ///<![CDATA[Type of GLAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 GLAccountType { get; set; }

        ///<![CDATA[Primary Key]]>
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

        ///<![CDATA[General ledger account for payment in transit]]>
        public Guid PaymentInTransitAccount { get; set; }

        ///<![CDATA[Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account]]>
        public string PaymentServiceAccountIdentifier { get; set; }

        ///<![CDATA[Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)]]>
        public Int32 PaymentServiceProvider { get; set; }

        ///<![CDATA[Name of the Payment service provider]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentServiceProviderName { get; set; }

        ///<![CDATA[Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)]]>
        public Int32 Type { get; set; }
    }
}