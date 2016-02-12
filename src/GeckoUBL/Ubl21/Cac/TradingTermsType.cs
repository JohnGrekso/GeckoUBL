using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("HaulageTradingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TradingTermsType {
    
		private InformationType[] informationField;
    
		private ReferenceType referenceField;
    
		private AddressType applicableAddressField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public InformationType[] Information {
			get {
				return informationField;
			}
			set {
				informationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ReferenceType Reference {
			get {
				return referenceField;
			}
			set {
				referenceField = value;
			}
		}
    
		/// <remarks/>
		public AddressType ApplicableAddress {
			get {
				return applicableAddressField;
			}
			set {
				applicableAddressField = value;
			}
		}
	}
}