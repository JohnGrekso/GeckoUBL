using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AdditionalInformationParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PartyType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType MarkCareIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType MarkAttentionIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType WebsiteURI { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType LogoReferenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType EndpointID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType IndustryClassificationCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
		public PartyIdentificationType[] PartyIdentification { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PartyName")]
		public PartyNameType[] PartyName { get; set; }

		/// <remarks/>
		public LanguageType Language { get; set; }

		/// <remarks/>
		public AddressType PostalAddress { get; set; }

		/// <remarks/>
		public LocationType1 PhysicalLocation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme")]
		public PartyTaxSchemeType[] PartyTaxScheme { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity")]
		public PartyLegalEntityType[] PartyLegalEntity { get; set; }

		/// <remarks/>
		public ContactType Contact { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Person")]
		public PersonType[] Person { get; set; }

		/// <remarks/>
		public PartyType AgentParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ServiceProviderParty")]
		public ServiceProviderPartyType[] ServiceProviderParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PowerOfAttorney")]
		public PowerOfAttorneyType[] PowerOfAttorney { get; set; }

		/// <remarks/>
		public FinancialAccountType FinancialAccount { get; set; }
	}
}