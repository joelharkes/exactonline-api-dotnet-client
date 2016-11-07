using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class CashEntry
    {
        ///<![CDATA[Collection of lines]]>
        public IEnumerable<CashEntryLine> CashEntryLines { get; set; }

        ///<![CDATA[Closing balance in the currency of the transaction]]>
        public double? ClosingBalanceFC { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Fiancial period]]>
        public Int16 FinancialPeriod { get; set; }

        ///<![CDATA[Fiancial year]]>
        public Int16 FinancialYear { get; set; }

        ///<![CDATA[Code of Journal]]>
        public string JournalCode { get; set; }

        ///<![CDATA[Description of Journal]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[Opening balance in the currency of the transaction]]>
        public double? OpeningBalanceFC { get; set; }

        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
    }
}