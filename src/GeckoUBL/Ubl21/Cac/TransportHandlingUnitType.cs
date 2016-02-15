using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("PackagedTransportHandlingUnit", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TransportHandlingUnitType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransportHandlingUnitTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType HandlingCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] HandlingInstructions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType HazardousRiskIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType TotalGoodsItemQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType TotalPackageQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] DamageRemarks { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] ShippingMarks { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TraceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine")]
		public DespatchLineType[] HandlingUnitDespatchLine { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ActualPackage")]
		public PackageType[] ActualPackage { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine")]
		public ReceiptLineType[] ReceivedHandlingUnitReceiptLine { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
		public TransportEquipmentType[] TransportEquipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportMeans")]
		public TransportMeansType[] TransportMeans { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
		public HazardousGoodsTransitType[] HazardousGoodsTransit { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
		public DimensionType[] MeasurementDimension { get; set; }

		/// <remarks/>
		public TemperatureType MinimumTemperature { get; set; }

		/// <remarks/>
		public TemperatureType MaximumTemperature { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
		public GoodsItemType[] GoodsItem { get; set; }

		/// <remarks/>
		public DimensionType FloorSpaceMeasurementDimension { get; set; }

		/// <remarks/>
		public DimensionType PalletSpaceMeasurementDimension { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
		public DocumentReferenceType[] ShipmentDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Status")]
		public StatusType[] Status { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
		public CustomsDeclarationType[] CustomsDeclaration { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ReferencedShipment")]
		public ShipmentType[] ReferencedShipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Package")]
		public PackageType[] Package { get; set; }
	}
}