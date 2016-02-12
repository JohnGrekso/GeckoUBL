using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AuctionTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class AuctionTermsType {
    
		private AuctionConstraintIndicatorType auctionConstraintIndicatorField;
    
		private JustificationDescriptionType[] justificationDescriptionField;
    
		private DescriptionType[] descriptionField;
    
		private ProcessDescriptionType[] processDescriptionField;
    
		private ConditionsDescriptionType[] conditionsDescriptionField;
    
		private ElectronicDeviceDescriptionType[] electronicDeviceDescriptionField;
    
		private AuctionURIType auctionURIField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AuctionConstraintIndicatorType AuctionConstraintIndicator {
			get {
				return auctionConstraintIndicatorField;
			}
			set {
				auctionConstraintIndicatorField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("JustificationDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public JustificationDescriptionType[] JustificationDescription {
			get {
				return justificationDescriptionField;
			}
			set {
				justificationDescriptionField = value;
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
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ProcessDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProcessDescriptionType[] ProcessDescription {
			get {
				return processDescriptionField;
			}
			set {
				processDescriptionField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ConditionsDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ConditionsDescriptionType[] ConditionsDescription {
			get {
				return conditionsDescriptionField;
			}
			set {
				conditionsDescriptionField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ElectronicDeviceDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ElectronicDeviceDescriptionType[] ElectronicDeviceDescription {
			get {
				return electronicDeviceDescriptionField;
			}
			set {
				electronicDeviceDescriptionField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AuctionURIType AuctionURI {
			get {
				return auctionURIField;
			}
			set {
				auctionURIField = value;
			}
		}
	}
}