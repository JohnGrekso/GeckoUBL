using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AdditionalTransportationService", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TransportationServiceType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransportServiceCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TariffClassCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType Priority { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType FreightRateClassCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportationServiceDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] TransportationServiceDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TransportationServiceDetailsURI { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType NominationDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeType NominationTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType Name { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NumericType SequenceNumeric { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
		public TransportEquipmentType[] TransportEquipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SupportedTransportEquipment")]
		public TransportEquipmentType[] SupportedTransportEquipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("UnsupportedTransportEquipment")]
		public TransportEquipmentType[] UnsupportedTransportEquipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
		public CommodityClassificationType[] CommodityClassification { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SupportedCommodityClassification")]
		public CommodityClassificationType[] SupportedCommodityClassification { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("UnsupportedCommodityClassification")]
		public CommodityClassificationType[] UnsupportedCommodityClassification { get; set; }

		/// <remarks/>
		public DimensionType TotalCapacityDimension { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
		public ShipmentStageType[] ShipmentStage { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
		public TransportEventType[] TransportEvent { get; set; }

		/// <remarks/>
		public PartyType ResponsibleTransportServiceProviderParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
		public EnvironmentalEmissionType[] EnvironmentalEmission { get; set; }

		/// <remarks/>
		public PeriodType EstimatedDurationPeriod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ScheduledServiceFrequency")]
		public ServiceFrequencyType[] ScheduledServiceFrequency { get; set; }
	}
}