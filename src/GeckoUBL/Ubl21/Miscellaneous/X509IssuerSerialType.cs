namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	public class X509IssuerSerialType {
		/// <remarks/>
		public string X509IssuerName { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
		public string X509SerialNumber { get; set; }
	}
}