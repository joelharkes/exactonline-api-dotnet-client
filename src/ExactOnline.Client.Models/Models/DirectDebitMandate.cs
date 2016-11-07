using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DirectDebitMandate
    {
        ///<![CDATA[Account the mandate belongs to]]>
        public Guid Account { get; set; }

        ///<![CDATA[Bank account the mandate applies to]]>
        public Guid BankAccount { get; set; }

        ///<![CDATA[Cancellation date]]>
        public DateTime CancellationDate { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Indicates the first collection hasn't been sent/confirmed with this mandate.]]>
        public byte? FirstSend { get; set; }

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

        ///<![CDATA[Payment type. 0 = one-off payment, 1 = recurrent payment, 2 = AdHoc (UK only)]]>
        public Int16 PaymentType { get; set; }

        ///<![CDATA[Reference]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Reference { get; set; }

        ///<![CDATA[Signature date]]>
        public DateTime SignatureDate { get; set; }

        ///<![CDATA[Type. 0 = core, 1 = B2B and 2 = bottomline (UK only)]]>
        public Int16 Type { get; set; }
    }
}