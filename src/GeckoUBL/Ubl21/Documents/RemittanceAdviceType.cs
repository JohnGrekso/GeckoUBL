using GeckoUBL.Ubl21.Cac;
using GeckoUBL.Ubl21.Cbc;
using GeckoUBL.Ubl21.Cec;

namespace GeckoUBL.Ubl21.Documents
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2")]
	[System.Xml.Serialization.XmlRootAttribute("RemittanceAdvice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2", IsNullable=false)]
	public class RemittanceAdviceType {
    
		private UBLExtensionType[] uBLExtensionsField;
    
		private UBLVersionIDType uBLVersionIDField;
    
		private CustomizationIDType customizationIDField;
    
		private ProfileIDType profileIDField;
    
		private ProfileExecutionIDType profileExecutionIDField;
    
		private IDType idField;
    
		private CopyIndicatorType copyIndicatorField;
    
		private UUIDType uUIDField;
    
		private IssueDateType issueDateField;
    
		private IssueTimeType issueTimeField;
    
		private NoteType[] noteField;
    
		private DocumentCurrencyCodeType documentCurrencyCodeField;
    
		private TotalDebitAmountType totalDebitAmountField;
    
		private TotalCreditAmountType totalCreditAmountField;
    
		private TotalPaymentAmountType totalPaymentAmountField;
    
		private PaymentOrderReferenceType paymentOrderReferenceField;
    
		private PayerReferenceType payerReferenceField;
    
		private InvoicingPartyReferenceType invoicingPartyReferenceField;
    
		private LineCountNumericType lineCountNumericField;
    
		private PeriodType[] invoicePeriodField;
    
		private BillingReferenceType billingReferenceField;
    
		private DocumentReferenceType[] additionalDocumentReferenceField;
    
		private SignatureType[] signatureField;
    
		private CustomerPartyType accountingCustomerPartyField;
    
		private SupplierPartyType accountingSupplierPartyField;
    
		private PartyType payeePartyField;
    
		private PaymentMeansType paymentMeansField;
    
		private TaxTotalType[] taxTotalField;
    
		private RemittanceAdviceLineType[] remittanceAdviceLineField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
		[System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
		public UBLExtensionType[] UBLExtensions {
			get {
				return uBLExtensionsField;
			}
			set {
				uBLExtensionsField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UBLVersionIDType UBLVersionID {
			get {
				return uBLVersionIDField;
			}
			set {
				uBLVersionIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomizationIDType CustomizationID {
			get {
				return customizationIDField;
			}
			set {
				customizationIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProfileIDType ProfileID {
			get {
				return profileIDField;
			}
			set {
				profileIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProfileExecutionIDType ProfileExecutionID {
			get {
				return profileExecutionIDField;
			}
			set {
				profileExecutionIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID {
			get {
				return idField;
			}
			set {
				idField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CopyIndicatorType CopyIndicator {
			get {
				return copyIndicatorField;
			}
			set {
				copyIndicatorField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UUIDType UUID {
			get {
				return uUIDField;
			}
			set {
				uUIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate {
			get {
				return issueDateField;
			}
			set {
				issueDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueTimeType IssueTime {
			get {
				return issueTimeField;
			}
			set {
				issueTimeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note {
			get {
				return noteField;
			}
			set {
				noteField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentCurrencyCodeType DocumentCurrencyCode {
			get {
				return documentCurrencyCodeField;
			}
			set {
				documentCurrencyCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalDebitAmountType TotalDebitAmount {
			get {
				return totalDebitAmountField;
			}
			set {
				totalDebitAmountField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalCreditAmountType TotalCreditAmount {
			get {
				return totalCreditAmountField;
			}
			set {
				totalCreditAmountField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TotalPaymentAmountType TotalPaymentAmount {
			get {
				return totalPaymentAmountField;
			}
			set {
				totalPaymentAmountField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PaymentOrderReferenceType PaymentOrderReference {
			get {
				return paymentOrderReferenceField;
			}
			set {
				paymentOrderReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PayerReferenceType PayerReference {
			get {
				return payerReferenceField;
			}
			set {
				payerReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InvoicingPartyReferenceType InvoicingPartyReference {
			get {
				return invoicingPartyReferenceField;
			}
			set {
				invoicingPartyReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineCountNumericType LineCountNumeric {
			get {
				return lineCountNumericField;
			}
			set {
				lineCountNumericField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] InvoicePeriod {
			get {
				return invoicePeriodField;
			}
			set {
				invoicePeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public BillingReferenceType BillingReference {
			get {
				return billingReferenceField;
			}
			set {
				billingReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] AdditionalDocumentReference {
			get {
				return additionalDocumentReferenceField;
			}
			set {
				additionalDocumentReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SignatureType[] Signature {
			get {
				return signatureField;
			}
			set {
				signatureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType AccountingCustomerParty {
			get {
				return accountingCustomerPartyField;
			}
			set {
				accountingCustomerPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType AccountingSupplierParty {
			get {
				return accountingSupplierPartyField;
			}
			set {
				accountingSupplierPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType PayeeParty {
			get {
				return payeePartyField;
			}
			set {
				payeePartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PaymentMeansType PaymentMeans {
			get {
				return paymentMeansField;
			}
			set {
				paymentMeansField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TaxTotalType[] TaxTotal {
			get {
				return taxTotalField;
			}
			set {
				taxTotalField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RemittanceAdviceLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public RemittanceAdviceLineType[] RemittanceAdviceLine {
			get {
				return remittanceAdviceLineField;
			}
			set {
				remittanceAdviceLineField = value;
			}
		}
	}
}