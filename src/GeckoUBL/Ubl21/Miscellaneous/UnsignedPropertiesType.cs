namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("UnsignedProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class UnsignedPropertiesType {
		/// <remarks/>
		public UnsignedSignaturePropertiesType UnsignedSignatureProperties { get; set; }

		/// <remarks/>
		public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}