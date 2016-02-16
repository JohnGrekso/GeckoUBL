namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("SignedInfo", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class SignedInfoType {
		/// <remarks/>
		public CanonicalizationMethodType1 CanonicalizationMethod { get; set; }

		/// <remarks/>
		public SignatureMethodType1 SignatureMethod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Reference")]
		public ReferenceType1[] Reference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}