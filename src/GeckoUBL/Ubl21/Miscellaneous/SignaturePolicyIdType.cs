namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	public class SignaturePolicyIdType {
		/// <remarks/>
		public ObjectIdentifierType SigPolicyId { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
		[System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
		public TransformType[] Transforms { get; set; }

		/// <remarks/>
		public DigestAlgAndValueType SigPolicyHash { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("SigPolicyQualifier", IsNullable=false)]
		public AnyType[] SigPolicyQualifiers { get; set; }
	}
}