namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName="IdentifierType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class IdentifierType2 {
    
		private QualifierType qualifierField;
    
		private bool qualifierFieldSpecified;
    
		private string valueField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public QualifierType Qualifier {
			get {
				return qualifierField;
			}
			set {
				qualifierField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool QualifierSpecified {
			get {
				return qualifierFieldSpecified;
			}
			set {
				qualifierFieldSpecified = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
		public string Value {
			get {
				return valueField;
			}
			set {
				valueField = value;
			}
		}
	}
}