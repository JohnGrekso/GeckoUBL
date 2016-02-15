using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("TransportationSegment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TransportationSegmentType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NumericType SequenceNumeric { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TransportExecutionPlanReferenceID { get; set; }

		/// <remarks/>
		public TransportationServiceType TransportationService { get; set; }

		/// <remarks/>
		public PartyType TransportServiceProviderParty { get; set; }

		/// <remarks/>
		public ConsignmentType ReferencedConsignment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
		public ShipmentStageType[] ShipmentStage { get; set; }
	}
}