namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class ResponderIDType {
    
		private object itemField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ByKey", typeof(byte[]), DataType="base64Binary")]
		[System.Xml.Serialization.XmlElementAttribute("ByName", typeof(string))]
		public object Item {
			get {
				return itemField;
			}
			set {
				itemField = value;
			}
		}
	}
}