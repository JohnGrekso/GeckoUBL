using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("TenderingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TenderingTermsType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType AwardingMethodTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PriceEvaluationCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType MaximumVariantQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType VariantConstraintIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AcceptedVariantsDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] AcceptedVariantsDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PriceRevisionFormulaDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] PriceRevisionFormulaDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType FundingProgramCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FundingProgram", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] FundingProgram { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType MaximumAdvertisementAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Note { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PaymentFrequencyCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType EconomicOperatorRegistryURI { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType RequiredCurriculaIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType OtherConditionsIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalConditions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] AdditionalConditions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType LatestSecurityClearanceDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType DocumentationFeeAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PenaltyClause")]
		public ClauseType[] PenaltyClause { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RequiredFinancialGuarantee")]
		public FinancialGuaranteeType[] RequiredFinancialGuarantee { get; set; }

		/// <remarks/>
		public DocumentReferenceType ProcurementLegislationDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType FiscalLegislationDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType EnvironmentalLegislationDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType EmploymentLegislationDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ContractualDocumentReference")]
		public DocumentReferenceType[] ContractualDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType CallForTendersDocumentReference { get; set; }

		/// <remarks/>
		public PeriodType WarrantyValidityPeriod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
		public PaymentTermsType[] PaymentTerms { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TendererQualificationRequest")]
		public TendererQualificationRequestType[] TendererQualificationRequest { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedSubcontractTerms")]
		public SubcontractTermsType[] AllowedSubcontractTerms { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TenderPreparation")]
		public TenderPreparationType[] TenderPreparation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ContractExecutionRequirement")]
		public ContractExecutionRequirementType[] ContractExecutionRequirement { get; set; }

		/// <remarks/>
		public AwardingTermsType AwardingTerms { get; set; }

		/// <remarks/>
		public PartyType AdditionalInformationParty { get; set; }

		/// <remarks/>
		public PartyType DocumentProviderParty { get; set; }

		/// <remarks/>
		public PartyType TenderRecipientParty { get; set; }

		/// <remarks/>
		public PartyType ContractResponsibleParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TenderEvaluationParty")]
		public PartyType[] TenderEvaluationParty { get; set; }

		/// <remarks/>
		public PeriodType TenderValidityPeriod { get; set; }

		/// <remarks/>
		public PeriodType ContractAcceptancePeriod { get; set; }

		/// <remarks/>
		public AppealTermsType AppealTerms { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Language")]
		public LanguageType[] Language { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BudgetAccountLine")]
		public BudgetAccountLineType[] BudgetAccountLine { get; set; }

		/// <remarks/>
		public DocumentReferenceType ReplacedNoticeDocumentReference { get; set; }
	}
}