namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("SignedInfo", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class SignedInfoType {
    
		private CanonicalizationMethodType1 canonicalizationMethodField;
    
		private SignatureMethodType1 signatureMethodField;
    
		private ReferenceType1[] referenceField;
    
		private string idField;
    
		/// <remarks/>
		public CanonicalizationMethodType1 CanonicalizationMethod {
			get {
				return canonicalizationMethodField;
			}
			set {
				canonicalizationMethodField = value;
			}
		}
    
		/// <remarks/>
		public SignatureMethodType1 SignatureMethod {
			get {
				return signatureMethodField;
			}
			set {
				signatureMethodField = value;
			}
		}
    
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