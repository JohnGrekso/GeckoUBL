using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("EndorserParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class EndorserPartyType {
    
		private RoleCodeType roleCodeField;
    
		private SequenceNumericType sequenceNumericField;
    
		private PartyType partyField;
    
		private ContactType signatoryContactField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public RoleCodeType RoleCode {
			get {
				return roleCodeField;
			}
			set {
				roleCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public SequenceNumericType SequenceNumeric {
			get {
				return sequenceNumericField;
			}
			set {
				sequenceNumericField = value;
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
    
		/// <remarks/>
		public ContactType SignatoryContact {
			get {
				return signatoryContactField;
			}
			set {
				signatoryContactField = value;
			}
		}
	}
}