namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("BillingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class BillingReferenceType {
		/// <remarks/>
		public DocumentReferenceType InvoiceDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType SelfBilledInvoiceDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType CreditNoteDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType SelfBilledCreditNoteDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType DebitNoteDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType ReminderDocumentReference { get; set; }

		/// <remarks/>
		public DocumentReferenceType AdditionalDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine")]
		public BillingReferenceLineType[] BillingReferenceLine { get; set; }
	}
}