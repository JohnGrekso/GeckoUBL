using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class SupplierConsumptionType {
    
		private DescriptionType[] descriptionField;
    
		private PartyType utilitySupplierPartyField;
    
		private PartyType utilityCustomerPartyField;
    
		private ConsumptionType consumptionField;
    
		private ContractType contractField;
    
		private ConsumptionLineType[] consumptionLineField;
    
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
		public PartyType UtilitySupplierParty {
			get {
				return utilitySupplierPartyField;
			}
			set {
				utilitySupplierPartyField = value;
			}
		}
    
		/// <remarks/>
		public PartyType UtilityCustomerParty {
			get {
				return utilityCustomerPartyField;
			}
			set {
				utilityCustomerPartyField = value;
			}
		}
    
		/// <remarks/>
		public ConsumptionType Consumption {
			get {
				return consumptionField;
			}
			set {
				consumptionField = value;
			}
		}
    
		/// <remarks/>
		public ContractType Contract {
			get {
				return contractField;
			}
			set {
				contractField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ConsumptionLine")]
		public ConsumptionLineType[] ConsumptionLine {
			get {
				return consumptionLineField;
			}
			set {
				consumptionLineField = value;
			}
		}
	}
}