namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("PGPData", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class PGPDataType {
    
		private object[] itemsField;
    
		private ItemsChoiceType1[] itemsElementNameField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute()]
		[System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType="base64Binary")]
		[System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType="base64Binary")]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public object[] Items {
			get {
				return itemsField;
			}
			set {
				itemsField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType1[] ItemsElementName {
			get {
				return itemsElementNameField;
			}
			set {
				itemsElementNameField = value;
			}
		}
	}
}