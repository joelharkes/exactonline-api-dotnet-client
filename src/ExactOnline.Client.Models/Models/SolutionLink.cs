using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SolutionLink
    {
        ///<![CDATA[ID of account to which solution is linked]]>
        public Guid Account { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Accountant main division]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)]]>
        public Int32 ExternalSolutionCode { get; set; }

        ///<![CDATA[Name of the external solution]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ExternalSolutionName { get; set; }

        ///<![CDATA[Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)]]>
        public string ExternalSolutionUrl { get; set; }

        ///<![CDATA[Primary key]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }

        ///<![CDATA[Division code of linked internal solution (mandatory for Internal solution)]]>
        public Int32 InternalSolutionDivision { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the solution link]]>
        public string Name { get; set; }

        ///<![CDATA[Name of the custom external solution (mandatory for ExternalOther solution)]]>
        public string OtherExternalSolutionName { get; set; }

        ///<![CDATA[Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther]]>
        public Int32 SolutionType { get; set; }

        ///<![CDATA[Link status: 0 - Active, 1 - Inactive, 2 -Archived]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Status { get; set; }
    }
}