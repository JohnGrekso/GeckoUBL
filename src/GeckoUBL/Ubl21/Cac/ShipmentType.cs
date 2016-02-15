using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ConsolidatedShipment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ShipmentType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

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
		public MeasureType GrossWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType NetWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType NetNetWeightMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType GrossVolumeMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType NetVolumeMeasure { get; set; }

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
		public AmountType DeclaredCustomsValueAmount { get; set; }

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
		[System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] DeliveryInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType SplitConsignmentIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType ConsignmentQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Consignment")]
		public ConsignmentType[] Consignment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
		public GoodsItemType[] GoodsItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
		public ShipmentStageType[] ShipmentStage { get; set; }

		/// <remarks/>
		public DeliveryType Delivery { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
		public TransportHandlingUnitType[] TransportHandlingUnit { get; set; }

		/// <remarks/>
		public AddressType ReturnAddress { get; set; }

		/// <remarks/>
		public AddressType OriginAddress { get; set; }

		/// <remarks/>
		public LocationType1 FirstArrivalPortLocation { get; set; }

		/// <remarks/>
		public LocationType1 LastExitPortLocation { get; set; }

		/// <remarks/>
		public CountryType ExportCountry { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
		public AllowanceChargeType[] FreightAllowanceCharge { get; set; }
	}
}