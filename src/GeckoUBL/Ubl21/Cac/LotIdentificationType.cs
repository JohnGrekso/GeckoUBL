using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("LotIdentification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class LotIdentificationType {
    
		private LotNumberIDType lotNumberIDField;
    
		private ExpiryDateType expiryDateField;
    
		private ItemPropertyType[] additionalItemPropertyField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LotNumberIDType LotNumberID {
			get {
				return lotNumberIDField;
			}
			set {
				lotNumberIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpiryDateType ExpiryDate {
			get {
				return expiryDateField;
			}
			set {
				expiryDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
		public ItemPropertyType[] AdditionalItemProperty {
			get {
				return additionalItemPropertyField;
			}
			set {
				additionalItemPropertyField = value;
			}
		}
	}
}