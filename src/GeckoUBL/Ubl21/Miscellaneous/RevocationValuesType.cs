namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("RevocationValues", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class RevocationValuesType {
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
		public EncapsulatedPKIDataType[] CRLValues { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
		public EncapsulatedPKIDataType[] OCSPValues { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable=false)]
		public AnyType[] OtherValues { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}