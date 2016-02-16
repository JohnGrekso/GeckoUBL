namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("DSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class DSAKeyValueType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] P { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] Q { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] G { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] Y { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] J { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] Seed { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
		public byte[] PgenCounter { get; set; }
	}
}