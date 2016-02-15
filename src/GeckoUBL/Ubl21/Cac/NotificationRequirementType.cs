using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("NotificationRequirement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class NotificationRequirementType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType NotificationTypeCode { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType PostEventNotificationDurationMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MeasureType PreEventNotificationDurationMeasure { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
		public PartyType[] NotifyParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotificationPeriod")]
		public PeriodType[] NotificationPeriod { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotificationLocation")]
		public LocationType1[] NotificationLocation { get; set; }
	}
}