using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentAttachment
    {
        ///<![CDATA[Contains the attachment]]>
        public byte[] Attachment { get; set; }

        ///<![CDATA[Reference to the Document]]>
        public Guid Document { get; set; }

        ///<![CDATA[Filename of the attachment]]>
        public string FileName { get; set; }

        ///<![CDATA[File size of the attachment]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double FileSize { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Url of the attachment]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Url { get; set; }
    }
}