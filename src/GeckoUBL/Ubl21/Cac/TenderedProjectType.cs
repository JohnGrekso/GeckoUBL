using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AwardedTenderedProject", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TenderedProjectType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType VariantID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType FeeAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] FeeDescription { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType TenderEnvelopeID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType TenderEnvelopeTypeCode { get; set; }

		/// <remarks/>
		public ProcurementProjectLotType ProcurementProjectLot { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EvidenceDocumentReference")]
		public DocumentReferenceType[] EvidenceDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
		public TaxTotalType[] TaxTotal { get; set; }

		/// <remarks/>
		public MonetaryTotalType LegalMonetaryTotal { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TenderLine")]
		public TenderLineType[] TenderLine { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AwardingCriterionResponse")]
		public AwardingCriterionResponseType[] AwardingCriterionResponse { get; set; }
	}
}