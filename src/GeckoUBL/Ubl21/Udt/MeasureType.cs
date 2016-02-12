using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Udt
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(TypeName = "MeasureType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	public class MeasureType
	{
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCode { get; set; }

		[XmlAttribute(DataType = "normalizedString")]
		public string unitCodeListVersionID { get; set; }

		[XmlText]
		public decimal Value { get; set; }
	}
}