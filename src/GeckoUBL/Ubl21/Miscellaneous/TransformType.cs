namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("Transform", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class TransformType {
    
		private object[] itemsField;
    
		private string[] textField;
    
		private string algorithmField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		[System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
		public object[] Items {
			get {
				return itemsField;
			}
			set {
				itemsField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string[] Text {
			get {
				return textField;
			}
			set {
				textField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string Algorithm {
			get {
				return algorithmField;
			}
			set {
				algorithmField = value;
			}
		}
	}
}