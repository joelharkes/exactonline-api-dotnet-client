using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountInvolvedAccount
    {
        ///<![CDATA[ID of account]]>
        public Guid Account { get; set; }

        ///<![CDATA[Name of account]]>
        public string AccountName { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[ID of involved account]]>
        public Guid InvolvedAccount { get; set; }

        ///<![CDATA[Description of relation type]]>
        public string InvolvedAccountRelationTypeDescription { get; set; }

        ///<![CDATA[TermId of description of relation type]]>
        public Int32 InvolvedAccountRelationTypeDescriptionTermId { get; set; }

        ///<![CDATA[ID of relation type]]>
        public Int16 InvolvedAccountRelationTypeId { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Use to record details of important information]]>
        public string Notes { get; set; }
    }
}