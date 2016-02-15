using GeckoUBL.Ubl21.Udt;

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
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NumericType LineNumberNumeric { get; set; }

		/// <remarks/>
		public LocationType1 ParticipatingLocationsLocation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RetailPlannedImpact")]
		public RetailPlannedImpactType[] RetailPlannedImpact { get; set; }

		/// <remarks/>
		public ItemType SupplyItem { get; set; }
	}
}