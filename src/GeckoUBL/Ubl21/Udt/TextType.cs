using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Udt
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(TypeName = "TextType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	public class TextType
	{
		[XmlAttribute(DataType = "language")]
		public string languageID { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string languageLocaleID { get; set; }

		[XmlText]
		public string Value { get; set; }
	}
}