namespace GeckoUBL.Ubl21.Miscellaneous
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SignatureProductionPlace", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class SignatureProductionPlaceType {
		/// <remarks/>
		public string City { get; set; }

		/// <remarks/>
		public string StateOrProvince { get; set; }

		/// <remarks/>
		public string PostalCode { get; set; }

		/// <remarks/>
		public string CountryName { get; set; }
	}
}