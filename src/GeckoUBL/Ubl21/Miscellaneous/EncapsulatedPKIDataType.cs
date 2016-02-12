namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("EncapsulatedPKIData", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class EncapsulatedPKIDataType {
    
		private string idField;
    
		private string encodingField;
    
		private byte[] valueField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id {
			get {
				return idField;
			}
			set {
				idField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string Encoding {
			get {
				return encodingField;
			}
			set {
				encodingField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
		public byte[] Value {
			get {
				return valueField;
			}
			set {
				valueField = value;
			}
		}
	}
}