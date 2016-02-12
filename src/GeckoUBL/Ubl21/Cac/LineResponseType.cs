namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("LineResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class LineResponseType {
    
		private LineReferenceType lineReferenceField;
    
		private ResponseType[] responseField;
    
		/// <remarks/>
		public LineReferenceType LineReference {
			get {
				return lineReferenceField;
			}
			set {
				lineReferenceField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Response")]
		public ResponseType[] Response {
			get {
				return responseField;
			}
			set {
				responseField = value;
			}
		}
	}
}