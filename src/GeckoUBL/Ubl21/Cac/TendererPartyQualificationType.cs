namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("TendererPartyQualification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TendererPartyQualificationType {
    
		private ProcurementProjectLotType[] interestedProcurementProjectLotField;
    
		private QualifyingPartyType mainQualifyingPartyField;
    
		private QualifyingPartyType[] additionalQualifyingPartyField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot")]
		public ProcurementProjectLotType[] InterestedProcurementProjectLot {
			get {
				return interestedProcurementProjectLotField;
			}
			set {
				interestedProcurementProjectLotField = value;
			}
		}
    
		/// <remarks/>
		public QualifyingPartyType MainQualifyingParty {
			get {
				return mainQualifyingPartyField;
			}
			set {
				mainQualifyingPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty")]
		public QualifyingPartyType[] AdditionalQualifyingParty {
			get {
				return additionalQualifyingPartyField;
			}
			set {
				additionalQualifyingPartyField = value;
			}
		}
	}
}