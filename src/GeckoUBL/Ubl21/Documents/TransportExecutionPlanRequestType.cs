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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlanRequest-2")]
	[System.Xml.Serialization.XmlRootAttribute("TransportExecutionPlanRequest", Namespace="urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlanRequest-2", IsNullable=false)]
	public class TransportExecutionPlanRequestType {
    
		private UBLExtensionType[] uBLExtensionsField;
    
		private UBLVersionIDType uBLVersionIDField;
    
		private CustomizationIDType customizationIDField;
    
		private ProfileIDType profileIDField;
    
		private ProfileExecutionIDType profileExecutionIDField;
    
		private IDType idField;
    
		private VersionIDType versionIDField;
    
		private CopyIndicatorType copyIndicatorField;
    
		private UUIDType uUIDField;
    
		private IssueDateType issueDateField;
    
		private IssueTimeType issueTimeField;
    
		private DocumentStatusCodeType documentStatusCodeField;
    
		private DocumentStatusReasonCodeType documentStatusReasonCodeField;
    
		private DocumentStatusReasonDescriptionType[] documentStatusReasonDescriptionField;
    
		private NoteType[] noteField;
    
		private TransportUserRemarksType[] transportUserRemarksField;
    
		private PartyType senderPartyField;
    
		private PartyType receiverPartyField;
    
		private PartyType transportUserPartyField;
    
		private PartyType transportServiceProviderPartyField;
    
		private PartyType payeePartyField;
    
		private SignatureType[] signatureField;
    
		private DocumentReferenceType transportExecutionPlanDocumentReferenceField;
    
		private DocumentReferenceType transportServiceDescriptionDocumentReferenceField;
    
		private DocumentReferenceType[] additionalDocumentReferenceField;
    
		private ContractType transportContractField;
    
		private PeriodType[] transportServiceProviderResponseDeadlinePeriodField;
    
		private TransportationServiceType mainTransportationServiceField;
    
		private TransportationServiceType[] additionalTransportationServiceField;
    
		private PeriodType serviceStartTimePeriodField;
    
		private PeriodType serviceEndTimePeriodField;
    
		private LocationType1 fromLocationField;
    
		private LocationType1 toLocationField;
    
		private LocationType1 atLocationField;
    
		private TransportExecutionTermsType transportExecutionTermsField;
    
		private ConsignmentType[] consignmentField;
    
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentStatusCodeType DocumentStatusCode {
			get {
				return documentStatusCodeField;
			}
			set {
				documentStatusCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentStatusReasonCodeType DocumentStatusReasonCode {
			get {
				return documentStatusReasonCodeField;
			}
			set {
				documentStatusReasonCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentStatusReasonDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentStatusReasonDescriptionType[] DocumentStatusReasonDescription {
			get {
				return documentStatusReasonDescriptionField;
			}
			set {
				documentStatusReasonDescriptionField = value;
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
		[System.Xml.Serialization.XmlElementAttribute("TransportUserRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportUserRemarksType[] TransportUserRemarks {
			get {
				return transportUserRemarksField;
			}
			set {
				transportUserRemarksField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType SenderParty {
			get {
				return senderPartyField;
			}
			set {
				senderPartyField = value;
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
		public PartyType TransportUserParty {
			get {
				return transportUserPartyField;
			}
			set {
				transportUserPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PartyType TransportServiceProviderParty {
			get {
				return transportServiceProviderPartyField;
			}
			set {
				transportServiceProviderPartyField = value;
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
		public DocumentReferenceType TransportExecutionPlanDocumentReference {
			get {
				return transportExecutionPlanDocumentReferenceField;
			}
			set {
				transportExecutionPlanDocumentReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType TransportServiceDescriptionDocumentReference {
			get {
				return transportServiceDescriptionDocumentReferenceField;
			}
			set {
				transportServiceDescriptionDocumentReferenceField = value;
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ContractType TransportContract {
			get {
				return transportContractField;
			}
			set {
				transportContractField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderResponseDeadlinePeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] TransportServiceProviderResponseDeadlinePeriod {
			get {
				return transportServiceProviderResponseDeadlinePeriodField;
			}
			set {
				transportServiceProviderResponseDeadlinePeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportationServiceType MainTransportationService {
			get {
				return mainTransportationServiceField;
			}
			set {
				mainTransportationServiceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalTransportationService", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportationServiceType[] AdditionalTransportationService {
			get {
				return additionalTransportationServiceField;
			}
			set {
				additionalTransportationServiceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType ServiceStartTimePeriod {
			get {
				return serviceStartTimePeriodField;
			}
			set {
				serviceStartTimePeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType ServiceEndTimePeriod {
			get {
				return serviceEndTimePeriodField;
			}
			set {
				serviceEndTimePeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public LocationType1 FromLocation {
			get {
				return fromLocationField;
			}
			set {
				fromLocationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public LocationType1 ToLocation {
			get {
				return toLocationField;
			}
			set {
				toLocationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public LocationType1 AtLocation {
			get {
				return atLocationField;
			}
			set {
				atLocationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportExecutionTermsType TransportExecutionTerms {
			get {
				return transportExecutionTermsField;
			}
			set {
				transportExecutionTermsField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Consignment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public ConsignmentType[] Consignment {
			get {
				return consignmentField;
			}
			set {
				consignmentField = value;
			}
		}
	}
}