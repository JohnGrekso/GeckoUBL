using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using GeckoUBL.Ubl21.Cbc;
using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Ccts
{
	/// <remarks/>
	[XmlInclude(typeof(MeasureType1))]
	[XmlInclude(typeof(ValueMeasureType))]
	[XmlInclude(typeof(TareWeightMeasureType))]
	[XmlInclude(typeof(SourceValueMeasureType))]
	[XmlInclude(typeof(PreEventNotificationDurationMeasureType))]
	[XmlInclude(typeof(PostEventNotificationDurationMeasureType))]
	[XmlInclude(typeof(NetWeightMeasureType))]
	[XmlInclude(typeof(NetVolumeMeasureType))]
	[XmlInclude(typeof(NetTonnageMeasureType))]
	[XmlInclude(typeof(NetNetWeightMeasureType))]
	[XmlInclude(typeof(MinimumMeasureType))]
	[XmlInclude(typeof(MeasureType2))]
	[XmlInclude(typeof(MaximumMeasureType))]
	[XmlInclude(typeof(LongitudeMinutesMeasureType))]
	[XmlInclude(typeof(LongitudeDegreesMeasureType))]
	[XmlInclude(typeof(LoadingLengthMeasureType))]
	[XmlInclude(typeof(LeadTimeMeasureType))]
	[XmlInclude(typeof(LatitudeMinutesMeasureType))]
	[XmlInclude(typeof(LatitudeDegreesMeasureType))]
	[XmlInclude(typeof(GrossWeightMeasureType))]
	[XmlInclude(typeof(GrossVolumeMeasureType))]
	[XmlInclude(typeof(GrossTonnageMeasureType))]
	[XmlInclude(typeof(DurationMeasureType))]
	[XmlInclude(typeof(ComparedValueMeasureType))]
	[XmlInclude(typeof(ChargeableWeightMeasureType))]
	[XmlInclude(typeof(BaseUnitMeasureType))]
	[XmlInclude(typeof(AltitudeMeasureType))]
	[GeneratedCode("xsd", "4.0.30319.33440")]
	[Serializable()]
	[DebuggerStepThrough()]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	public class MeasureType
	{

		private string unitCodeField;

		private string unitCodeListVersionIDField;

		private decimal valueField;

		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCode
		{
			get
			{
				return this.unitCodeField;
			}
			set
			{
				this.unitCodeField = value;
			}
		}

		/// <remarks/>
		[XmlAttribute(DataType = "normalizedString")]
		public string unitCodeListVersionID
		{
			get
			{
				return this.unitCodeListVersionIDField;
			}
			set
			{
				this.unitCodeListVersionIDField = value;
			}
		}

		/// <remarks/>
		[XmlText()]
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

}
