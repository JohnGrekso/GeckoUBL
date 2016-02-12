using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("QualificationResolution", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class QualificationResolutionType {
    
		private AdmissionCodeType admissionCodeField;
    
		private ExclusionReasonType[] exclusionReasonField;
    
		private ResolutionType[] resolutionField;
    
		private ResolutionDateType resolutionDateField;
    
		private ResolutionTimeType resolutionTimeField;
    
		private ProcurementProjectLotType procurementProjectLotField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AdmissionCodeType AdmissionCode {
			get {
				return admissionCodeField;
			}
			set {
				admissionCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ExclusionReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ExclusionReasonType[] ExclusionReason {
			get {
				return exclusionReasonField;
			}
			set {
				exclusionReasonField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Resolution", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResolutionType[] Resolution {
			get {
				return resolutionField;
			}
			set {
				resolutionField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResolutionDateType ResolutionDate {
			get {
				return resolutionDateField;
			}
			set {
				resolutionDateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ResolutionTimeType ResolutionTime {
			get {
				return resolutionTimeField;
			}
			set {
				resolutionTimeField = value;
			}
		}
    
		/// <remarks/>
		public ProcurementProjectLotType ProcurementProjectLot {
			get {
				return procurementProjectLotField;
			}
			set {
				procurementProjectLotField = value;
			}
		}
	}
}