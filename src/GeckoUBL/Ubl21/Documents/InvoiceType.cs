using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using GeckoUBL.Ubl21.Cac;
using GeckoUBL.Ubl21.Cec;
using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Documents
{
	[GeneratedCode("xsd", "4.0.30319.33440")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
	[XmlRoot("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
	public class InvoiceType : BaseUblDocument
	{
		[XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
		[XmlArrayItem("UBLExtension", IsNullable = false)]
		public UBLExtensionType[] UBLExtensions { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType UBLVersionID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType CustomizationID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ProfileID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ProfileExecutionID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType CopyIndicator { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType UUID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType IssueDate { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeType IssueTime { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType DueDate { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType InvoiceTypeCode { get; set; }

		[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Note { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType TaxPointDate { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType DocumentCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TaxCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PricingCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PaymentCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PaymentAlternativeCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType AccountingCostCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType AccountingCost { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NumericType LineCountNumeric { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType BuyerReference { get; set; }

		[XmlElement("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] InvoicePeriod { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public OrderReferenceType OrderReference { get; set; }

		[XmlElement("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
			)]
		public BillingReferenceType[] BillingReference { get; set; }

		[XmlElement("DespatchDocumentReference",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] DespatchDocumentReference { get; set; }

		[XmlElement("ReceiptDocumentReference",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] ReceiptDocumentReference { get; set; }

		[XmlElement("StatementDocumentReference",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] StatementDocumentReference { get; set; }

		[XmlElement("OriginatorDocumentReference",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] OriginatorDocumentReference { get; set; }

		[XmlElement("ContractDocumentReference",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] ContractDocumentReference { get; set; }

		[XmlElement("AdditionalDocumentReference",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

		[XmlElement("ProjectReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
			)]
		public ProjectReferenceType[] ProjectReference { get; set; }

		[XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SignatureType[] Signature { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType AccountingSupplierParty { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType AccountingCustomerParty { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType PayeeParty { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType BuyerCustomerParty { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType SellerSupplierParty { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType TaxRepresentativeParty { get; set; }

		[XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DeliveryType[] Delivery { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DeliveryTermsType DeliveryTerms { get; set; }

		[XmlElement("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PaymentMeansType[] PaymentMeans { get; set; }

		[XmlElement("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PaymentTermsType[] PaymentTerms { get; set; }

		[XmlElement("PrepaidPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PaymentType[] PrepaidPayment { get; set; }

		[XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
		]
		public AllowanceChargeType[] AllowanceCharge { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType TaxExchangeRate { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType PricingExchangeRate { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType PaymentExchangeRate { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }

		[XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TaxTotalType[] TaxTotal { get; set; }

		[XmlElement("WithholdingTaxTotal",
			Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TaxTotalType[] WithholdingTaxTotal { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public MonetaryTotalType LegalMonetaryTotal { get; set; }

		[XmlElement("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public InvoiceLineType[] InvoiceLine { get; set; }
	}
}