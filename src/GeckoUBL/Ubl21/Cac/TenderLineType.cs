using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("SubTenderLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TenderLineType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Note { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType Quantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType LineExtensionAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType TotalTaxAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType OrderableUnit { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType ContentUnitQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NumericType OrderQuantityIncrementNumeric { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType MinimumOrderQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType MaximumOrderQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] WarrantyInformation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PackLevelCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
		public DocumentReferenceType[] DocumentReference { get; set; }

		/// <remarks/>
		public ItemType Item { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity")]
		public ItemLocationQuantityType[] OfferedItemLocationQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
		public RelatedItemType[] ReplacementRelatedItem { get; set; }

		/// <remarks/>
		public PartyType WarrantyParty { get; set; }

		/// <remarks/>
		public PeriodType WarrantyValidityPeriod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SubTenderLine")]
		public TenderLineType[] SubTenderLine { get; set; }

		/// <remarks/>
		public LineReferenceType CallForTendersLineReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType CallForTendersDocumentReference { get; set; }
	}
}