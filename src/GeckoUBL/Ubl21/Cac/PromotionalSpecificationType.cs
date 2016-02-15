using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("PromotionalSpecification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PromotionalSpecificationType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType SpecificationID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PromotionalEventLineItem")]
		public PromotionalEventLineItemType[] PromotionalEventLineItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EventTactic")]
		public EventTacticType[] EventTactic { get; set; }
	}
}