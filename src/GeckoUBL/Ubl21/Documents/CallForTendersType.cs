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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2")]
	[System.Xml.Serialization.XmlRootAttribute("CallForTenders", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2", IsNullable=false)]
	public class CallForTendersType {
    
		private UBLExtensionType[] uBLExtensionsField;
    
		private UBLVersionIDType uBLVersionIDField;
    
		private CustomizationIDType customizationIDField;
    
		private ProfileIDType profileIDField;
    
		private ProfileExecutionIDType profileExecutionIDField;
    
		private IDType idField;
    
		private CopyIndicatorType copyIndicatorField;
    
		private UUIDType uUIDField;
    
		private ContractFolderIDType contractFolderIDField;
    
		private ApprovalDateType approvalDateField;
    
		private IssueDateType issueDateField;
    
		private IssueTimeType issueTimeField;
    
		private NoteType[] noteField;
    
		private VersionIDType versionIDField;
    
		private PreviousVersionIDType previousVersionIDField;
    
		private DocumentReferenceType legalDocumentReferenceField;
    
		private DocumentReferenceType technicalDocumentReferenceField;
    
		private DocumentReferenceType[] additionalDocumentReferenceField;
    
		private SignatureType[] signatureField;
    
		private ContractingPartyType contractingPartyField;
    
		private CustomerPartyType[] originatorCustomerPartyField;
    
		private PartyType receiverPartyField;
    
		private TenderingTermsType tenderingTermsField;
    
		private TenderingProcessType tenderingProcessField;
    
		private ProcurementProjectType procurementProjectField;
    
		private ProcurementProjectLotType[] procurementProjectLotField;
    
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
		public ContractFolderIDType ContractFolderID {
			get {
				return contractFolderIDField;
			}
			set {
				contractFolderIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ApprovalDateType ApprovalDate {
			get {
				return approvalDateField;
			}
			set {
				approvalDateField = value;
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
		public PreviousVersionIDType PreviousVersionID {
			get {
				return previousVersionIDField;
			}
			set {
				previousVersionIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType LegalDocumentReference {
			get {
				return legalDocumentReferenceField;
			}
			set {
				legalDocumentReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType TechnicalDocumentReference {
			get {
				return technicalDocumentReferenceField;
			}
			set {
				technicalDocumentReferenceField = value;
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
		public ContractingPartyType ContractingParty {
			get {
				return contractingPartyField;
			}
			set {
				contractingPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType[] OriginatorCustomerParty {
			get {
				return originatorCustomerPartyField;
			}
			set {
				originatorCustomerPartyField = value;
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
		public TenderingTermsType TenderingTerms {
			get {
				return tenderingTermsField;
			}
			set {
				tenderingTermsField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TenderingProcessType TenderingProcess {
			get {
				return tenderingProcessField;
			}
			set {
				tenderingProcessField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ProcurementProjectType ProcurementProject {
			get {
				return procurementProjectField;
			}
			set {
				procurementProjectField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ProcurementProjectLotType[] ProcurementProjectLot {
			get {
				return procurementProjectLotField;
			}
			set {
				procurementProjectLotField = value;
			}
		}
	}
}