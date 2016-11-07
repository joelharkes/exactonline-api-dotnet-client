using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProductionArea
    {
        ///<![CDATA[Code of the production area group]]>
        public string Code { get; set; }

        ///<![CDATA[Reference to Cost center]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Description of Costcenter]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Reference to Cost unit]]>
        public string Costunit { get; set; }

        ///<![CDATA[Description of Costunit]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the production area]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if this is the default production area. This will be used when creating a new production area]]>
        public byte IsDefault { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Production area notes]]>
        public string Notes { get; set; }
    }
}