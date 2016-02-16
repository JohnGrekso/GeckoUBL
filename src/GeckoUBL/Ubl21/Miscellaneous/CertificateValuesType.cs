namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("CertificateValues", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class CertificateValuesType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType))]
		[System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(AnyType))]
		public object[] Items { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}