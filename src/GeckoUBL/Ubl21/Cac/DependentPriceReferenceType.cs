using GeckoUBL.Ubl21.Cbc;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DependentPriceReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DependentPriceReferenceType {
    
	private PercentType1 percentField;
    
	private AddressType locationAddressField;
    
	private LineReferenceType dependentLineReferenceField;
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public PercentType1 Percent {
		get {
			return this.percentField;
		}
		set {
			this.percentField = value;
		}
	}
    
	/// <remarks/>
	public AddressType LocationAddress {
		get {
			return this.locationAddressField;
		}
		set {
			this.locationAddressField = value;
		}
	}
    
	/// <remarks/>
	public LineReferenceType DependentLineReference {
		get {
			return this.dependentLineReferenceField;
		}
		set {
			this.dependentLineReferenceField = value;
		}
	}
}