namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("Any", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class AnyType {
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		public System.Xml.XmlNode[] Any { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyAttributeAttribute()]
		public System.Xml.XmlAttribute[] AnyAttr { get; set; }
	}
}