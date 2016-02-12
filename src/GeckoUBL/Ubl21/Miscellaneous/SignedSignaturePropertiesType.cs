namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class SignedSignaturePropertiesType {
    
		private System.DateTime signingTimeField;
    
		private bool signingTimeFieldSpecified;
    
		private CertIDType[] signingCertificateField;
    
		private SignaturePolicyIdentifierType signaturePolicyIdentifierField;
    
		private SignatureProductionPlaceType signatureProductionPlaceField;
    
		private SignerRoleType signerRoleField;
    
		private string idField;
    
		/// <remarks/>
		public System.DateTime SigningTime {
			get {
				return signingTimeField;
			}
			set {
				signingTimeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SigningTimeSpecified {
			get {
				return signingTimeFieldSpecified;
			}
			set {
				signingTimeFieldSpecified = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
		public CertIDType[] SigningCertificate {
			get {
				return signingCertificateField;
			}
			set {
				signingCertificateField = value;
			}
		}
    
		/// <remarks/>
		public SignaturePolicyIdentifierType SignaturePolicyIdentifier {
			get {
				return signaturePolicyIdentifierField;
			}
			set {
				signaturePolicyIdentifierField = value;
			}
		}
    
		/// <remarks/>
		public SignatureProductionPlaceType SignatureProductionPlace {
			get {
				return signatureProductionPlaceField;
			}
			set {
				signatureProductionPlaceField = value;
			}
		}
    
		/// <remarks/>
		public SignerRoleType SignerRole {
			get {
				return signerRoleField;
			}
			set {
				signerRoleField = value;
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