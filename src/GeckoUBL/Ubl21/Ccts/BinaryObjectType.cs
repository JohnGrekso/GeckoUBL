using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using GeckoUBL.Ubl21.Cbc;
using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Ccts
{
	[XmlInclude(typeof(VideoType))]
	[XmlInclude(typeof(SoundType))]
	[XmlInclude(typeof(PictureType))]
	[XmlInclude(typeof(GraphicType))]
	[XmlInclude(typeof(BinaryObjectType1))]
	[XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
	[GeneratedCode("xsd", "4.0.30319.33440")]
	[Serializable()]
	[DebuggerStepThrough()]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	public class BinaryObjectType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string mimeCode { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string encodingCode { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string characterSetCode { get; set; }

		[XmlAttribute(DataType = "anyURI")]
		public string uri { get; set; }

		[XmlAttribute()]
		public string filename { get; set; }

		[XmlText(DataType = "base64Binary")]
		public byte[] Value { get; set; }
	}
}
