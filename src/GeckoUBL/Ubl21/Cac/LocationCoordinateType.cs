using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("LocationCoordinate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class LocationCoordinateType {
    
		private CoordinateSystemCodeType coordinateSystemCodeField;
    
		private LatitudeDegreesMeasureType latitudeDegreesMeasureField;
    
		private LatitudeMinutesMeasureType latitudeMinutesMeasureField;
    
		private LatitudeDirectionCodeType latitudeDirectionCodeField;
    
		private LongitudeDegreesMeasureType longitudeDegreesMeasureField;
    
		private LongitudeMinutesMeasureType longitudeMinutesMeasureField;
    
		private LongitudeDirectionCodeType longitudeDirectionCodeField;
    
		private AltitudeMeasureType altitudeMeasureField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CoordinateSystemCodeType CoordinateSystemCode {
			get {
				return coordinateSystemCodeField;
			}
			set {
				coordinateSystemCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatitudeDegreesMeasureType LatitudeDegreesMeasure {
			get {
				return latitudeDegreesMeasureField;
			}
			set {
				latitudeDegreesMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatitudeMinutesMeasureType LatitudeMinutesMeasure {
			get {
				return latitudeMinutesMeasureField;
			}
			set {
				latitudeMinutesMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LatitudeDirectionCodeType LatitudeDirectionCode {
			get {
				return latitudeDirectionCodeField;
			}
			set {
				latitudeDirectionCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LongitudeDegreesMeasureType LongitudeDegreesMeasure {
			get {
				return longitudeDegreesMeasureField;
			}
			set {
				longitudeDegreesMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LongitudeMinutesMeasureType LongitudeMinutesMeasure {
			get {
				return longitudeMinutesMeasureField;
			}
			set {
				longitudeMinutesMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LongitudeDirectionCodeType LongitudeDirectionCode {
			get {
				return longitudeDirectionCodeField;
			}
			set {
				longitudeDirectionCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public AltitudeMeasureType AltitudeMeasure {
			get {
				return altitudeMeasureField;
			}
			set {
				altitudeMeasureField = value;
			}
		}
	}
}