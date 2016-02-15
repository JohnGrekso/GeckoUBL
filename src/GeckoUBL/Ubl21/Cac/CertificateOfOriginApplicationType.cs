using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("CertificateOfOriginApplication", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class CertificateOfOriginApplicationType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ReferenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType CertificateType { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType ApplicationStatusCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType OriginalJobID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType PreviousJobID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Remarks { get; set; }

		/// <remarks/>
		public ShipmentType Shipment { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EndorserParty")]
		public EndorserPartyType[] EndorserParty { get; set; }

		/// <remarks/>
		public PartyType PreparationParty { get; set; }

		/// <remarks/>
		public PartyType IssuerParty { get; set; }

		/// <remarks/>
		public PartyType ExporterParty { get; set; }

		/// <remarks/>
		public PartyType ImporterParty { get; set; }

		/// <remarks/>
		public CountryType IssuingCountry { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentDistribution")]
		public DocumentDistributionType[] DocumentDistribution { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference")]
		public DocumentReferenceType[] SupportingDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Signature")]
		public SignatureType[] Signature { get; set; }
	}
}