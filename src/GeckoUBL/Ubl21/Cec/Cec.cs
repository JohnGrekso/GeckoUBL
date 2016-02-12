using GeckoUBL.Ubl21.Cbc;
using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cec
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionReasonType : TextType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionAgencyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionAgencyNameType : TextType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionReasonCodeType : CodeType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionVersionIDType : IdentifierType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionURIType : IdentifierType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionAgencyURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionAgencyURIType : IdentifierType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("ExtensionAgencyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class ExtensionAgencyIDType : IdentifierType1
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class UBLExtensionsType
	{

		private UBLExtensionType[] uBLExtensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("UBLExtension")]
		public UBLExtensionType[] UBLExtension
		{
			get
			{
				return uBLExtensionField;
			}
			set
			{
				uBLExtensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
	public class UBLExtensionType
	{

		private IDType idField;

		private NameType1 nameField;

		private ExtensionAgencyIDType extensionAgencyIDField;

		private ExtensionAgencyNameType extensionAgencyNameField;

		private ExtensionVersionIDType extensionVersionIDField;

		private ExtensionAgencyURIType extensionAgencyURIField;

		private ExtensionURIType extensionURIField;

		private ExtensionReasonCodeType extensionReasonCodeField;

		private ExtensionReasonType extensionReasonField;

		private System.Xml.XmlElement extensionContentField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID
		{
			get
			{
				return idField;
			}
			set
			{
				idField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType1 Name
		{
			get
			{
				return nameField;
			}
			set
			{
				nameField = value;
			}
		}

		/// <remarks/>
		public ExtensionAgencyIDType ExtensionAgencyID
		{
			get
			{
				return extensionAgencyIDField;
			}
			set
			{
				extensionAgencyIDField = value;
			}
		}

		/// <remarks/>
		public ExtensionAgencyNameType ExtensionAgencyName
		{
			get
			{
				return extensionAgencyNameField;
			}
			set
			{
				extensionAgencyNameField = value;
			}
		}

		/// <remarks/>
		public ExtensionVersionIDType ExtensionVersionID
		{
			get
			{
				return extensionVersionIDField;
			}
			set
			{
				extensionVersionIDField = value;
			}
		}

		/// <remarks/>
		public ExtensionAgencyURIType ExtensionAgencyURI
		{
			get
			{
				return extensionAgencyURIField;
			}
			set
			{
				extensionAgencyURIField = value;
			}
		}

		/// <remarks/>
		public ExtensionURIType ExtensionURI
		{
			get
			{
				return extensionURIField;
			}
			set
			{
				extensionURIField = value;
			}
		}

		/// <remarks/>
		public ExtensionReasonCodeType ExtensionReasonCode
		{
			get
			{
				return extensionReasonCodeField;
			}
			set
			{
				extensionReasonCodeField = value;
			}
		}

		/// <remarks/>
		public ExtensionReasonType ExtensionReason
		{
			get
			{
				return extensionReasonField;
			}
			set
			{
				extensionReasonField = value;
			}
		}

		/// <remarks/>
		public System.Xml.XmlElement ExtensionContent
		{
			get
			{
				return extensionContentField;
			}
			set
			{
				extensionContentField = value;
			}
		}
	}
}
