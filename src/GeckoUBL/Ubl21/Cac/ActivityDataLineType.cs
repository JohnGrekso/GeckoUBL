using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ActivityDataLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ActivityDataLineType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IdentifierType ID { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CodeType SupplyChainActivityTypeCode { get; set; }

		/// <remarks/>
		public CustomerPartyType BuyerCustomerParty { get; set; }

		/// <remarks/>
		public SupplierPartyType SellerSupplierParty { get; set; }

		/// <remarks/>
		public PeriodType ActivityPeriod { get; set; }

		/// <remarks/>
		public LocationType1 ActivityOriginLocation { get; set; }

		/// <remarks/>
		public LocationType1 ActivityFinalLocation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SalesItem")]
		public SalesItemType[] SalesItem { get; set; }
	}
}