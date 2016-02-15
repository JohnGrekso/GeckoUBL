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
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot")]
		public ProcurementProjectLotType[] InterestedProcurementProjectLot { get; set; }

		/// <remarks/>
		public QualifyingPartyType MainQualifyingParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty")]
		public QualifyingPartyType[] AdditionalQualifyingParty { get; set; }
	}
}