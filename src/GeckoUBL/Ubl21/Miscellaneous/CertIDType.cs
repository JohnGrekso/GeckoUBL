namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class CertIDType {
		/// <remarks/>
		public DigestAlgAndValueType CertDigest { get; set; }

		/// <remarks/>
		public X509IssuerSerialType IssuerSerial { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string URI { get; set; }
	}
}