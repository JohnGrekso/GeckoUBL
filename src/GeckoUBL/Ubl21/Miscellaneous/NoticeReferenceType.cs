namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class NoticeReferenceType {
		/// <remarks/>
		public string Organization { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("int", DataType="integer", IsNullable=false)]
		public string[] NoticeNumbers { get; set; }
	}
}