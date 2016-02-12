using GeckoUBL.Ubl21.Cbc;

namespace GeckoUBL.Ubl21.Cac
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
	[System.Xml.Serialization.XmlRootAttribute("AlternativeConditionPrice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
	public class PriceType {
    
		private PriceAmountType priceAmountField;
    
		private BaseQuantityType baseQuantityField;
    
		private PriceChangeReasonType[] priceChangeReasonField;
    
		private PriceTypeCodeType priceTypeCodeField;
    
		private PriceTypeType priceType1Field;
    
		private OrderableUnitFactorRateType orderableUnitFactorRateField;
    
		private PeriodType[] validityPeriodField;
    
		private PriceListType priceListField;
    
		private AllowanceChargeType[] allowanceChargeField;
    
		private ExchangeRateType pricingExchangeRateField;
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceAmountType PriceAmount {
			get {
				return priceAmountField;
			}
			set {
				priceAmountField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public BaseQuantityType BaseQuantity {
			get {
				return baseQuantityField;
			}
			set {
				baseQuantityField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PriceChangeReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceChangeReasonType[] PriceChangeReason {
			get {
				return priceChangeReasonField;
			}
			set {
				priceChangeReasonField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceTypeCodeType PriceTypeCode {
			get {
				return priceTypeCodeField;
			}
			set {
				priceTypeCodeField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PriceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public PriceTypeType PriceType1 {
			get {
				return priceType1Field;
			}
			set {
				priceType1Field = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public OrderableUnitFactorRateType OrderableUnitFactorRate {
			get {
				return orderableUnitFactorRateField;
			}
			set {
				orderableUnitFactorRateField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
		public PeriodType[] ValidityPeriod {
			get {
				return validityPeriodField;
			}
			set {
				validityPeriodField = value;
			}
		}
    
		/// <remarks/>
		public PriceListType PriceList {
			get {
				return priceListField;
			}
			set {
				priceListField = value;
			}
		}
    
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
		public AllowanceChargeType[] AllowanceCharge {
			get {
				return allowanceChargeField;
			}
			set {
				allowanceChargeField = value;
			}
		}
    
		/// <remarks/>
		public ExchangeRateType PricingExchangeRate {
			get {
				return pricingExchangeRateField;
			}
			set {
				pricingExchangeRateField = value;
			}
		}
	}
}