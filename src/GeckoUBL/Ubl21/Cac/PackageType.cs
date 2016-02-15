using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ActualPackage", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PackageType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType Quantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType ReturnableMaterialIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PackageLevelCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PackagingTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] PackingMaterial { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TraceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ContainedPackage")]
		public PackageType[] ContainedPackage { get; set; }

		/// <remarks/>
		public TransportEquipmentType ContainingTransportEquipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
		public GoodsItemType[] GoodsItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
		public DimensionType[] MeasurementDimension { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
		public DeliveryUnitType[] DeliveryUnit { get; set; }

		/// <remarks/>
		public DeliveryType Delivery { get; set; }

		/// <remarks/>
		public PickupType Pickup { get; set; }

		/// <remarks/>
		public DespatchType Despatch { get; set; }
	}
}