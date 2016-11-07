using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("ID")]
    public class MailMessageAttachment
    {
        ///<![CDATA[For performance reasons Attachment is Write-Only. The blob can be downloaded using the supplied Url]]>
        public byte[] Attachment { get; set; }

        ///<![CDATA[File extension of attachment]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AttachmentFileExtension { get; set; }

        ///<![CDATA[File name of attachment]]>
        public string AttachmentFileName { get; set; }

        ///<![CDATA[File size]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int64 FileSize { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference to Mail message]]>
        public Guid MailMessageID { get; set; }

        ///<![CDATA[Reference to recepient account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid RecipientAccount { get; set; }

        ///<![CDATA[Reference to sender account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid SenderAccount { get; set; }

        ///<![CDATA[Type of mail message attachment]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }

        ///<![CDATA[The blob can be downloaded through this url]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }
}