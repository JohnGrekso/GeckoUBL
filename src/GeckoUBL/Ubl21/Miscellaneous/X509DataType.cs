namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("X509Data", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class X509DataType {
		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		[System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType="base64Binary")]
		[System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType="base64Binary")]
		[System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
		[System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType="base64Binary")]
		[System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public object[] Items { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType[] ItemsElementName { get; set; }
	}
}