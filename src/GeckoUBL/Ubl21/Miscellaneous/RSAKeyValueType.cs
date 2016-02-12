namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("RSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class RSAKeyValueType {
    
		private byte[] modulusField;
    
		private byte[] exponentField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] Modulus {
			get {
				return modulusField;
			}
			set {
				modulusField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] Exponent {
			get {
				return exponentField;
			}
			set {
				exponentField = value;
			}
		}
	}
}