using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AdditionalItemIdentification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ItemIdentificationType {
    
		private IDType idField;
    
		private ExtendedIDType extendedIDField;
    
		private BarcodeSymbologyIDType barcodeSymbologyIDField;
    
		private PhysicalAttributeType[] physicalAttributeField;
    
		private DimensionType[] measurementDimensionField;
    
		private PartyType issuerPartyField;
    
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
		public ExtendedIDType ExtendedID {
			get {
				return extendedIDField;
			}
			set {
				extendedIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BarcodeSymbologyIDType BarcodeSymbologyID {
			get {
				return barcodeSymbologyIDField;
			}
			set {
				barcodeSymbologyIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PhysicalAttribute")]
		public PhysicalAttributeType[] PhysicalAttribute {
			get {
				return physicalAttributeField;
			}
			set {
				physicalAttributeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
		public DimensionType[] MeasurementDimension {
			get {
				return measurementDimensionField;
			}
			set {
				measurementDimensionField = value;
			}
		}
    
		/// <remarks/>
		public PartyType IssuerParty {
			get {
				return issuerPartyField;
			}
			set {
				issuerPartyField = value;
			}
		}
	}
}