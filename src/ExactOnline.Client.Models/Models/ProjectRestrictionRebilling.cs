using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionRebilling
    {
        ///<![CDATA[Cost type reference]]>
        public Guid CostTypeRebill { get; set; }

        ///<![CDATA[Cost type code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillCode { get; set; }

        ///<![CDATA[Cost type description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostTypeRebillDescription { get; set; }

        ///<![CDATA[Date created]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[Creator user ID]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Creator name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Date modified]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[Modifier user ID]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Modifier name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Project linked to the restriction]]>
        public Guid Project { get; set; }

        ///<![CDATA[Project code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        ///<![CDATA[Project description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }
    }
}