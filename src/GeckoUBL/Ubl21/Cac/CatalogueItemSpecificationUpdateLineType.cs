using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("CatalogueItemSpecificationUpdateLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class CatalogueItemSpecificationUpdateLineType {
    
		private IDType idField;
    
		private CustomerPartyType contractorCustomerPartyField;
    
		private SupplierPartyType sellerSupplierPartyField;
    
		private ItemType itemField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID {
			get {
				return idField;
			}
			set {
				idField = value;
			}
		}
    
		/// <remarks/>
		public CustomerPartyType ContractorCustomerParty {
			get {
				return contractorCustomerPartyField;
			}
			set {
				contractorCustomerPartyField = value;
			}
		}
    
		/// <remarks/>
		public SupplierPartyType SellerSupplierParty {
			get {
				return sellerSupplierPartyField;
			}
			set {
				sellerSupplierPartyField = value;
			}
		}
    
		/// <remarks/>
		public ItemType Item {
			get {
				return itemField;
			}
			set {
				itemField = value;
			}
		}
	}
}