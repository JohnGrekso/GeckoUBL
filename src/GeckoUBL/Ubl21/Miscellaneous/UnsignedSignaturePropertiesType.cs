namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("UnsignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class UnsignedSignaturePropertiesType {
		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		[System.Xml.Serialization.XmlElementAttribute("ArchiveTimeStamp", typeof(XAdESTimeStampType))]
		[System.Xml.Serialization.XmlElementAttribute("AttrAuthoritiesCertValues", typeof(CertificateValuesType))]
		[System.Xml.Serialization.XmlElementAttribute("AttributeCertificateRefs", typeof(CompleteCertificateRefsType))]
		[System.Xml.Serialization.XmlElementAttribute("AttributeRevocationRefs", typeof(CompleteRevocationRefsType))]
		[System.Xml.Serialization.XmlElementAttribute("AttributeRevocationValues", typeof(RevocationValuesType))]
		[System.Xml.Serialization.XmlElementAttribute("CertificateValues", typeof(CertificateValuesType))]
		[System.Xml.Serialization.XmlElementAttribute("CompleteCertificateRefs", typeof(CompleteCertificateRefsType))]
		[System.Xml.Serialization.XmlElementAttribute("CompleteRevocationRefs", typeof(CompleteRevocationRefsType))]
		[System.Xml.Serialization.XmlElementAttribute("CounterSignature", typeof(CounterSignatureType))]
		[System.Xml.Serialization.XmlElementAttribute("RefsOnlyTimeStamp", typeof(XAdESTimeStampType))]
		[System.Xml.Serialization.XmlElementAttribute("RevocationValues", typeof(RevocationValuesType))]
		[System.Xml.Serialization.XmlElementAttribute("SigAndRefsTimeStamp", typeof(XAdESTimeStampType))]
		[System.Xml.Serialization.XmlElementAttribute("SignatureTimeStamp", typeof(XAdESTimeStampType))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public object[] Items { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType3[] ItemsElementName { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}