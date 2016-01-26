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
