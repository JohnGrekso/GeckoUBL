using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("TradeFinancing", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class TradeFinancingType {
    
		private IDType idField;
    
		private FinancingInstrumentCodeType financingInstrumentCodeField;
    
		private DocumentReferenceType contractDocumentReferenceField;
    
		private DocumentReferenceType[] documentReferenceField;
    
		private PartyType financingPartyField;
    
		private FinancialAccountType financingFinancialAccountField;
    
		private ClauseType[] clauseField;
    
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public FinancingInstrumentCodeType FinancingInstrumentCode {
			get {
				return financingInstrumentCodeField;
			}
			set {
				financingInstrumentCodeField = value;
			}
		}
    
		/// <remarks/>
		public DocumentReferenceType ContractDocumentReference {
			get {
				return contractDocumentReferenceField;
			}
			set {
				contractDocumentReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
		public DocumentReferenceType[] DocumentReference {
			get {
				return documentReferenceField;
			}
			set {
				documentReferenceField = value;
			}
		}
    
		/// <remarks/>
		public PartyType FinancingParty {
			get {
				return financingPartyField;
			}
			set {
				financingPartyField = value;
			}
		}
    
		/// <remarks/>
		public FinancialAccountType FinancingFinancialAccount {
			get {
				return financingFinancialAccountField;
			}
			set {
				financingFinancialAccountField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Clause")]
		public ClauseType[] Clause {
			get {
				return clauseField;
			}
			set {
				clauseField = value;
			}
		}
	}
}