using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TaxScheduleComponent
    {
        ///<![CDATA[Account linked to the tax schedule]]>
        public Guid Account { get; set; }

        ///<![CDATA[Tax schedule code]]>
        public string Code { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Tax schedule description]]>
        public string Description { get; set; }

        ///<![CDATA[Division]]>
        public Int32 Division { get; set; }

        ///<![CDATA[GLAccount linked to the tax component]]>
        public Guid GLAccount { get; set; }

        ///<![CDATA[Primary Key]]>
        public Guid ID { get; set; }

        ///<![CDATA[The sequence in which the tax components are ordered]]>
        public Int32 LineNumber { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Notes]]>
        public string Notes { get; set; }

        ///<![CDATA[Id of the tax component]]>
        public Guid TaxComponent { get; set; }

        ///<![CDATA[Collection of Rates for this tax component]]>
        public IEnumerable<TaxComponentRate> TaxComponentRates { get; set; }

        ///<![CDATA[Tax schedule to which the tax component is linked]]>
        public Guid TaxSchedule { get; set; }
    }
}