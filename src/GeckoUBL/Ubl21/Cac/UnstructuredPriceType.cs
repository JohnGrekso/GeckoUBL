using GeckoUBL.Ubl21.Cbc;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("UnstructuredPrice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class UnstructuredPriceType {
    
	private PriceAmountType priceAmountField;
    
	private TimeAmountType timeAmountField;
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public PriceAmountType PriceAmount {
		get {
			return this.priceAmountField;
		}
		set {
			this.priceAmountField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public TimeAmountType TimeAmount {
		get {
			return this.timeAmountField;
		}
		set {
			this.timeAmountField = value;
		}
	}
}