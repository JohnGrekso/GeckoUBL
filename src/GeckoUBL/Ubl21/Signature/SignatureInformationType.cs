using GeckoUBL.Ubl21.Miscellaneous;
using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Signature
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("SignatureInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2", IsNullable=false)]
	public class SignatureInformationType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
		public ReferencedSignatureIDType ReferencedSignatureID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType1 Signature { get; set; }
	}
}