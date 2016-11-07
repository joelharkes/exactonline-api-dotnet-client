using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Account
    {
        ///<![CDATA[Reference to the accountant of the customer. Conditions: The referred accountant must have value > 0 in the field IsAccountant]]>
        public Guid Accountant { get; set; }

        ///<![CDATA[ID of the account manager]]>
        public Guid AccountManager { get; set; }

        ///<![CDATA[Name of the account manager]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountManagerFullName { get; set; }

        ///<![CDATA[Number of the account manager  ]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 AccountManagerHID { get; set; }

        ///<![CDATA[Reference to Activity sector of the account]]>
        public Guid ActivitySector { get; set; }

        ///<![CDATA[Reference to Activity sub-sector of the account]]>
        public Guid ActivitySubSector { get; set; }

        ///<![CDATA[Visit address first line]]>
        public string AddressLine1 { get; set; }

        ///<![CDATA[Visit address second line]]>
        public string AddressLine2 { get; set; }

        ///<![CDATA[Visit address third line]]>
        public string AddressLine3 { get; set; }

        ///<![CDATA[Collection of Bank accounts]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public IEnumerable<BankAccount> BankAccounts { get; set; }

        ///<![CDATA[Indicates if the account is blocked]]>
        public bool? Blocked { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid BRIN { get; set; }

        ///<![CDATA[Reference to the business type of the account]]>
        public Guid BusinessType { get; set; }

        ///<![CDATA[Indicates the default for the possibility to drop ship when an item is linked to a supplier]]>
        public bool? CanDropShip { get; set; }

        ///<![CDATA[Chamber of commerce number]]>
        public string ChamberOfCommerce { get; set; }

        ///<![CDATA[Visit address City]]>
        public string City { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Classification { get; set; }

        ///<![CDATA[Account classification 1]]>
        public Guid Classification1 { get; set; }

        ///<![CDATA[Account classification 2]]>
        public Guid Classification2 { get; set; }

        ///<![CDATA[Account classification 3]]>
        public Guid Classification3 { get; set; }

        ///<![CDATA[Account classification 4]]>
        public Guid Classification4 { get; set; }

        ///<![CDATA[Account classification 5]]>
        public Guid Classification5 { get; set; }

        ///<![CDATA[Account classification 6]]>
        public Guid Classification6 { get; set; }

        ///<![CDATA[Account classification 7]]>
        public Guid Classification7 { get; set; }

        ///<![CDATA[Account classification 8]]>
        public Guid Classification8 { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ClassificationDescription { get; set; }

        ///<![CDATA[Unique key, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces]]>
        public string Code { get; set; }

        ///<![CDATA[Code under which your own company is known at the account]]>
        public string CodeAtSupplier { get; set; }

        ///<![CDATA[Reference to Company size of the account]]>
        public Guid CompanySize { get; set; }

        ///<![CDATA[Consolidation scenario (Time & Billing). values: 0 = No consolidation, 1 = Item, 2 = Item + Project, 3 = Item + Employee, 4 = Item + Employee + Project. Item means in this case including Unit and Price, these also have to be the same to consolidate]]>
        public byte? ConsolidationScenario { get; set; }

        ///<![CDATA[Date of the latest control of account data with external web service]]>
        public DateTime ControlledDate { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Costcenter { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public byte CostPaid { get; set; }

        ///<![CDATA[Country code]]>
        public string Country { get; set; }

        ///<![CDATA[Country name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CountryName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Maximum amount of credit for Purchase. If no value has been defined, there is no credit limit]]>
        public double? CreditLinePurchase { get; set; }

        ///<![CDATA[Maximum amount of credit for sales. If no value has been defined, there is no credit limit]]>
        public double? CreditLineSales { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Currency { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime CustomerSince { get; set; }

        ///<![CDATA[DATEV creditor code for Germany legislation]]>
        public string DatevCreditorCode { get; set; }

        ///<![CDATA[DATEV debtor code for Germany legislation]]>
        public string DatevDebtorCode { get; set; }

        ///<![CDATA[Default discount percentage for purchase. This is stored as a fraction. ie 5.5% is stored as .055]]>
        public double? DiscountPurchase { get; set; }

        ///<![CDATA[Default discount percentage for sales. This is stored as a fraction. ie 5.5% is stored as .055]]>
        public double? DiscountSales { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Document { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DunsNumber { get; set; }

        ///<![CDATA[E-Mail address of the account]]>
        public string Email { get; set; }

        ///<![CDATA[Determines in combination with the start date if the account is active. If the current date is > end date the account is inactive]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[RegistrationDate]]>
        public DateTime EstablishedDate { get; set; }

        ///<![CDATA[Fax number]]>
        public string Fax { get; set; }

        ///<![CDATA[Default (corporate) GL offset account for purchase (cost)]]>
        public Guid GLAccountPurchase { get; set; }

        ///<![CDATA[Default (corporate) GL offset account for sales (revenue)]]>
        public Guid GLAccountSales { get; set; }

        ///<![CDATA[Default GL account for Accounts Payable]]>
        public Guid GLAP { get; set; }

        ///<![CDATA[Default GL account for Accounts Receivable]]>
        public Guid GLAR { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Suppressed warning message when there is duplication on the DATEV code]]>
        public bool IgnoreDatevWarningMessage { get; set; }

        ///<![CDATA[Intrastat Area]]>
        public string IntraStatArea { get; set; }

        ///<![CDATA[Intrastat delivery method]]>
        public string IntraStatDeliveryTerm { get; set; }

        ///<![CDATA[System for Intrastat]]>
        public string IntraStatSystem { get; set; }

        ///<![CDATA[Transaction type A for Intrastat]]>
        public string IntraStatTransactionA { get; set; }

        ///<![CDATA[Transaction type B for Intrastat]]>
        public string IntraStatTransactionB { get; set; }

        ///<![CDATA[Transport method for Intrastat]]>
        public string IntraStatTransportMethod { get; set; }

        ///<![CDATA[ID of account to be invoiced instead of this account]]>
        public Guid InvoiceAccount { get; set; }

        ///<![CDATA[Code of InvoiceAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountCode { get; set; }

        ///<![CDATA[Name of InvoiceAccount]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string InvoiceAccountName { get; set; }

        ///<![CDATA[Indicates which attachment types should be sent when a sales invoice is printed. Only values in related table with Invoice=1 are allowed]]>
        public Int32 InvoiceAttachmentType { get; set; }

        ///<![CDATA[Method of sending for sales invoices. values: 1: Paper, 2: EMail, 4: Mailbox (electronic exchange)]]>
        public Int32 InvoicingMethod { get; set; }

        ///<![CDATA[Indicates whether the account is an accountant. values: 0 = No accountant, 1 = True, but accountant doesn't want his name to be published in the list of accountants, 2 = True, and accountant is published in the list of accountants]]>
        public byte IsAccountant { get; set; }

        ///<![CDATA[Indicates whether the accounti is an agency]]>
        public byte IsAgency { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? IsBank { get; set; }

        ///<![CDATA[Indicates whether the account is a competitor]]>
        public byte IsCompetitor { get; set; }

        ///<![CDATA[Indicates whether a customer is eligible for extra duty]]>
        public bool? IsExtraDuty { get; set; }

        ///<![CDATA[Indicates if the account is excluded from mailing marketing information]]>
        public byte IsMailing { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? IsMember { get; set; }

        ///<![CDATA[Indicates whether the account is a pilot account]]>
        public bool? IsPilot { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? IsPurchase { get; set; }

        ///<![CDATA[Indicates whether the account is a reseller]]>
        public bool? IsReseller { get; set; }

        ///<![CDATA[Indicates whether the account is allowed for sales]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool? IsSales { get; set; }

        ///<![CDATA[Indicates whether the account is a supplier]]>
        public bool? IsSupplier { get; set; }

        ///<![CDATA[Language code]]>
        public string Language { get; set; }

        ///<![CDATA[Language description]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string LanguageDescription { get; set; }

        ///<![CDATA[Latitude (used by Google maps)]]>
        public double? Latitude { get; set; }

        ///<![CDATA[Reference to Lead source of an account]]>
        public Guid LeadSource { get; set; }

        ///<![CDATA[Bytes of the logo image]]>
        public byte[] Logo { get; set; }

        ///<![CDATA[The file name (without path, but with extension) of the image]]>
        public string LogoFileName { get; set; }

        ///<![CDATA[Thumbnail url of the logo]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string LogoThumbnailUrl { get; set; }

        ///<![CDATA[Url to retrieve the logo]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string LogoUrl { get; set; }

        ///<![CDATA[Longitude (used by Google maps)]]>
        public double? Longitude { get; set; }

        ///<![CDATA[Reference to main contact person]]>
        public Guid MainContact { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Account name]]>
        public string Name { get; set; }

        ///<![CDATA[ID of the parent account]]>
        public Guid Parent { get; set; }

        ///<![CDATA[Indicates the loan repayment plan for UK legislation]]>
        public string PayAsYouEarn { get; set; }

        ///<![CDATA[Code of default payment condition for purchase]]>
        public string PaymentConditionPurchase { get; set; }

        ///<![CDATA[Description of PaymentConditionPurchase]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionPurchaseDescription { get; set; }

        ///<![CDATA[Code of default payment condition for sales]]>
        public string PaymentConditionSales { get; set; }

        ///<![CDATA[Description of PaymentConditionSales]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PaymentConditionSalesDescription { get; set; }

        ///<![CDATA[Phone number]]>
        public string Phone { get; set; }

        ///<![CDATA[Phone number extention]]>
        public string PhoneExtension { get; set; }

        ///<![CDATA[Visit address postcode]]>
        public string Postcode { get; set; }

        ///<![CDATA[Default sales price list for account]]>
        public Guid PriceList { get; set; }

        ///<![CDATA[Currency of purchase]]>
        public string PurchaseCurrency { get; set; }

        ///<![CDATA[Description of PurchaseCurrency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PurchaseCurrencyDescription { get; set; }

        ///<![CDATA[Indicates number of days required to receive a purchase. Acts as a default]]>
        public Int32 PurchaseLeadDays { get; set; }

        ///<![CDATA[Default VAT code used for purchase entries]]>
        public string PurchaseVATCode { get; set; }

        ///<![CDATA[Description of PurchaseVATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string PurchaseVATCodeDescription { get; set; }

        ///<![CDATA[Define the relation that should be taken in the official document of the rewarding fiscal fiches Belcotax]]>
        public bool? RecepientOfCommissions { get; set; }

        ///<![CDATA[Remarks]]>
        public string Remarks { get; set; }

        ///<![CDATA[ID of the reseller account. Conditions: the target account must have the property IsReseller turned on]]>
        public Guid Reseller { get; set; }

        ///<![CDATA[Code of Reseller]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ResellerCode { get; set; }

        ///<![CDATA[Name of Reseller]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ResellerName { get; set; }

        ///<![CDATA[Fiscal number for NL legislation]]>
        public string RSIN { get; set; }

        ///<![CDATA[Currency of Sales used for Time & Billing]]>
        public string SalesCurrency { get; set; }

        ///<![CDATA[Description of SalesCurrency]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesCurrencyDescription { get; set; }

        ///<![CDATA[Default tax schedule when creating sales orders or sales invoices]]>
        public Guid SalesTaxSchedule { get; set; }

        ///<![CDATA[Code of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleCode { get; set; }

        ///<![CDATA[Description of the tax schedule]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesTaxScheduleDescription { get; set; }

        ///<![CDATA[Default VAT code for a sales entry]]>
        public string SalesVATCode { get; set; }

        ///<![CDATA[Description of SalesVATCode]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string SalesVATCodeDescription { get; set; }

        ///<![CDATA[Search code]]>
        public string SearchCode { get; set; }

        ///<![CDATA[Security level (0 - 100)]]>
        public Int32 SecurityLevel { get; set; }

        ///<![CDATA[Separate invoice per project (Time & Billing)]]>
        public byte SeparateInvPerProject { get; set; }

        ///<![CDATA[Indicates how invoices are generated from subscriptions. 0 = subscriptions belonging to the same customer are combined in a single invoice. 1 = each subscription results in one invoice. In both cases, each individual subscription line results in one invoice line]]>
        public byte SeparateInvPerSubscription { get; set; }

        ///<![CDATA[Indicates the number of days it takes to send goods to the customer. Acts as a default]]>
        public Int32 ShippingLeadDays { get; set; }

        ///<![CDATA[Default shipping method]]>
        public Guid ShippingMethod { get; set; }

        ///<![CDATA[Indicates in combination with the end date if the account is active]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[State/Province code]]>
        public string State { get; set; }

        ///<![CDATA[Name of State]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string StateName { get; set; }

        ///<![CDATA[If the status field is filled this means the account is a customer. The value indicates the customer status. Possible values: A=None, S=Suspect, P=Prospect, C=Customer]]>
        public string Status { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime StatusSince { get; set; }

        ///<![CDATA[Trade name can be registered and shown with the client (for all legislations)]]>
        public string TradeName { get; set; }

        ///<![CDATA[Account type: values: A = Relation, D = Division]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Type { get; set; }

        ///<![CDATA[Unique taxpayer reference for UK legislation]]>
        public string UniqueTaxpayerReference { get; set; }

        ///<![CDATA[Indicates the VAT status of an account to be able to identify the relation that should be selected in the VAT debtor listing in Belgium]]>
        public string VATLiability { get; set; }

        ///<![CDATA[The number under which the account is known at the value Added Tax collection agency]]>
        public string VATNumber { get; set; }

        ///<![CDATA[Website of the account]]>
        public string Website { get; set; }
    }
}