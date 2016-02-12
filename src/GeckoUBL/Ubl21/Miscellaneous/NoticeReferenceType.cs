namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class NoticeReferenceType {
    
		private string organizationField;
    
		private string[] noticeNumbersField;
    
		/// <remarks/>
		public string Organization {
			get {
				return organizationField;
			}
			set {
				organizationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("int", DataType="integer", IsNullable=false)]
		public string[] NoticeNumbers {
			get {
				return noticeNumbersField;
			}
			set {
				noticeNumbersField = value;
			}
		}
	}
}