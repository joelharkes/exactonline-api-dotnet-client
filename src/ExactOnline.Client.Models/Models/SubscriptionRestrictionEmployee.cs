using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, true)]
    [DataServiceKey("ID")]
    public class SubscriptionRestrictionEmployee
    {
        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Employee linked to the restriction]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Name of employee]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string EmployeeFullName { get; set; }

        ///<![CDATA[Readable ID of employee]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the last modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Reference to subscription]]>
        public Guid Subscription { get; set; }

        ///<![CDATA[Description of subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SubscriptionDescription { get; set; }

        ///<![CDATA[Number of subscription]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 SubscriptionNumber { get; set; }
    }
}