using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountOwner
    {
        ///<![CDATA[ID of the account that is owned]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of the account that is owned]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of the account that is owned]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of the creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of the modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[ID of the account who owns specified account]]>
        public Guid OwnerAccount { get; set; }

        ///<![CDATA[Code of the account who owns specified account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OwnerAccountCode { get; set; }

        ///<![CDATA[Name of the account who owns specified account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OwnerAccountName { get; set; }

        ///<![CDATA[Percentage of shares that is owned. 1 is 100%, 0.5 is 50%]]>
        public double? Shares { get; set; }
    }
}