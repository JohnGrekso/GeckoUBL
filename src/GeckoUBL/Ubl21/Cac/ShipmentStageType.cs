using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("MainCarriageShipmentStage", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ShipmentStageType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransportModeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransportMeansTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransitDirectionCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType PreCarriageIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType OnCarriageIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType EstimatedDeliveryDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeType EstimatedDeliveryTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType RequiredDeliveryDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeType RequiredDeliveryTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType LoadingSequenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType SuccessiveSequenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Instructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DemurrageInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] DemurrageInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType CrewQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType PassengerQuantity { get; set; }

		/// <remarks/>
		public PeriodType TransitPeriod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CarrierParty")]
		public PartyType[] CarrierParty { get; set; }

		/// <remarks/>
		public TransportMeansType TransportMeans { get; set; }

		/// <remarks/>
		public LocationType1 LoadingPortLocation { get; set; }

		/// <remarks/>
		public LocationType1 UnloadingPortLocation { get; set; }

		/// <remarks/>
		public LocationType1 TransshipPortLocation { get; set; }

		/// <remarks/>
		public TransportEventType LoadingTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ExaminationTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType AvailabilityTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ExportationTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType DischargeTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType WarehousingTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType TakeoverTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType OptionalTakeoverTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType DropoffTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ActualPickupTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType DeliveryTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ReceiptTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType StorageTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType AcceptanceTransportEvent { get; set; }

		/// <remarks/>
		public PartyType TerminalOperatorParty { get; set; }

		/// <remarks/>
		public PartyType CustomsAgentParty { get; set; }

		/// <remarks/>
		public PeriodType EstimatedTransitPeriod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
		public AllowanceChargeType[] FreightAllowanceCharge { get; set; }

		/// <remarks/>
		public LocationType1 FreightChargeLocation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DetentionTransportEvent")]
		public TransportEventType[] DetentionTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType RequestedDepartureTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType RequestedArrivalTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RequestedWaypointTransportEvent")]
		public TransportEventType[] RequestedWaypointTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType PlannedDepartureTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType PlannedArrivalTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlannedWaypointTransportEvent")]
		public TransportEventType[] PlannedWaypointTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ActualDepartureTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ActualWaypointTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType ActualArrivalTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
		public TransportEventType[] TransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType EstimatedDepartureTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType EstimatedArrivalTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PassengerPerson")]
		public PersonType[] PassengerPerson { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DriverPerson")]
		public PersonType[] DriverPerson { get; set; }

		/// <remarks/>
		public PersonType ReportingPerson { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CrewMemberPerson")]
		public PersonType[] CrewMemberPerson { get; set; }

		/// <remarks/>
		public PersonType SecurityOfficerPerson { get; set; }

		/// <remarks/>
		public PersonType MasterPerson { get; set; }

		/// <remarks/>
		public PersonType ShipsSurgeonPerson { get; set; }
	}
}