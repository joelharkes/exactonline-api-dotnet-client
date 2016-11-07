using System;
using Newtonsoft.Json;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Mailbox
    {
        ///<![CDATA[The account this mailbox belongs to. Can be empty if the owner of the mailbox isn't an Exact Online customer yet]]>
        public Guid Account { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Extra description of the mailbox]]>
        public string Description { get; set; }

        ///<![CDATA[Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration]]>
        public Int32 ForDivision { get; set; }

        ///<![CDATA[Description of ForDivision]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ForDivisionDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[E-mail address-like format, for example johndoe@exactonline.nl]]>
        [JsonProperty(PropertyName = "Mailbox")]
        public string Mailbox_1 { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact]]>
        public byte Publish { get; set; }

        ///<![CDATA[Type of mailbox. Exact / Government / Manual]]>
        public Int16 Type { get; set; }

        ///<![CDATA[Date that this mailbox became valid]]>
        public DateTime ValidFrom { get; set; }

        ///<![CDATA[Date that this mailbox will not be valid anymore]]>
        public DateTime ValidTo { get; set; }
    }
}