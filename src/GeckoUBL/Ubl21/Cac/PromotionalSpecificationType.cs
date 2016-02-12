using GeckoUBL.Ubl21.Cbc;

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
    
		private SpecificationIDType specificationIDField;
    
		private PromotionalEventLineItemType[] promotionalEventLineItemField;
    
		private EventTacticType[] eventTacticField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SpecificationIDType SpecificationID {
			get {
				return specificationIDField;
			}
			set {
				specificationIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PromotionalEventLineItem")]
		public PromotionalEventLineItemType[] PromotionalEventLineItem {
			get {
				return promotionalEventLineItemField;
			}
			set {
				promotionalEventLineItemField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EventTactic")]
		public EventTacticType[] EventTactic {
			get {
				return eventTacticField;
			}
			set {
				eventTacticField = value;
			}
		}
	}
}