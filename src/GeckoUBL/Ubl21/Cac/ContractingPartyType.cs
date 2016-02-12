using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ContractingParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ContractingPartyType {
    
		private BuyerProfileURIType buyerProfileURIField;
    
		private ContractingPartyTypeType[] contractingPartyType1Field;
    
		private ContractingActivityType[] contractingActivityField;
    
		private PartyType partyField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BuyerProfileURIType BuyerProfileURI {
			get {
				return buyerProfileURIField;
			}
			set {
				buyerProfileURIField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ContractingPartyType")]
		public ContractingPartyTypeType[] ContractingPartyType1 {
			get {
				return contractingPartyType1Field;
			}
			set {
				contractingPartyType1Field = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ContractingActivity")]
		public ContractingActivityType[] ContractingActivity {
			get {
				return contractingActivityField;
			}
			set {
				contractingActivityField = value;
			}
		}
    
		/// <remarks/>
		public PartyType Party {
			get {
				return partyField;
			}
			set {
				partyField = value;
			}
		}
	}
}