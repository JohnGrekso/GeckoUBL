namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("SignatureValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class SignatureValueType {
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
		public byte[] Value { get; set; }
	}
}