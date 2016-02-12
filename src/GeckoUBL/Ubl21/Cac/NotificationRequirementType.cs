using GeckoUBL.Ubl21.Cbc;

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
    
		private NotificationTypeCodeType notificationTypeCodeField;
    
		private PostEventNotificationDurationMeasureType postEventNotificationDurationMeasureField;
    
		private PreEventNotificationDurationMeasureType preEventNotificationDurationMeasureField;
    
		private PartyType[] notifyPartyField;
    
		private PeriodType[] notificationPeriodField;
    
		private LocationType1[] notificationLocationField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NotificationTypeCodeType NotificationTypeCode {
			get {
				return notificationTypeCodeField;
			}
			set {
				notificationTypeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PostEventNotificationDurationMeasureType PostEventNotificationDurationMeasure {
			get {
				return postEventNotificationDurationMeasureField;
			}
			set {
				postEventNotificationDurationMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PreEventNotificationDurationMeasureType PreEventNotificationDurationMeasure {
			get {
				return preEventNotificationDurationMeasureField;
			}
			set {
				preEventNotificationDurationMeasureField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
		public PartyType[] NotifyParty {
			get {
				return notifyPartyField;
			}
			set {
				notifyPartyField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotificationPeriod")]
		public PeriodType[] NotificationPeriod {
			get {
				return notificationPeriodField;
			}
			set {
				notificationPeriodField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NotificationLocation")]
		public LocationType1[] NotificationLocation {
			get {
				return notificationLocationField;
			}
			set {
				notificationLocationField = value;
			}
		}
	}
}