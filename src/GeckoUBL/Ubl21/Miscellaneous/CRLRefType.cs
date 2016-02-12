namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class CRLRefType {
    
		private DigestAlgAndValueType digestAlgAndValueField;
    
		private CRLIdentifierType cRLIdentifierField;
    
		/// <remarks/>
		public DigestAlgAndValueType DigestAlgAndValue {
			get {
				return digestAlgAndValueField;
			}
			set {
				digestAlgAndValueField = value;
			}
		}
    
		/// <remarks/>
		public CRLIdentifierType CRLIdentifier {
			get {
				return cRLIdentifierField;
			}
			set {
				cRLIdentifierField = value;
			}
		}
	}
}