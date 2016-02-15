using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ChildConsignment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ConsignmentType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType CarrierAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ConsigneeAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ConsignorAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType FreightForwarderAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType BrokerAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ContractedCarrierAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType PerformingCarrierAssignedID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] SummaryDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType TotalInvoiceAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType DeclaredCustomsValueAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] TariffDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TariffCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType InsurancePremiumAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType GrossWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType NetWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType NetNetWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType ChargeableWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType GrossVolumeMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType NetVolumeMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType LoadingLengthMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Remarks { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType HazardousRiskIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType AnimalFoodIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType HumanFoodIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType LivestockIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType BulkCargoIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType ContainerizedIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType GeneralCargoIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType SpecialSecurityIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType ThirdPartyPayerIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CarrierServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] CarrierServiceInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] CustomsClearanceServiceInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ForwarderServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] ForwarderServiceInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SpecialServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] SpecialServiceInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType SequenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType ShippingPriorityLevelCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType HandlingCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] HandlingInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Information { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType TotalGoodsItemQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType TotalTransportHandlingUnitQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType InsuranceValueAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType DeclaredForCarriageValueAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType DeclaredStatisticsValueAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType FreeOnBoardValueAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] SpecialInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType SplitConsignmentIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] DeliveryInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType ConsignmentQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType ConsolidatableIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HaulageInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] HaulageInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType LoadingSequenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType ChildConsignmentQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType TotalPackagesQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ConsolidatedShipment")]
		public ShipmentType[] ConsolidatedShipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
		public CustomsDeclarationType[] CustomsDeclaration { get; set; }

		/// <remarks/>
		public TransportEventType RequestedPickupTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType RequestedDeliveryTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType PlannedPickupTransportEvent { get; set; }

		/// <remarks/>
		public TransportEventType PlannedDeliveryTransportEvent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Status")]
		public StatusType[] Status { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ChildConsignment")]
		public ConsignmentType[] ChildConsignment { get; set; }

		/// <remarks/>
		public PartyType ConsigneeParty { get; set; }

		/// <remarks/>
		public PartyType ExporterParty { get; set; }

		/// <remarks/>
		public PartyType ConsignorParty { get; set; }

		/// <remarks/>
		public PartyType ImporterParty { get; set; }

		/// <remarks/>
		public PartyType CarrierParty { get; set; }

		/// <remarks/>
		public PartyType FreightForwarderParty { get; set; }

		/// <remarks/>
		public PartyType NotifyParty { get; set; }

		/// <remarks/>
		public PartyType OriginalDespatchParty { get; set; }

		/// <remarks/>
		public PartyType FinalDeliveryParty { get; set; }

		/// <remarks/>
		public PartyType PerformingCarrierParty { get; set; }

		/// <remarks/>
		public PartyType SubstituteCarrierParty { get; set; }

		/// <remarks/>
		public PartyType LogisticsOperatorParty { get; set; }

		/// <remarks/>
		public PartyType TransportAdvisorParty { get; set; }

		/// <remarks/>
		public PartyType HazardousItemNotificationParty { get; set; }

		/// <remarks/>
		public PartyType InsuranceParty { get; set; }

		/// <remarks/>
		public PartyType MortgageHolderParty { get; set; }

		/// <remarks/>
		public PartyType BillOfLadingHolderParty { get; set; }

		/// <remarks/>
		public CountryType OriginalDepartureCountry { get; set; }

		/// <remarks/>
		public CountryType FinalDestinationCountry { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransitCountry")]
		public CountryType[] TransitCountry { get; set; }

		/// <remarks/>
		public ContractType TransportContract { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
		public TransportEventType[] TransportEvent { get; set; }

		/// <remarks/>
		public TransportationServiceType OriginalDespatchTransportationService { get; set; }

		/// <remarks/>
		public TransportationServiceType FinalDeliveryTransportationService { get; set; }

		/// <remarks/>
		public DeliveryTermsType DeliveryTerms { get; set; }

		/// <remarks/>
		public PaymentTermsType PaymentTerms { get; set; }

		/// <remarks/>
		public PaymentTermsType CollectPaymentTerms { get; set; }

		/// <remarks/>
		public PaymentTermsType DisbursementPaymentTerms { get; set; }

		/// <remarks/>
		public PaymentTermsType PrepaidPaymentTerms { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
		public AllowanceChargeType[] FreightAllowanceCharge { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ExtraAllowanceCharge")]
		public AllowanceChargeType[] ExtraAllowanceCharge { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MainCarriageShipmentStage")]
		public ShipmentStageType[] MainCarriageShipmentStage { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PreCarriageShipmentStage")]
		public ShipmentStageType[] PreCarriageShipmentStage { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OnCarriageShipmentStage")]
		public ShipmentStageType[] OnCarriageShipmentStage { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
		public TransportHandlingUnitType[] TransportHandlingUnit { get; set; }

		/// <remarks/>
		public LocationType1 FirstArrivalPortLocation { get; set; }

		/// <remarks/>
		public LocationType1 LastExitPortLocation { get; set; }
	}
}