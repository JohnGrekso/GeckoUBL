namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class DocumentationReferencesType {
    
		private string[] documentationReferenceField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentationReference", DataType="anyURI")]
		public string[] DocumentationReference {
			get {
				return documentationReferenceField;
			}
			set {
				documentationReferenceField = value;
			}
		}
	}
}