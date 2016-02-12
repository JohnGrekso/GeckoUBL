using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("WorkPhaseReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class WorkPhaseReferenceType {
    
		private IDType idField;
    
		private WorkPhaseCodeType workPhaseCodeField;
    
		private WorkPhaseType[] workPhaseField;
    
		private ProgressPercentType progressPercentField;
    
		private StartDateType startDateField;
    
		private EndDateType endDateField;
    
		private DocumentReferenceType[] workOrderDocumentReferenceField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID {
			get {
				return idField;
			}
			set {
				idField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WorkPhaseCodeType WorkPhaseCode {
			get {
				return workPhaseCodeField;
			}
			set {
				workPhaseCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("WorkPhase", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public WorkPhaseType[] WorkPhase {
			get {
				return workPhaseField;
			}
			set {
				workPhaseField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProgressPercentType ProgressPercent {
			get {
				return progressPercentField;
			}
			set {
				progressPercentField = value;
			}
		}
    
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
		public EndDateType EndDate {
			get {
				return endDateField;
			}
			set {
				endDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("WorkOrderDocumentReference")]
		public DocumentReferenceType[] WorkOrderDocumentReference {
			get {
				return workOrderDocumentReferenceField;
			}
			set {
				workOrderDocumentReferenceField = value;
			}
		}
	}
}