using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReasonCode
    {
        ///<![CDATA[Indicates if the reason code is active.]]>
        public byte? Active { get; set; }

        ///<![CDATA[Code of the reason.]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date.]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator.]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator.]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the reason code.]]>
        public string Description { get; set; }

        ///<![CDATA[Division code.]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key.]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date.]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier.]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier.]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Extra notes.]]>
        public string Notes { get; set; }

        ///<![CDATA[Type of the reason code.]]>
        public Int16 Type { get; set; }

        ///<![CDATA[Description of the type of the reason code.]]>
        public string TypeDescription { get; set; }
    }
}