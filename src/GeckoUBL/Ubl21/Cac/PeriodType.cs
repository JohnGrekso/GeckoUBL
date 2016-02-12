using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ActivityPeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PeriodType {
    
		private StartDateType startDateField;
    
		private StartTimeType startTimeField;
    
		private EndDateType endDateField;
    
		private EndTimeType endTimeField;
    
		private DurationMeasureType durationMeasureField;
    
		private DescriptionCodeType[] descriptionCodeField;
    
		private DescriptionType[] descriptionField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StartDateType StartDate {
			get {
				return startDateField;
			}
			set {
				startDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public StartTimeType StartTime {
			get {
				return startTimeField;
			}
			set {
				startTimeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EndDateType EndDate {
			get {
				return endDateField;
			}
			set {
				endDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EndTimeType EndTime {
			get {
				return endTimeField;
			}
			set {
				endTimeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DurationMeasureType DurationMeasure {
			get {
				return durationMeasureField;
			}
			set {
				durationMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DescriptionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DescriptionCodeType[] DescriptionCode {
			get {
				return descriptionCodeField;
			}
			set {
				descriptionCodeField = value;
			}
		}
    
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
	}
}