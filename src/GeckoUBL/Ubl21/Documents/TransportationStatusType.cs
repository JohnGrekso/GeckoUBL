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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2")]
	[System.Xml.Serialization.XmlRootAttribute("TransportationStatus", Namespace="urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2", IsNullable=false)]
	public class TransportationStatusType {
    
		private UBLExtensionType[] uBLExtensionsField;
    
		private UBLVersionIDType uBLVersionIDField;
    
		private CustomizationIDType customizationIDField;
    
		private ProfileIDType profileIDField;
    
		private ProfileExecutionIDType profileExecutionIDField;
    
		private IDType idField;
    
		private CarrierAssignedIDType carrierAssignedIDField;
    
		private UUIDType uUIDField;
    
		private IssueDateType issueDateField;
    
		private IssueTimeType issueTimeField;
    
		private NameType1 nameField;
    
		private DescriptionType[] descriptionField;
    
		private NoteType[] noteField;
    
		private ShippingOrderIDType shippingOrderIDField;
    
		private OtherInstructionType otherInstructionField;
    
		private TransportationStatusTypeCodeType transportationStatusTypeCodeField;
    
		private TransportExecutionStatusCodeType transportExecutionStatusCodeField;
    
		private ConsignmentType[] consignmentField;
    
		private TransportEventType[] transportEventField;
    
		private DocumentReferenceType[] documentReferenceField;
    
		private SignatureType[] signatureField;
    
		private PartyType senderPartyField;
    
		private PartyType receiverPartyField;
    
		private DocumentReferenceType transportationStatusRequestDocumentReferenceField;
    
		private DocumentReferenceType transportExecutionPlanDocumentReferenceField;
    
		private TransportEventType updatedPickupTransportEventField;
    
		private TransportEventType updatedDeliveryTransportEventField;
    
		private LocationType1[] statusLocationField;
    
		private PeriodType[] statusPeriodField;
    
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
		public CarrierAssignedIDType CarrierAssignedID {
			get {
				return carrierAssignedIDField;
			}
			set {
				carrierAssignedIDField = value;
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
		public NameType1 Name {
			get {
				return nameField;
			}
			set {
				nameField = value;
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
		public ShippingOrderIDType ShippingOrderID {
			get {
				return shippingOrderIDField;
			}
			set {
				shippingOrderIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OtherInstructionType OtherInstruction {
			get {
				return otherInstructionField;
			}
			set {
				otherInstructionField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportationStatusTypeCodeType TransportationStatusTypeCode {
			get {
				return transportationStatusTypeCodeField;
			}
			set {
				transportationStatusTypeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TransportExecutionStatusCodeType TransportExecutionStatusCode {
			get {
				return transportExecutionStatusCodeField;
			}
			set {
				transportExecutionStatusCodeField = value;
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
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEvent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportEventType[] TransportEvent {
			get {
				return transportEventField;
			}
			set {
				transportEventField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public DocumentReferenceType[] DocumentReference {
			get {
				return documentReferenceField;
			}
			set {
				documentReferenceField = value;
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
		public DocumentReferenceType TransportationStatusRequestDocumentReference {
			get {
				return transportationStatusRequestDocumentReferenceField;
			}
			set {
				transportationStatusRequestDocumentReferenceField = value;
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
		public TransportEventType UpdatedPickupTransportEvent {
			get {
				return updatedPickupTransportEventField;
			}
			set {
				updatedPickupTransportEventField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public TransportEventType UpdatedDeliveryTransportEvent {
			get {
				return updatedDeliveryTransportEventField;
			}
			set {
				updatedDeliveryTransportEventField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("StatusLocation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public LocationType1[] StatusLocation {
			get {
				return statusLocationField;
			}
			set {
				statusLocationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("StatusPeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] StatusPeriod {
			get {
				return statusPeriodField;
			}
			set {
				statusPeriodField = value;
			}
		}
	}
}