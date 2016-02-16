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
		/// <remarks/>
		public System.DateTime SigningTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SigningTimeSpecified { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
		public CertIDType[] SigningCertificate { get; set; }

		/// <remarks/>
		public SignaturePolicyIdentifierType SignaturePolicyIdentifier { get; set; }

		/// <remarks/>
		public SignatureProductionPlaceType SignatureProductionPlace { get; set; }

		/// <remarks/>
		public SignerRoleType SignerRole { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}