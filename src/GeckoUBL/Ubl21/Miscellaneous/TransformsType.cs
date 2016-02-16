namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
	[System.Xml.Serialization.XmlRootAttribute("Transforms", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
	public class TransformsType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Transform")]
		public TransformType[] Transform { get; set; }
	}
}