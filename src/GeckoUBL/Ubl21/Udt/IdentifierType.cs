using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Udt
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlTypeAttribute(TypeName = "IdentifierType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	public class IdentifierType
	{
		[XmlAttribute(DataType = "normalizedString")]
		public string schemeID { get; set; }

		[XmlAttribute]
		public string schemeName { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string schemeAgencyID { get; set; }

		[XmlAttribute]
		public string schemeAgencyName { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string schemeVersionID { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string schemeDataURI { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string schemeURI { get; set; }

		[XmlText(DataType = "normalizedString")]
		public string Value { get; set; }
	}
}
