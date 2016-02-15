using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("OrderLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class OrderLineType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType SubstitutionStatusCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Note { get; set; }

		/// <remarks/>
		public LineItemType LineItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem")]
		public LineItemType[] SellerProposedSubstituteLineItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem")]
		public LineItemType[] SellerSubstitutedLineItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem")]
		public LineItemType[] BuyerProposedSubstituteLineItem { get; set; }

		/// <remarks/>
		public LineReferenceType CatalogueLineReference { get; set; }

		/// <remarks/>
		public LineReferenceType QuotationLineReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
		public OrderLineReferenceType[] OrderLineReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
		public DocumentReferenceType[] DocumentReference { get; set; }
	}
}