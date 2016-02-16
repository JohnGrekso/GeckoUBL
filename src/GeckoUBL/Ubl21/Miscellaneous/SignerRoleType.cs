namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SignerRole", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class SignerRoleType {
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("ClaimedRole", IsNullable=false)]
		public AnyType[] ClaimedRoles { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("CertifiedRole", IsNullable=false)]
		public EncapsulatedPKIDataType[] CertifiedRoles { get; set; }
	}
}