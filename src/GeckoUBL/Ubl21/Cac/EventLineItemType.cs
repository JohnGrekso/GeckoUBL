using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("EventLineItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class EventLineItemType {
    
		private LineNumberNumericType lineNumberNumericField;
    
		private LocationType1 participatingLocationsLocationField;
    
		private RetailPlannedImpactType[] retailPlannedImpactField;
    
		private ItemType supplyItemField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public LineNumberNumericType LineNumberNumeric {
			get {
				return lineNumberNumericField;
			}
			set {
				lineNumberNumericField = value;
			}
		}
    
		/// <remarks/>
		public LocationType1 ParticipatingLocationsLocation {
			get {
				return participatingLocationsLocationField;
			}
			set {
				participatingLocationsLocationField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RetailPlannedImpact")]
		public RetailPlannedImpactType[] RetailPlannedImpact {
			get {
				return retailPlannedImpactField;
			}
			set {
				retailPlannedImpactField = value;
			}
		}
    
		/// <remarks/>
		public ItemType SupplyItem {
			get {
				return supplyItemField;
			}
			set {
				supplyItemField = value;
			}
		}
	}
}