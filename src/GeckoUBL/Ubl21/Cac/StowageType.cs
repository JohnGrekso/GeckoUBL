using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("Stowage", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class StowageType {
    
		private LocationIDType locationIDField;
    
		private LocationType[] locationField;
    
		private DimensionType[] measurementDimensionField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LocationIDType LocationID {
			get {
				return locationIDField;
			}
			set {
				locationIDField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Location", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LocationType[] Location {
			get {
				return locationField;
			}
			set {
				locationField = value;
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
	}
}