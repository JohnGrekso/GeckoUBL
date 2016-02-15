using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("DebitNoteLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class DebitNoteLineType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType UUID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Note { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType DebitedQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AmountType LineExtensionAmount { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DateType TaxPointDate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType AccountingCostCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType AccountingCost { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType PaymentPurposeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
		public ResponseType[] DiscrepancyResponse { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
		public LineReferenceType[] DespatchLineReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
		public LineReferenceType[] ReceiptLineReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BillingReference")]
		public BillingReferenceType[] BillingReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
		public DocumentReferenceType[] DocumentReference { get; set; }

		/// <remarks/>
		public PricingReferenceType PricingReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Delivery")]
		public DeliveryType[] Delivery { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
		public TaxTotalType[] TaxTotal { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
		public AllowanceChargeType[] AllowanceCharge { get; set; }

		/// <remarks/>
		public ItemType Item { get; set; }

		/// <remarks/>
		public PriceType Price { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SubDebitNoteLine")]
		public DebitNoteLineType[] SubDebitNoteLine { get; set; }
	}
}