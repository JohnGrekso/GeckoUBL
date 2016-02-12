using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("EventTactic", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class EventTacticType {
    
		private CommentType commentField;
    
		private QuantityType2 quantityField;
    
		private EventTacticEnumerationType eventTacticEnumerationField;
    
		private PeriodType periodField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CommentType Comment {
			get {
				return commentField;
			}
			set {
				commentField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType2 Quantity {
			get {
				return quantityField;
			}
			set {
				quantityField = value;
			}
		}
    
		/// <remarks/>
		public EventTacticEnumerationType EventTacticEnumeration {
			get {
				return eventTacticEnumerationField;
			}
			set {
				eventTacticEnumerationField = value;
			}
		}
    
		/// <remarks/>
		public PeriodType Period {
			get {
				return periodField;
			}
			set {
				periodField = value;
			}
		}
	}
}