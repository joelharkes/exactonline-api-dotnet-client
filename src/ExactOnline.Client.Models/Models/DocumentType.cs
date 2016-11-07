using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentType
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[Document type description]]>
        public string Description { get; set; }

        ///<![CDATA[Indicates if documents of this type can be created]]>
        public bool DocumentIsCreatable { get; set; }

        ///<![CDATA[Indicates if documents of this type can be deleted]]>
        public bool DocumentIsDeletable { get; set; }

        ///<![CDATA[Indicates if documents of this type can be updated]]>
        public bool DocumentIsUpdatable { get; set; }

        ///<![CDATA[Indicates if documents of this type can be retrieved]]>
        public bool DocumentIsViewable { get; set; }

        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[ID of the document type category]]>
        public Int32 TypeCategory { get; set; }
    }
}