using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ContractualDelivery", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class DeliveryType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType Quantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType MinimumQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType MaximumQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType ActualDeliveryDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeType ActualDeliveryTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType LatestDeliveryDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeType LatestDeliveryTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ReleaseID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TrackingID { get; set; }

		/// <remarks/>
		public AddressType DeliveryAddress { get; set; }

		/// <remarks/>
		public LocationType1 DeliveryLocation { get; set; }

		/// <remarks/>
		public LocationType1 AlternativeDeliveryLocation { get; set; }

		/// <remarks/>
		public PeriodType RequestedDeliveryPeriod { get; set; }

		/// <remarks/>
		public PeriodType PromisedDeliveryPeriod { get; set; }

		/// <remarks/>
		public PeriodType EstimatedDeliveryPeriod { get; set; }

		/// <remarks/>
		public PartyType CarrierParty { get; set; }

		/// <remarks/>
		public PartyType DeliveryParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
		public PartyType[] NotifyParty { get; set; }

		/// <remarks/>
		public DespatchType Despatch { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
		public DeliveryTermsType[] DeliveryTerms { get; set; }

		/// <remarks/>
		public DeliveryUnitType MinimumDeliveryUnit { get; set; }

		/// <remarks/>
		public DeliveryUnitType MaximumDeliveryUnit { get; set; }

		/// <remarks/>
		public ShipmentType Shipment { get; set; }
	}
}