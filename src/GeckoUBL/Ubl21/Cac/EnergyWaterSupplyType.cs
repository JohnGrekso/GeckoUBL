namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("EnergyWaterSupply", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class EnergyWaterSupplyType {
    
		private ConsumptionReportType[] consumptionReportField;
    
		private EnergyTaxReportType[] energyTaxReportField;
    
		private ConsumptionAverageType[] consumptionAverageField;
    
		private ConsumptionCorrectionType[] energyWaterConsumptionCorrectionField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ConsumptionReport")]
		public ConsumptionReportType[] ConsumptionReport {
			get {
				return consumptionReportField;
			}
			set {
				consumptionReportField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EnergyTaxReport")]
		public EnergyTaxReportType[] EnergyTaxReport {
			get {
				return energyTaxReportField;
			}
			set {
				energyTaxReportField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ConsumptionAverage")]
		public ConsumptionAverageType[] ConsumptionAverage {
			get {
				return consumptionAverageField;
			}
			set {
				consumptionAverageField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EnergyWaterConsumptionCorrection")]
		public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection {
			get {
				return energyWaterConsumptionCorrectionField;
			}
			set {
				energyWaterConsumptionCorrectionField = value;
			}
		}
	}
}