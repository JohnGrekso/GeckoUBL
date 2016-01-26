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
	public class CodeType
	{
		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string listID { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string listAgencyID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public string listAgencyName { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public string listName { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string listVersionID { get; set; }

		/// <remarks/>
		[XmlAttribute()]
		public string name { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "language")]
		public string languageID { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "anyURI")]
		public string listURI { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "anyURI")]
		public string listSchemeURI { get; set; }

		/// <remarks/>
		[XmlText(DataType = "normalizedString")]
		public string Value { get; set; }
	}
}
