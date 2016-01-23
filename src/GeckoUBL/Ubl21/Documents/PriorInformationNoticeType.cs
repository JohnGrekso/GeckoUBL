using GeckoUBL.Ubl21.Cbc;
using GeckoUBL.Ubl21.Cec;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:PriorInformationNotice-2")]
[System.Xml.Serialization.XmlRootAttribute("PriorInformationNotice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:PriorInformationNotice-2", IsNullable=false)]
public partial class PriorInformationNoticeType {
    
	private UBLExtensionType[] uBLExtensionsField;
    
	private UBLVersionIDType uBLVersionIDField;
    
	private CustomizationIDType customizationIDField;
    
	private ProfileIDType profileIDField;
    
	private ProfileExecutionIDType profileExecutionIDField;
    
	private IDType idField;
    
	private CopyIndicatorType copyIndicatorField;
    
	private UUIDType uUIDField;
    
	private ContractFolderIDType contractFolderIDField;
    
	private IssueDateType issueDateField;
    
	private IssueTimeType issueTimeField;
    
	private NoteType[] noteField;
    
	private PlannedDateType plannedDateField;
    
	private DocumentReferenceType[] documentReferenceField;
    
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
			return this.uBLExtensionsField;
		}
		set {
			this.uBLExtensionsField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public UBLVersionIDType UBLVersionID {
		get {
			return this.uBLVersionIDField;
		}
		set {
			this.uBLVersionIDField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public CustomizationIDType CustomizationID {
		get {
			return this.customizationIDField;
		}
		set {
			this.customizationIDField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public ProfileIDType ProfileID {
		get {
			return this.profileIDField;
		}
		set {
			this.profileIDField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public ProfileExecutionIDType ProfileExecutionID {
		get {
			return this.profileExecutionIDField;
		}
		set {
			this.profileExecutionIDField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public IDType ID {
		get {
			return this.idField;
		}
		set {
			this.idField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public CopyIndicatorType CopyIndicator {
		get {
			return this.copyIndicatorField;
		}
		set {
			this.copyIndicatorField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public UUIDType UUID {
		get {
			return this.uUIDField;
		}
		set {
			this.uUIDField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public ContractFolderIDType ContractFolderID {
		get {
			return this.contractFolderIDField;
		}
		set {
			this.contractFolderIDField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public IssueDateType IssueDate {
		get {
			return this.issueDateField;
		}
		set {
			this.issueDateField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public IssueTimeType IssueTime {
		get {
			return this.issueTimeField;
		}
		set {
			this.issueTimeField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public NoteType[] Note {
		get {
			return this.noteField;
		}
		set {
			this.noteField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public PlannedDateType PlannedDate {
		get {
			return this.plannedDateField;
		}
		set {
			this.plannedDateField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public DocumentReferenceType[] DocumentReference {
		get {
			return this.documentReferenceField;
		}
		set {
			this.documentReferenceField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public SignatureType[] Signature {
		get {
			return this.signatureField;
		}
		set {
			this.signatureField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public ContractingPartyType ContractingParty {
		get {
			return this.contractingPartyField;
		}
		set {
			this.contractingPartyField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public CustomerPartyType[] OriginatorCustomerParty {
		get {
			return this.originatorCustomerPartyField;
		}
		set {
			this.originatorCustomerPartyField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public PartyType ReceiverParty {
		get {
			return this.receiverPartyField;
		}
		set {
			this.receiverPartyField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public TenderingTermsType TenderingTerms {
		get {
			return this.tenderingTermsField;
		}
		set {
			this.tenderingTermsField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public TenderingProcessType TenderingProcess {
		get {
			return this.tenderingProcessField;
		}
		set {
			this.tenderingProcessField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public ProcurementProjectType ProcurementProject {
		get {
			return this.procurementProjectField;
		}
		set {
			this.procurementProjectField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	public ProcurementProjectLotType[] ProcurementProjectLot {
		get {
			return this.procurementProjectLotField;
		}
		set {
			this.procurementProjectLotField = value;
		}
	}
}