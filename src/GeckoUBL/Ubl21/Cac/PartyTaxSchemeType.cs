using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("PartyTaxScheme", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PartyTaxSchemeType {
    
		private RegistrationNameType registrationNameField;
    
		private CompanyIDType companyIDField;
    
		private TaxLevelCodeType taxLevelCodeField;
    
		private ExemptionReasonCodeType exemptionReasonCodeField;
    
		private ExemptionReasonType[] exemptionReasonField;
    
		private AddressType registrationAddressField;
    
		private TaxSchemeType taxSchemeField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RegistrationNameType RegistrationName {
			get {
				return registrationNameField;
			}
			set {
				registrationNameField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CompanyIDType CompanyID {
			get {
				return companyIDField;
			}
			set {
				companyIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxLevelCodeType TaxLevelCode {
			get {
				return taxLevelCodeField;
			}
			set {
				taxLevelCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExemptionReasonCodeType ExemptionReasonCode {
			get {
				return exemptionReasonCodeField;
			}
			set {
				exemptionReasonCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ExemptionReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExemptionReasonType[] ExemptionReason {
			get {
				return exemptionReasonField;
			}
			set {
				exemptionReasonField = value;
			}
		}
    
		/// <remarks/>
		public AddressType RegistrationAddress {
			get {
				return registrationAddressField;
			}
			set {
				registrationAddressField = value;
			}
		}
    
		/// <remarks/>
		public TaxSchemeType TaxScheme {
			get {
				return taxSchemeField;
			}
			set {
				taxSchemeField = value;
			}
		}
	}
}