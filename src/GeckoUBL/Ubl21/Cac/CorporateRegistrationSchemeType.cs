using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("CorporateRegistrationScheme", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class CorporateRegistrationSchemeType {
    
		private IDType idField;
    
		private NameType1 nameField;
    
		private CorporateRegistrationTypeCodeType corporateRegistrationTypeCodeField;
    
		private AddressType[] jurisdictionRegionAddressField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID {
			get {
				return idField;
			}
			set {
				idField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1 Name {
			get {
				return nameField;
			}
			set {
				nameField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode {
			get {
				return corporateRegistrationTypeCodeField;
			}
			set {
				corporateRegistrationTypeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("JurisdictionRegionAddress")]
		public AddressType[] JurisdictionRegionAddress {
			get {
				return jurisdictionRegionAddressField;
			}
			set {
				jurisdictionRegionAddressField = value;
			}
		}
	}
}