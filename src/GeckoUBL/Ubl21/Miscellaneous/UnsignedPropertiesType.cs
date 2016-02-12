namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("UnsignedProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class UnsignedPropertiesType {
    
		private UnsignedSignaturePropertiesType unsignedSignaturePropertiesField;
    
		private UnsignedDataObjectPropertiesType unsignedDataObjectPropertiesField;
    
		private string idField;
    
		/// <remarks/>
		public UnsignedSignaturePropertiesType UnsignedSignatureProperties {
			get {
				return unsignedSignaturePropertiesField;
			}
			set {
				unsignedSignaturePropertiesField = value;
			}
		}
    
		/// <remarks/>
		public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties {
			get {
				return unsignedDataObjectPropertiesField;
			}
			set {
				unsignedDataObjectPropertiesField = value;
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
	}
}