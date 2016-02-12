using System.Xml.Serialization;
using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Udt
{
	[XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(TypeName = "BinaryObjectType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	public class BinaryObjectType
	{
		[XmlAttribute]
		public string format { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string mimeCode { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string encodingCode { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string characterSetCode { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string uri { get; set; }

		[XmlAttribute]
		public string filename { get; set; }

		[XmlText(DataType = "base64Binary")]
		public byte[] Value { get; set; }
	}
}