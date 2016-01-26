using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Ccts
{
	[GeneratedCode("xsd", "4.0.30319.33440")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
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
