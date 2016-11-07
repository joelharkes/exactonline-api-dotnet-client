using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("DocumentID")]
    public class TaxDocument
    {
        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? Amount { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[Currency]]>
        public string Currency { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Primary key, document ID]]>
        public Guid DocumentID { get; set; }

        ///<![CDATA[Url to view the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }

        ///<![CDATA[Due date]]>
        public DateTime DueDate { get; set; }

        ///<![CDATA[Frequency]]>
        public string Frequency { get; set; }

        ///<![CDATA[Payroll declaration type]]>
        public string PayrollDeclarationType { get; set; }

        ///<![CDATA[Period]]>
        public Int32 Period { get; set; }

        ///<![CDATA[Description of Period]]>
        public string PeriodDescription { get; set; }

        ///<![CDATA[Reference to request]]>
        public Guid Request { get; set; }

        ///<![CDATA[Status]]>
        public Int32 Status { get; set; }

        ///<![CDATA[Type]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Year]]>
        public Int32 Year { get; set; }
    }
}