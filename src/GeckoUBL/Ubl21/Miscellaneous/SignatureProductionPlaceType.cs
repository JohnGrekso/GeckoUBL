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
    
		private string cityField;
    
		private string stateOrProvinceField;
    
		private string postalCodeField;
    
		private string countryNameField;
    
		/// <remarks/>
		public string City {
			get {
				return cityField;
			}
			set {
				cityField = value;
			}
		}
    
		/// <remarks/>
		public string StateOrProvince {
			get {
				return stateOrProvinceField;
			}
			set {
				stateOrProvinceField = value;
			}
		}
    
		/// <remarks/>
		public string PostalCode {
			get {
				return postalCodeField;
			}
			set {
				postalCodeField = value;
			}
		}
    
		/// <remarks/>
		public string CountryName {
			get {
				return countryNameField;
			}
			set {
				countryNameField = value;
			}
		}
	}
}