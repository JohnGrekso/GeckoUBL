namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("KeyInfo", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class KeyInfoType {
		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		[System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
		[System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
		[System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
		[System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
		[System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public object[] Items { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType2[] ItemsElementName { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string[] Text { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}