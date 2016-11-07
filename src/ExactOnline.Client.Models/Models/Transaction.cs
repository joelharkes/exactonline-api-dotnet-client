using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("EntryID")]
    public class Transaction
    {
        ///<![CDATA[Closing balance in the currency of the transaction]]>
        public double? ClosingBalanceFC { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[Date]]>
        public DateTime Date { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid EntryID { get; set; }

        ///<![CDATA[Entry number]]>
        public Int32 EntryNumber { get; set; }

        ///<![CDATA[Financial period]]>
        public Int16 FinancialPeriod { get; set; }

        ///<![CDATA[Financial year]]>
        public Int16 FinancialYear { get; set; }

        ///<![CDATA[0 =  Financial entry without extra duty, 1 = Financial entry with extra duty]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? IsExtraDuty { get; set; }

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

        ///<![CDATA[Code of PaymentCondition]]>
        public string PaymentConditionCode { get; set; }

        ///<![CDATA[Description of PaymentCondition]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionDescription { get; set; }

        ///<![CDATA[Status: 5 = Rejected, 20 = Open, 50 = Processed]]>
        public Int16 Status { get; set; }

        ///<![CDATA[Description of Status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Collection of lines]]>
        public IEnumerable<TransactionLine> TransactionLines { get; set; }

        ///<![CDATA[The transaction type. 10 = Opening balance, 20 = Sales entry, 21 = Sales credit note, 22 = Return invoice sent, 30 = Purchase entry, 31 = Purchase credit note, 32 = Return invoice received, 40 = Cash flow, 50 = VAT return, 70 = Asset depreciation, 71 = Asset investment, 72 = Asset revaluation, 73 = Asset transfer, 74 = Asset split, 75 = Asset discontinue, 76 = Asset sales, 80 = Revaluation, 82 = Exchange rate difference, 83 = Payment difference, 84 = Deferred revenue, 85 = Tracking number:Revaluation, 86 = Deferred cost, 90 = Other, 120 = Delivery, 121 = Sales return, 130 = Receipt, 131 = Purchase return, 140 = Shop order stock receipt, 141 = Shop order stock reversal, 142 = Issue to parent, 145 = Shop order time entry, 146 = Shop order time entry reversal, 150 = Requirement issue, 151 = Requirement reversal, 152 = Returned from parent, 155 = Subcontract Issue, 156 = Subcontract reversal, 158 = Shop order completed, 162 = Finish assembly, 170 = Payroll, 180 = Stock revaluation, 195 = Stock count, 290 = Correction entry, 310 = Period closing, 320 = Year end reflection, 321 = Year end costing, 322 = Year end profits to gross profit, 323 = Year end costs to gross profit, 324 = Year end tax, 325 = Year end gross profit to net p/l, 326 = Year end net p/l to balance sheet, 327 = Year end closing balance, 328 = Year start opening balance, 3000 = Budget]]>
        public Int32 Type { get; set; }

        ///<![CDATA[The description of the transaction type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }
}