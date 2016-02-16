namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public abstract class GenericTimeStampType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType))]
		[System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
		public object[] Items { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
		public CanonicalizationMethodType1 CanonicalizationMethod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
		[System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
		public object[] Items1 { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}