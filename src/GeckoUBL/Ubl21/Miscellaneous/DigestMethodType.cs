namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("DigestMethod", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class DigestMethodType {
    
		private System.Xml.XmlNode[] anyField;
    
		private string algorithmField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		public System.Xml.XmlNode[] Any {
			get {
				return anyField;
			}
			set {
				anyField = value;
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