using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AttachedTransportEquipment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TransportEquipmentType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ReferencedConsignmentID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType[] ReferencedConsignmentID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransportEquipmentTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType ProviderTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType OwnerTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType SizeTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType DispositionCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType FullnessIndicationCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType RefrigerationOnIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Information { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType ReturnabilityIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType LegalStatusIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PercentType AirFlowPercent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PercentType HumidityPercent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType AnimalFoodApprovedIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType HumanFoodApprovedIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType DangerousGoodsApprovedIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType RefrigeratedIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType Characteristics { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] DamageRemarks { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SpecialTransportRequirements", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] SpecialTransportRequirements { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType GrossWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType GrossVolumeMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType TareWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TrackingDeviceCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType PowerIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TraceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
		public DimensionType[] MeasurementDimension { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEquipmentSeal")]
		public TransportEquipmentSealType[] TransportEquipmentSeal { get; set; }

		/// <remarks/>
		public TemperatureType MinimumTemperature { get; set; }

		/// <remarks/>
		public TemperatureType MaximumTemperature { get; set; }

		/// <remarks/>
		public PartyType ProviderParty { get; set; }

		/// <remarks/>
		public PartyType LoadingProofParty { get; set; }

		/// <remarks/>
		public SupplierPartyType SupplierParty { get; set; }

		/// <remarks/>
		public PartyType OwnerParty { get; set; }

		/// <remarks/>
		public PartyType OperatingParty { get; set; }

		/// <remarks/>
		public LocationType1 LoadingLocation { get; set; }

		/// <remarks/>
		public LocationType1 UnloadingLocation { get; set; }

		/// <remarks/>
		public LocationType1 StorageLocation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PositioningTransportEvent")]
		public TransportEventType[] PositioningTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("QuarantineTransportEvent")]
		public TransportEventType[] QuarantineTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DeliveryTransportEvent")]
		public TransportEventType[] DeliveryTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PickupTransportEvent")]
		public TransportEventType[] PickupTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HandlingTransportEvent")]
		public TransportEventType[] HandlingTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoadingTransportEvent")]
		public TransportEventType[] LoadingTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
		public TransportEventType[] TransportEvent { get; set; }

		/// <remarks/>
		public TransportMeansType ApplicableTransportMeans { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HaulageTradingTerms")]
		public TradingTermsType[] HaulageTradingTerms { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
		public HazardousGoodsTransitType[] HazardousGoodsTransit { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PackagedTransportHandlingUnit")]
		public TransportHandlingUnitType[] PackagedTransportHandlingUnit { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ServiceAllowanceCharge")]
		public AllowanceChargeType[] ServiceAllowanceCharge { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
		public AllowanceChargeType[] FreightAllowanceCharge { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AttachedTransportEquipment")]
		public TransportEquipmentType[] AttachedTransportEquipment { get; set; }

		/// <remarks/>
		public DeliveryType Delivery { get; set; }

		/// <remarks/>
		public PickupType Pickup { get; set; }

		/// <remarks/>
		public DespatchType Despatch { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
		public DocumentReferenceType[] ShipmentDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ContainedInTransportEquipment")]
		public TransportEquipmentType[] ContainedInTransportEquipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Package")]
		public PackageType[] Package { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
		public GoodsItemType[] GoodsItem { get; set; }
	}
}