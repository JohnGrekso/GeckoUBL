namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class OCSPRefType {
    
		private OCSPIdentifierType oCSPIdentifierField;
    
		private DigestAlgAndValueType digestAlgAndValueField;
    
		/// <remarks/>
		public OCSPIdentifierType OCSPIdentifier {
			get {
				return oCSPIdentifierField;
			}
			set {
				oCSPIdentifierField = value;
			}
		}
    
		/// <remarks/>
		public DigestAlgAndValueType DigestAlgAndValue {
			get {
				return digestAlgAndValueField;
			}
			set {
				digestAlgAndValueField = value;
			}
		}
	}
}