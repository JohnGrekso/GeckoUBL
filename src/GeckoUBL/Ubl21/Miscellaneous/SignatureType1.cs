namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(TypeName="SignatureType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class SignatureType1 {
		/// <remarks/>
		public SignedInfoType SignedInfo { get; set; }

		/// <remarks/>
		public SignatureValueType SignatureValue { get; set; }

		/// <remarks/>
		public KeyInfoType KeyInfo { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Object")]
		public ObjectType[] Object { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}