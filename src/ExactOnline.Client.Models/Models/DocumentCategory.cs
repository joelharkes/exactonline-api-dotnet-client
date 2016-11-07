using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DocumentCategory
    {
        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[Document category description]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }
    }
}