namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName="CanonicalizationMethodType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("CanonicalizationMethod", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class CanonicalizationMethodType1 {
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		public System.Xml.XmlNode[] Any { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string Algorithm { get; set; }
	}
}