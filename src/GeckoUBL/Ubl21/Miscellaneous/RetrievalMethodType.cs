namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("RetrievalMethod", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class RetrievalMethodType {
    
		private TransformType[] transformsField;
    
		private string uRIField;
    
		private string typeField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
		public TransformType[] Transforms {
			get {
				return transformsField;
			}
			set {
				transformsField = value;
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
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string Type {
			get {
				return typeField;
			}
			set {
				typeField = value;
			}
		}
	}
}