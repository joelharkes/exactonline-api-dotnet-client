using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("QuotationID")]
    public class Quotation
    {
        ///<![CDATA[Amount in the default currency of the company]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double AmountDC { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double AmountFC { get; set; }

        ///<![CDATA[Date on which the customer accepted or rejected the quotation version]]>
        public DateTime CloseDate { get; set; }

        ///<![CDATA[Date and time on which the quotation was created]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of the creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[The currency of the quotation]]>
        public string Currency { get; set; }

        ///<![CDATA[The account where the items should delivered]]>
        public Guid DeliveryAccount { get; set; }

        ///<![CDATA[The code of the delivery account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }

        ///<![CDATA[The contact person of the delivery account]]>
        public Guid DeliveryAccountContact { get; set; }

        ///<![CDATA[Full name of the delivery account contact person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountContactFullName { get; set; }

        ///<![CDATA[The name of the delivery account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }

        ///<![CDATA[The id of the delivery address]]>
        public Guid DeliveryAddress { get; set; }

        ///<![CDATA[The description of the quotation]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[The account to which the invoice is sent]]>
        public Guid InvoiceAccount { get; set; }

        ///<![CDATA[The code of the invoice account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }

        ///<![CDATA[The contact person of the invoice account]]>
        public Guid InvoiceAccountContact { get; set; }

        ///<![CDATA[Full name of the invoice account contact person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountContactFullName { get; set; }

        ///<![CDATA[The name of the invoice account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }

        ///<![CDATA[Date and time on which the quotation was last modified]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of the modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of the modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[The account that requested the quotation]]>
        public Guid OrderAccount { get; set; }

        ///<![CDATA[The code of the order account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderAccountCode { get; set; }

        ///<![CDATA[The contact person of the order account]]>
        public Guid OrderAccountContact { get; set; }

        ///<![CDATA[Full name of the order account contact person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderAccountContactFullName { get; set; }

        ///<![CDATA[The name of the order account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string OrderAccountName { get; set; }

        ///<![CDATA[Date on which the quotation version is entered or printed. Both during entering and printing this date can be adjusted]]>
        public DateTime QuotationDate { get; set; }

        ///<![CDATA[Identifier of the quotation]]>
        public Guid QuotationID { get; set; }

        ///<![CDATA[The collection of quotation lines]]>
        public IEnumerable<QuotationLine> QuotationLines { get; set; }

        ///<![CDATA[Unique number to indentify the quotation. By default this number is based on the setting for first available number]]>
        public Int32 QuotationNumber { get; set; }

        ///<![CDATA[Extra text that can be added to the quotation]]>
        public string Remarks { get; set; }

        ///<![CDATA[The user that is responsible for the quotation version]]>
        public Guid SalesPerson { get; set; }

        ///<![CDATA[Full name of the sales person]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesPersonFullName { get; set; }

        ///<![CDATA[The status of the quotation version. 5 = Rejected, 6 = Reviewed and closed, 10 = Recovery, 20 = Draft, 25 = Open, 35 = Processing... , 40 = Printed, 50 = Accepted]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }

        ///<![CDATA[The description of the status]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }

        ///<![CDATA[Total VAT amount in the currency of the transaction]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? VATAmountFC { get; set; }

        ///<![CDATA[Number indicating the different reviews which are made for the quotation]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 VersionNumber { get; set; }

        ///<![CDATA[The number by which this quotation is identified by the order account]]>
        public string YourRef { get; set; }
    }
}