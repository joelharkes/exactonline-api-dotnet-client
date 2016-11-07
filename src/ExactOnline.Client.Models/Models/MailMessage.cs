using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessage
    {
        ///<![CDATA[Bank to/from which the mail message is sent/received. This is used for mail messages of type Bank only. It has an attachment containing the bank file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
        public Guid Bank { get; set; }

        ///<![CDATA[Bank account for which the mail message is sent. This is used for mail messages of type Bank only. It has an attachment containing the bank export file. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
        public string BankAccount { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Administration from which the mail message is sent. This is used for mail messages of type Bank only. When used for a mail message of type bank, the value is reserved for internal use and will then be ignored.]]>
        public Int32 ForDivision { get; set; }

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

        ///<![CDATA[Specifies the operation upon dealing with the mailmessage (Kirean scan service)]]>
        public Int16 Operation { get; set; }

        ///<![CDATA[Provides a link to another MailMessage (Kirean scan service)]]>
        public Guid OriginalMessage { get; set; }

        ///<![CDATA[Subject of the OriginalMessage]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OriginalMessageSubject { get; set; }

        ///<![CDATA[The partner key that was used: this refers to the application from which the message is originating. It is filled with a fixed partnerkey when created from within Exact Online]]>
        public Guid PartnerKey { get; set; }

        ///<![CDATA[Specifies the number of lines of the returned MailMessage attachment (Kirean scan service)]]>
        public double? Quantity { get; set; }

        ///<![CDATA[Reference to the account that is receiving this mailmessage]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid RecipientAccount { get; set; }

        ///<![CDATA[Indiciates if the recipient deleted this message. If this is the case the recipient can't see it anymore and the sender can actually delete it]]>
        public byte RecipientDeleted { get; set; }

        ///<![CDATA[Mailbox of recipient]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string RecipientMailbox { get; set; }

        ///<![CDATA[Mailbox description of recipient]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string RecipientMailboxDescription { get; set; }

        ///<![CDATA[Mailbox ID of the recipient. The owner of this mailbox will see the message in the inbox]]>
        public Guid RecipientMailboxID { get; set; }

        ///<![CDATA[Status of the mail message, only the recipient can update this]]>
        public Int16 RecipientStatus { get; set; }

        ///<![CDATA[Description of RecipientStatus]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string RecipientStatusDescription { get; set; }

        ///<![CDATA[Reference to Account of Sender]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SenderAccount { get; set; }

        ///<![CDATA[Date the message was sent. Default the date the message is created, can be an earlier date when imported from xml (the date the xml was sent)]]>
        public DateTime SenderDateSent { get; set; }

        ///<![CDATA[Indicates if the sender deleted the message. This means the sender can't see it anymore and the recipient can actually delete it]]>
        public byte SenderDeleted { get; set; }

        ///<![CDATA[IP address of the sender]]>
        public string SenderIPAddress { get; set; }

        ///<![CDATA[Mailbox of sender]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SenderMailbox { get; set; }

        ///<![CDATA[Description of SenderMailbox]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SenderMailboxDescription { get; set; }

        ///<![CDATA[Mailbox ID of the sender. The owner of this mailbox will see the message in the sent items]]>
        public Guid SenderMailboxID { get; set; }

        ///<![CDATA[Subject of the mail message]]>
        public string Subject { get; set; }

        ///<![CDATA[Provides a link between Exact Online and the banks]]>
        public string SynchronizationCode { get; set; }

        ///<![CDATA[Type of the mail message]]>
        public Int32 Type { get; set; }
    }
}