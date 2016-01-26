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
