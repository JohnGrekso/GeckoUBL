using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("Attachment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class AttachmentType {
    
		private EmbeddedDocumentBinaryObjectType embeddedDocumentBinaryObjectField;
    
		private ExternalReferenceType externalReferenceField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject {
			get {
				return embeddedDocumentBinaryObjectField;
			}
			set {
				embeddedDocumentBinaryObjectField = value;
			}
		}
    
		/// <remarks/>
		public ExternalReferenceType ExternalReference {
			get {
				return externalReferenceField;
			}
			set {
				externalReferenceField = value;
			}
		}
	}
}