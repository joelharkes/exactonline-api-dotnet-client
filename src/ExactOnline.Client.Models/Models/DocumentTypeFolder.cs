using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class DocumentTypeFolder
    {
        ///<![CDATA[Date created]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User id of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Folder to which document type is linked]]>
        public Guid DocumentFolder { get; set; }

        ///<![CDATA[Code of document type which is linked to folder]]>
        public Int32 DocumentType { get; set; }

        public Guid ID { get; set; }

        ///<![CDATA[Date Modified]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User id of modifier]]>
        public Guid Modifier { get; set; }
    }
}