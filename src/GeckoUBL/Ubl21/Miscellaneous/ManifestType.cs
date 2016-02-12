namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class ManifestType {
    
		private ReferenceType1[] referenceField;
    
		private string idField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Reference")]
		public ReferenceType1[] Reference {
			get {
				return referenceField;
			}
			set {
				referenceField = value;
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