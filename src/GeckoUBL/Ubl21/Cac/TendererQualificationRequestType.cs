using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("TendererQualificationRequest", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TendererQualificationRequestType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType CompanyLegalFormCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType CompanyLegalForm { get; set; }

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
		[System.Xml.Serialization.XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RequiredBusinessClassificationScheme")]
		public ClassificationSchemeType[] RequiredBusinessClassificationScheme { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TechnicalEvaluationCriterion")]
		public EvaluationCriterionType[] TechnicalEvaluationCriterion { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FinancialEvaluationCriterion")]
		public EvaluationCriterionType[] FinancialEvaluationCriterion { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SpecificTendererRequirement")]
		public TendererRequirementType[] SpecificTendererRequirement { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EconomicOperatorRole")]
		public EconomicOperatorRoleType[] EconomicOperatorRole { get; set; }
	}
}