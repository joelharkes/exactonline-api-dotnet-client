using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class AcceptedQuotation
    {
        ///<![CDATA[0 = No action, 1 = create sales order, 2 = create sales invoice, 3 = create project.]]>
        public Int32 Action { get; set; }

        ///<![CDATA[Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.]]>
        public bool? CreateProjectWBS { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Contains the error message if an error occurred during the acception of the quotation.]]>
        public string ErrorMessage { get; set; }

        ///<![CDATA[The journal in which the sales invoice will be booked. Only needed for Action = 2.]]>
        public Int32 InvoiceJournal { get; set; }

        ///<![CDATA[The budget type of the project that will be created.]]>
        public Int32 ProjectBudgetType { get; set; }

        ///<![CDATA[The code of the project that will be created.]]>
        public string ProjectCode { get; set; }

        ///<![CDATA[The description of the project that will be created.]]>
        public string ProjectDescription { get; set; }

        ///<![CDATA[The invoicing date of the project. Only needed for ProjectInvoicingAction = 2.]]>
        public DateTime ProjectInvoiceDate { get; set; }

        ///<![CDATA[The project invoicing action. 1 = Create invoice terms, 2 = As quoted.]]>
        public Int32 ProjectInvoicingAction { get; set; }

        ///<![CDATA[The prepaid type. Only needed for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.]]>
        public Int32 ProjectPrepaindTypes { get; set; }

        ///<![CDATA[PriceAgreement.]]>
        public double? ProjectPriceAgreement { get; set; }

        ///<![CDATA[Contains information if the project was successfully created.]]>
        public string ProjectSuccess { get; set; }

        ///<![CDATA[The type of the project that will be created. 2 = Fixed price, 3 = Time and Material, 4 = Non billable, 5 = Prepaid.]]>
        public Int32 ProjectType { get; set; }

        ///<![CDATA[Identifier of the quotation.]]>
        public Guid QuotationID { get; set; }

        ///<![CDATA[Reason why the quotation was accepted.]]>
        public Guid ReasonCode { get; set; }

        ///<![CDATA[Contains information if the sales invoice was successfully created.]]>
        public string SalesInvoiceSuccess { get; set; }

        ///<![CDATA[Contains information if the sales order was successfully created.]]>
        public string SalesOrderSuccess { get; set; }

        ///<![CDATA[Contains information if the quotation was successfully accepted.]]>
        public string SuccessMessage { get; set; }
    }
}