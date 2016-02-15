using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AdditionalQualifyingParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class QualifyingPartyType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PercentType ParticipationPercent { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] PersonalSituation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType OperatingYearsQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType EmployeeQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType BusinessClassificationEvidenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType BusinessIdentityEvidenceID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TendererRoleCode { get; set; }

		/// <remarks/>
		public ClassificationSchemeType BusinessClassificationScheme { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TechnicalCapability")]
		public CapabilityType[] TechnicalCapability { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FinancialCapability")]
		public CapabilityType[] FinancialCapability { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CompletedTask")]
		public CompletedTaskType[] CompletedTask { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Declaration")]
		public DeclarationType[] Declaration { get; set; }

		/// <remarks/>
		public PartyType Party { get; set; }

		/// <remarks/>
		public EconomicOperatorRoleType EconomicOperatorRole { get; set; }
	}
}