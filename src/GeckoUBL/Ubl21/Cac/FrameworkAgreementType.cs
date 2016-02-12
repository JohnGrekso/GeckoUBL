using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("FrameworkAgreement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class FrameworkAgreementType {
    
		private ExpectedOperatorQuantityType expectedOperatorQuantityField;
    
		private MaximumOperatorQuantityType maximumOperatorQuantityField;
    
		private JustificationType[] justificationField;
    
		private FrequencyType[] frequencyField;
    
		private PeriodType durationPeriodField;
    
		private TenderRequirementType[] subsequentProcessTenderRequirementField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExpectedOperatorQuantityType ExpectedOperatorQuantity {
			get {
				return expectedOperatorQuantityField;
			}
			set {
				expectedOperatorQuantityField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MaximumOperatorQuantityType MaximumOperatorQuantity {
			get {
				return maximumOperatorQuantityField;
			}
			set {
				maximumOperatorQuantityField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Justification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public JustificationType[] Justification {
			get {
				return justificationField;
			}
			set {
				justificationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Frequency", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FrequencyType[] Frequency {
			get {
				return frequencyField;
			}
			set {
				frequencyField = value;
			}
		}
    
		/// <remarks/>
		public PeriodType DurationPeriod {
			get {
				return durationPeriodField;
			}
			set {
				durationPeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SubsequentProcessTenderRequirement")]
		public TenderRequirementType[] SubsequentProcessTenderRequirement {
			get {
				return subsequentProcessTenderRequirementField;
			}
			set {
				subsequentProcessTenderRequirementField = value;
			}
		}
	}
}