namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("SPKIData", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class SPKIDataType {
    
		private byte[][] sPKISexpField;
    
		private System.Xml.XmlElement anyField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType="base64Binary")]
		public byte[][] SPKISexp {
			get {
				return sPKISexpField;
			}
			set {
				sPKISexpField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		public System.Xml.XmlElement Any {
			get {
				return anyField;
			}
			set {
				anyField = value;
			}
		}
	}
}