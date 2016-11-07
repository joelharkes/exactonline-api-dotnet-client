using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Document
    {
        ///<![CDATA[ID of the related account of this document]]>
        public Guid Account { get; set; }

        ///<![CDATA[Code of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }

        ///<![CDATA[Name of Account]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }

        ///<![CDATA[Amount in the currency of the transaction]]>
        public double? AmountFC { get; set; }

        ///<![CDATA[Body of this document]]>
        public string Body { get; set; }

        ///<![CDATA[ID of the category of this document]]>
        public Guid Category { get; set; }

        ///<![CDATA[Description of Category]]>
        public string CategoryDescription { get; set; }

        ///<![CDATA[ID of the related contact of this document]]>
        public Guid Contact { get; set; }

        ///<![CDATA[Contact full name]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ContactFullName { get; set; }

        ///<![CDATA[Creation date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Currency code]]>
        public string Currency { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Entry date of the incoming document]]>
        public DateTime DocumentDate { get; set; }

        ///<![CDATA[The Id of document folder]]>
        public Guid DocumentFolder { get; set; }

        ///<![CDATA[The Code of document folder]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentFolderCode { get; set; }

        ///<![CDATA[The Decsription of document folder]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentFolderDescription { get; set; }

        ///<![CDATA[Url to view the document]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string DocumentViewUrl { get; set; }

        ///<![CDATA[Reference to the financial transaction]]>
        public Guid FinancialTransactionEntryID { get; set; }

        ///<![CDATA[Indicates that the document body is empty]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public bool HasEmptyBody { get; set; }

        ///<![CDATA[Human-readable ID, formatted as xx.xxx.xxx. Unique. May not be equal to zero]]>
        public Int32 HID { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[The language code of the document]]>
        public string Language { get; set; }

        ///<![CDATA[Last modified date]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }

        ///<![CDATA[The opportunity linked to the document]]>
        public Guid Opportunity { get; set; }

        ///<![CDATA[The project linked to the document]]>
        public Guid Project { get; set; }

        ///<![CDATA[Code of project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectCode { get; set; }

        ///<![CDATA[Description of project]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string ProjectDescription { get; set; }

        ///<![CDATA['Our reference' of the transaction that belongs to this document]]>
        public Int32 SalesInvoiceNumber { get; set; }

        ///<![CDATA[Number of the sales order]]>
        public Int32 SalesOrderNumber { get; set; }

        ///<![CDATA[Number of the shop order]]>
        public Int32 ShopOrderNumber { get; set; }

        ///<![CDATA[Subject of this document]]>
        public string Subject { get; set; }

        ///<![CDATA[ID of the type of this document]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Description of Type]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }
}