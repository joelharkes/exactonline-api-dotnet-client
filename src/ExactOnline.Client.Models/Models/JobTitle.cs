using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class JobTitle
    {
        ///<![CDATA[Job title code]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Job title description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Reference job code]]>
        public string JobCode { get; set; }

        ///<![CDATA[Group this job title belongs to]]>
        public Guid JobGroup { get; set; }

        ///<![CDATA[Job group code]]>
        public string JobGroupCode { get; set; }

        ///<![CDATA[Job group description]]>
        public string JobGroupDescription { get; set; }

        ///<![CDATA[Job title represents job level from]]>
        public Int32 JobLevelFrom { get; set; }

        ///<![CDATA[Job title represents job level to]]>
        public Int32 JobLevelTo { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
    }
}