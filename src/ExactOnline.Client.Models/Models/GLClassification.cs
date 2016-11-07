using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLClassification
    {
        ///<![CDATA[Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents]]>
        public bool? Abstract { get; set; }

        ///<![CDATA[Only used for amount concepts: in that case either 'debit' or 'credit']]>
        public string Balance { get; set; }

        ///<![CDATA[The Code is unique]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes). For general taxonomies, the descriptions are stored in the TaxonomyLabels table]]>
        public string Description { get; set; }

        ///<![CDATA[Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Obsolete]]>
        public bool? IsTupleSubElement { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[The Name is unique in the namespace]]>
        public string Name { get; set; }

        ///<![CDATA[Determines whether usage of the element is mandatory in an instance document]]>
        public bool? Nillable { get; set; }

        ///<![CDATA[Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.]]>
        public Guid Parent { get; set; }

        ///<![CDATA[Only used for item concepts: either 'instant' or 'duration'. 'instant' is used for balance types of concepts, 'duration' is used for P&L types of concepts]]>
        public string PeriodType { get; set; }

        ///<![CDATA[Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item]]>
        public string SubstitutionGroup { get; set; }

        ///<![CDATA[Namespace of the element]]>
        public Guid TaxonomyNamespace { get; set; }

        ///<![CDATA[Description of TaxonomyNamespace]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TaxonomyNamespaceDescription { get; set; }

        ///<![CDATA[Type of the element]]>
        public Guid Type { get; set; }
    }
}