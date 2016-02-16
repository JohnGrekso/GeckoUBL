namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.4.1#")]
	[System.Xml.Serialization.XmlRootAttribute("TimeStampValidationData", Namespace="http://uri.etsi.org/01903/v1.4.1#", IsNullable=false)]
	public class ValidationDataType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
		public CertificateValuesType CertificateValues { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
		public RevocationValuesType RevocationValues { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string UR { get; set; }
	}
}