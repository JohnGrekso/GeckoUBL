using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Udt
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(TypeName = "NumericType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	public class NumericType
	{
		[XmlAttribute]
		public string format { get; set; }

		[XmlText]
		public decimal Value { get; set; }
	}
}