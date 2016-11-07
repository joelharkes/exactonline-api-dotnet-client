using System;
using Newtonsoft.Json;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BankAccount
    {
        ///<![CDATA[Account (customer, supplier) to which the bank account belongs]]>
        public Guid Account { get; set; }

        ///<![CDATA[The name of the account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Bank { get; set; }

        ///<![CDATA[The bank account number]]>
        [JsonProperty(PropertyName = "BankAccount")]
        public string BankAccount_1 { get; set; }

        ///<![CDATA[Name of the holder of the bank account, as known by the bank]]>
        public string BankAccountHolderName { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankDescription { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }

        ///<![CDATA[BIC code of the bank where the bank account is held]]>
        public string BICCode { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the bank account]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Format that belongs to the bank account number]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Format { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string IBAN { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if the bank account is the main bank account]]>
        public bool? Main { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[ID of the Payment service account. Used when Type is 'P' (Payment service)]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid PaymentServiceAccount { get; set; }

        ///<![CDATA[The type indicates what entity the bank account is used for. A = Account (default), E = Employee, K = Cash, P = Payment service, R = Bank, S = Student, U = Unknown. Currently it's only possible to create 'Account' type bank accounts.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }

        ///<![CDATA[Description of the Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }
}