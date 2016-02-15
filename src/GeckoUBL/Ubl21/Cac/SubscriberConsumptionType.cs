using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("SubscriberConsumption", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class SubscriberConsumptionType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ConsumptionID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType SpecificationTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Note { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType TotalMeteredQuantity { get; set; }

		/// <remarks/>
		public PartyType SubscriberParty { get; set; }

		/// <remarks/>
		public ConsumptionPointType UtilityConsumptionPoint { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OnAccountPayment")]
		public OnAccountPaymentType[] OnAccountPayment { get; set; }

		/// <remarks/>
		public ConsumptionType Consumption { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SupplierConsumption")]
		public SupplierConsumptionType[] SupplierConsumption { get; set; }
	}
}