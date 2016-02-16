namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class SignedDataObjectPropertiesType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DataObjectFormat")]
		public DataObjectFormatType[] DataObjectFormat { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication")]
		public CommitmentTypeIndicationType[] CommitmentTypeIndication { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp")]
		public XAdESTimeStampType[] AllDataObjectsTimeStamp { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp")]
		public XAdESTimeStampType[] IndividualDataObjectsTimeStamp { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}
}