using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AwardingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class AwardingTermsType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType WeightingAlgorithmCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] TechnicalCommitteeDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LowTendersDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] LowTendersDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType PrizeIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PrizeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] PrizeDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] PaymentDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType FollowupContractIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType BindingOnBuyerIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AwardingCriterion")]
		public AwardingCriterionType[] AwardingCriterion { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteePerson")]
		public PersonType[] TechnicalCommitteePerson { get; set; }
	}
}