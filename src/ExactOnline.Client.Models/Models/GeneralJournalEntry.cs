using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class GeneralJournalEntry
    {
        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Exchange rate]]>
        public double? ExchangeRate { get; set; }

        ///<![CDATA[Financial period]]>
        public Int16 FinancialPeriod { get; set; }

        ///<![CDATA[Financial year]]>
        public Int16 FinancialYear { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<GeneralJournalEntryLine> GeneralJournalEntryLines { get; set; }

        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }

        ///<![CDATA[Description of Journal]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[Indicates that amounts are reversed]]>
        public bool? Reversal { get; set; }

        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Type: 10 = Opening balance, 90 = Other]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }
}