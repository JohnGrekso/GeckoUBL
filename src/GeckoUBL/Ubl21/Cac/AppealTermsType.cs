using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AppealTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class AppealTermsType {
    
		private DescriptionType[] descriptionField;
    
		private PeriodType presentationPeriodField;
    
		private PartyType appealInformationPartyField;
    
		private PartyType appealReceiverPartyField;
    
		private PartyType mediationPartyField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionType[] Description {
			get {
				return descriptionField;
			}
			set {
				descriptionField = value;
			}
		}
    
		/// <remarks/>
		public PeriodType PresentationPeriod {
			get {
				return presentationPeriodField;
			}
			set {
				presentationPeriodField = value;
			}
		}
    
		/// <remarks/>
		public PartyType AppealInformationParty {
			get {
				return appealInformationPartyField;
			}
			set {
				appealInformationPartyField = value;
			}
		}
    
		/// <remarks/>
		public PartyType AppealReceiverParty {
			get {
				return appealReceiverPartyField;
			}
			set {
				appealReceiverPartyField = value;
			}
		}
    
		/// <remarks/>
		public PartyType MediationParty {
			get {
				return mediationPartyField;
			}
			set {
				mediationPartyField = value;
			}
		}
	}
}