using GeckoUBL.Ubl21.Udt;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("Item", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class ItemType {
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Description { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public QuantityType PackQuantity { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NumericType PackSizeNumeric { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType CatalogueIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType Name { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IndicatorType HazardousRiskIndicator { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] AdditionalInformation { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Keyword", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TextType[] Keyword { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BrandName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType[] BrandName { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ModelName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NameType[] ModelName { get; set; }

		/// <remarks/>
		public ItemIdentificationType BuyersItemIdentification { get; set; }

		/// <remarks/>
		public ItemIdentificationType SellersItemIdentification { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ManufacturersItemIdentification")]
		public ItemIdentificationType[] ManufacturersItemIdentification { get; set; }

		/// <remarks/>
		public ItemIdentificationType StandardItemIdentification { get; set; }

		/// <remarks/>
		public ItemIdentificationType CatalogueItemIdentification { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification")]
		public ItemIdentificationType[] AdditionalItemIdentification { get; set; }

		/// <remarks/>
		public DocumentReferenceType CatalogueDocumentReference { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemSpecificationDocumentReference")]
		public DocumentReferenceType[] ItemSpecificationDocumentReference { get; set; }

		/// <remarks/>
		public CountryType OriginCountry { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
		public CommodityClassificationType[] CommodityClassification { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransactionConditions")]
		public TransactionConditionsType[] TransactionConditions { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HazardousItem")]
		public HazardousItemType[] HazardousItem { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ClassifiedTaxCategory")]
		public TaxCategoryType[] ClassifiedTaxCategory { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
		public ItemPropertyType[] AdditionalItemProperty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ManufacturerParty")]
		public PartyType[] ManufacturerParty { get; set; }

		/// <remarks/>
		public PartyType InformationContentProviderParty { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OriginAddress")]
		public AddressType[] OriginAddress { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemInstance")]
		public ItemInstanceType[] ItemInstance { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Certificate")]
		public CertificateType[] Certificate { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Dimension")]
		public DimensionType[] Dimension { get; set; }
	}
}