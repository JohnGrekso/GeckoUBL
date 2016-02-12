using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("MiscellaneousEvent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class MiscellaneousEventType {
    
		private MiscellaneousEventTypeCodeType miscellaneousEventTypeCodeField;
    
		private EventLineItemType[] eventLineItemField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public MiscellaneousEventTypeCodeType MiscellaneousEventTypeCode {
			get {
				return miscellaneousEventTypeCodeField;
			}
			set {
				miscellaneousEventTypeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EventLineItem")]
		public EventLineItemType[] EventLineItem {
			get {
				return eventLineItemField;
			}
			set {
				eventLineItemField = value;
			}
		}
	}
}