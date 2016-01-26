﻿using System;
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
	public class MeasureType
	{
		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCode { get; set; }

		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCodeListVersionID { get; set; }

		/// <remarks/>
		[XmlText()]
		public decimal Value { get; set; }
	}

}
