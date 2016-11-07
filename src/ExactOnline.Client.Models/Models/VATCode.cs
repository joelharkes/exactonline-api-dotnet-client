using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class VATCode
    {
        ///<![CDATA[Tax account]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Indicates how to calculate the tax. 0 = based on the gross amount, 1 = based on the gross amount + another tax]]>
        public byte? CalculationBasis { get; set; }

        ///<![CDATA[Indicates if transactions using the VAT code are transactions of the domestic VAT charging regulation (such as those for subcontractors) or transactions that are registered within the EU. If Charged=1 and linked to a purchase invoice, both a line for the VAT to pay and a line for the VAT to claim are being created]]>
        public bool? Charged { get; set; }

        ///<![CDATA[VAT code]]>
        public string Code { get; set; }

        ///<![CDATA[Obsolete]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }

        ///<![CDATA[Description of the VAT code]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Indicates if and how transactions using the VAT code appear on the ICT return (EU sales list). L = Listing goods, N = No listing, S = Listing services, T = Triangulation]]>
        public string EUSalesListing { get; set; }

        ///<![CDATA[Indicates the purchase discount GL account linked to the VAT codes for German legislation]]>
        public Guid GLDiscountPurchase { get; set; }

        ///<![CDATA[Code of GLDiscountPurchase]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseCode { get; set; }

        ///<![CDATA[Description of GLDiscountPurchase]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseDescription { get; set; }

        ///<![CDATA[Indicates the sales discount GL account linked to the VAT codes for German legislation]]>
        public Guid GLDiscountSales { get; set; }

        ///<![CDATA[Code of GLDiscountSales]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesCode { get; set; }

        ///<![CDATA[Description of GLDiscountSales]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesDescription { get; set; }

        ///<![CDATA[G/L account that is used to book the VAT to claim. If you enter purchases with a VAT code, the VAT amount to be claimed is entered to this VAT account. Must be of type VAT]]>
        public Guid GLToClaim { get; set; }

        ///<![CDATA[Code of GLToClaim]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLToClaimCode { get; set; }

        ///<![CDATA[Description of GLToClaim]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLToClaimDescription { get; set; }

        ///<![CDATA[G/L account that is used to book the VAT to pay. If you enter sales with a VAT code, the VAT amount to be paid is entered to this VAT account. Must be of type VAT]]>
        public Guid GLToPay { get; set; }

        ///<![CDATA[Code of GLToPay]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLToPayCode { get; set; }

        ///<![CDATA[Description of GLToPay]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string GLToPayDescription { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates if intrastat is used]]>
        public bool? IntraStat { get; set; }

        ///<![CDATA[Indicates if the VAT code may still be used]]>
        public bool? IsBlocked { get; set; }

        ///<![CDATA[Legal description for VAT code to print in the total block of the invoice]]>
        public string LegalText { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[User name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[Percentage of the VAT code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }

        ///<![CDATA[Indicates what type of Taxcode it is: can be VAT, IncomeTax]]>
        public Int16 TaxReturnType { get; set; }

        ///<![CDATA[Indicates how the VAT amount should be calculated in relation to the invoice amount. B = VAT 0% (Only base amount), E = Excluding, I = Including, N = No VAT]]>
        public string Type { get; set; }

        ///<![CDATA[Field in VAT code maintenance to calculate different VATs depending on the selected document type. P = purchase invoice, F = freelance invoice, E = expense voucher. The field is valid for witholding tax type]]>
        public string VatDocType { get; set; }

        ///<![CDATA[The VAT margin scheme is used for the trade of secondhand goods which are purchased without VAT (for example when a company buys a secondhand good from a private person). In the VAT margin scheme, the VAT is not calculated based on the sales price. Instead of that, the VAT is calculated based on the margin (gross sales price minus the gross purchase price)]]>
        public byte VatMargin { get; set; }

        ///<![CDATA[Partial ratio explains which part of the VAT the company has to pay. Used in some branches where the sellers have a bad reputation, so the buyers have to take over the VAT-liability]]>
        public Int16 VATPartialRatio { get; set; }

        ///<![CDATA[VAT percentages. You can have several VAT percentages, with start and end dates]]>
        public IEnumerable<VatPercentage> VATPercentages { get; set; }

        ///<![CDATA[Indicates the type of transactions for which the VAT code may be used. B = Both, P = Purchase, S = Sales]]>
        public string VATTransactionType { get; set; }
    }
}