using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ApplicableTransportMeans", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TransportMeansType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType JourneyID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType RegistrationNationalityID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] RegistrationNationality { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType DirectionCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TransportMeansTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TradeServiceCode { get; set; }

		/// <remarks/>
		public StowageType Stowage { get; set; }

		/// <remarks/>
		public AirTransportType AirTransport { get; set; }

		/// <remarks/>
		public RoadTransportType RoadTransport { get; set; }

		/// <remarks/>
		public RailTransportType RailTransport { get; set; }

		/// <remarks/>
		public MaritimeTransportType MaritimeTransport { get; set; }

		/// <remarks/>
		public PartyType OwnerParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
		public DimensionType[] MeasurementDimension { get; set; }
	}
}