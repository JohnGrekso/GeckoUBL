namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SignaturePolicyIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class SignaturePolicyIdentifierType {
    
		private object itemField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SignaturePolicyId", typeof(SignaturePolicyIdType))]
		[System.Xml.Serialization.XmlElementAttribute("SignaturePolicyImplied", typeof(object))]
		public object Item {
			get {
				return itemField;
			}
			set {
				itemField = value;
			}
		}
	}
}