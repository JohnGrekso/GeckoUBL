using GeckoUBL.Ubl21.Cbc;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EconomicOperatorRole", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EconomicOperatorRoleType {
    
	private RoleCodeType roleCodeField;
    
	private RoleDescriptionType[] roleDescriptionField;
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public RoleCodeType RoleCode {
		get {
			return this.roleCodeField;
		}
		set {
			this.roleCodeField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("RoleDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
	public RoleDescriptionType[] RoleDescription {
		get {
			return this.roleDescriptionField;
		}
		set {
			this.roleDescriptionField = value;
		}
	}
}