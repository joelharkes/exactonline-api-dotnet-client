using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentTypeCategory
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[Document category type description]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Int32 ID { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
    }
}