using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ForecastExceptionCriterionLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ForecastExceptionCriterionLineType {
    
		private ForecastPurposeCodeType forecastPurposeCodeField;
    
		private ForecastTypeCodeType forecastTypeCodeField;
    
		private ComparisonDataSourceCodeType comparisonDataSourceCodeField;
    
		private DataSourceCodeType dataSourceCodeField;
    
		private TimeDeltaDaysQuantityType timeDeltaDaysQuantityField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ForecastPurposeCodeType ForecastPurposeCode {
			get {
				return forecastPurposeCodeField;
			}
			set {
				forecastPurposeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ForecastTypeCodeType ForecastTypeCode {
			get {
				return forecastTypeCodeField;
			}
			set {
				forecastTypeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ComparisonDataSourceCodeType ComparisonDataSourceCode {
			get {
				return comparisonDataSourceCodeField;
			}
			set {
				comparisonDataSourceCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DataSourceCodeType DataSourceCode {
			get {
				return dataSourceCodeField;
			}
			set {
				dataSourceCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TimeDeltaDaysQuantityType TimeDeltaDaysQuantity {
			get {
				return timeDeltaDaysQuantityField;
			}
			set {
				timeDeltaDaysQuantityField = value;
			}
		}
	}
}