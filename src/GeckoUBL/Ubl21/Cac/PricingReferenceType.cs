namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("PricingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PricingReferenceType {
    
		private ItemLocationQuantityType originalItemLocationQuantityField;
    
		private PriceType[] alternativeConditionPriceField;
    
		/// <remarks/>
		public ItemLocationQuantityType OriginalItemLocationQuantity {
			get {
				return originalItemLocationQuantityField;
			}
			set {
				originalItemLocationQuantityField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice")]
		public PriceType[] AlternativeConditionPrice {
			get {
				return alternativeConditionPriceField;
			}
			set {
				alternativeConditionPriceField = value;
			}
		}
	}
}