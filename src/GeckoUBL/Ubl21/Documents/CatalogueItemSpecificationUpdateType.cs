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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CatalogueItemSpecificationUpdate-2")]
	[System.Xml.Serialization.XmlRootAttribute("CatalogueItemSpecificationUpdate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CatalogueItemSpecificationUpdate-2", IsNullable=false)]
	public class CatalogueItemSpecificationUpdateType {
    
		private UBLExtensionType[] uBLExtensionsField;
    
		private UBLVersionIDType uBLVersionIDField;
    
		private CustomizationIDType customizationIDField;
    
		private ProfileIDType profileIDField;
    
		private ProfileExecutionIDType profileExecutionIDField;
    
		private IDType idField;
    
		private UUIDType uUIDField;
    
		private NameType1 nameField;
    
		private IssueDateType issueDateField;
    
		private IssueTimeType issueTimeField;
    
		private RevisionDateType revisionDateField;
    
		private RevisionTimeType revisionTimeField;
    
		private NoteType[] noteField;
    
		private DescriptionType[] descriptionField;
    
		private VersionIDType versionIDField;
    
		private LineCountNumericType lineCountNumericField;
    
		private PeriodType[] validityPeriodField;
    
		private CatalogueReferenceType relatedCatalogueReferenceField;
    
		private ContractType[] referencedContractField;
    
		private SignatureType[] signatureField;
    
		private PartyType providerPartyField;
    
		private PartyType receiverPartyField;
    
		private SupplierPartyType sellerSupplierPartyField;
    
		private CustomerPartyType contractorCustomerPartyField;
    
		private TradingTermsType tradingTermsField;
    
		private LanguageType defaultLanguageField;
    
		private CatalogueItemSpecificationUpdateLineType[] catalogueItemSpecificationUpdateLineField;
    
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
		public NameType1 Name {
			get {
				return nameField;
			}
			set {
				nameField = value;
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RevisionDateType RevisionDate {
			get {
				return revisionDateField;
			}
			set {
				revisionDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RevisionTimeType RevisionTime {
			get {
				return revisionTimeField;
			}
			set {
				revisionTimeField = value;
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
		[System.Xml.Serialization.XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description {
			get {
				return descriptionField;
			}
			set {
				descriptionField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public VersionIDType VersionID {
			get {
				return versionIDField;
			}
			set {
				versionIDField = value;
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
		[System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] ValidityPeriod {
			get {
				return validityPeriodField;
			}
			set {
				validityPeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CatalogueReferenceType RelatedCatalogueReference {
			get {
				return relatedCatalogueReferenceField;
			}
			set {
				relatedCatalogueReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ContractType[] ReferencedContract {
			get {
				return referencedContractField;
			}
			set {
				referencedContractField = value;
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
		public PartyType ProviderParty {
			get {
				return providerPartyField;
			}
			set {
				providerPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType ReceiverParty {
			get {
				return receiverPartyField;
			}
			set {
				receiverPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType SellerSupplierParty {
			get {
				return sellerSupplierPartyField;
			}
			set {
				sellerSupplierPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType ContractorCustomerParty {
			get {
				return contractorCustomerPartyField;
			}
			set {
				contractorCustomerPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TradingTermsType TradingTerms {
			get {
				return tradingTermsField;
			}
			set {
				tradingTermsField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public LanguageType DefaultLanguage {
			get {
				return defaultLanguageField;
			}
			set {
				defaultLanguageField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CatalogueItemSpecificationUpdateLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CatalogueItemSpecificationUpdateLineType[] CatalogueItemSpecificationUpdateLine {
			get {
				return catalogueItemSpecificationUpdateLineField;
			}
			set {
				catalogueItemSpecificationUpdateLineField = value;
			}
		}
	}
}