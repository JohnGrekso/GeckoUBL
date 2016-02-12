namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("ReferenceInfo", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class ReferenceInfoType {
    
		private DigestMethodType digestMethodField;
    
		private byte[] digestValueField;
    
		private string idField;
    
		private string uRIField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
		public DigestMethodType DigestMethod {
			get {
				return digestMethodField;
			}
			set {
				digestMethodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
		public byte[] DigestValue {
			get {
				return digestValueField;
			}
			set {
				digestValueField = value;
			}
		}
    
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
		public string URI {
			get {
				return uRIField;
			}
			set {
				uRIField = value;
			}
		}
	}
}