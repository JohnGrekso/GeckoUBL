namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("ObjectIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class ObjectIdentifierType {
    
		private IdentifierType2 identifierField;
    
		private string descriptionField;
    
		private DocumentationReferencesType documentationReferencesField;
    
		/// <remarks/>
		public IdentifierType2 Identifier {
			get {
				return identifierField;
			}
			set {
				identifierField = value;
			}
		}
    
		/// <remarks/>
		public string Description {
			get {
				return descriptionField;
			}
			set {
				descriptionField = value;
			}
		}
    
		/// <remarks/>
		public DocumentationReferencesType DocumentationReferences {
			get {
				return documentationReferencesField;
			}
			set {
				documentationReferencesField = value;
			}
		}
	}
}