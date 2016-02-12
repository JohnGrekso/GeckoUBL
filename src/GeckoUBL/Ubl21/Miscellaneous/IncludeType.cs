namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("Include", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class IncludeType {
    
		private string uRIField;
    
		private bool referencedDataField;
    
		private bool referencedDataFieldSpecified;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string URI {
			get {
				return uRIField;
			}
			set {
				uRIField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool referencedData {
			get {
				return referencedDataField;
			}
			set {
				referencedDataField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool referencedDataSpecified {
			get {
				return referencedDataFieldSpecified;
			}
			set {
				referencedDataFieldSpecified = value;
			}
		}
	}
}