namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("DataObjectFormat", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class DataObjectFormatType {
		/// <remarks/>
		public string Description { get; set; }

		/// <remarks/>
		public ObjectIdentifierType ObjectIdentifier { get; set; }

		/// <remarks/>
		public string MimeType { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
		public string Encoding { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string ObjectReference { get; set; }
	}
}