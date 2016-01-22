using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Ccts
{
	[XmlInclude(typeof(RateType))]
	[XmlInclude(typeof(TargetCurrencyBaseRateType))]
	[XmlInclude(typeof(SourceCurrencyBaseRateType))]
	[XmlInclude(typeof(RateType1))]
	[XmlInclude(typeof(OrderableUnitFactorRateType))]
	[XmlInclude(typeof(CalculationRateType))]
	[XmlInclude(typeof(AmountRateType))]
	[XmlInclude(typeof(PercentType))]
	[XmlInclude(typeof(TierRatePercentType))]
	[XmlInclude(typeof(TargetServicePercentType))]
	[XmlInclude(typeof(SettlementDiscountPercentType))]
	[XmlInclude(typeof(ReliabilityPercentType))]
	[XmlInclude(typeof(ProgressPercentType))]
	[XmlInclude(typeof(PercentType1))]
	[XmlInclude(typeof(PenaltySurchargePercentType))]
	[XmlInclude(typeof(PaymentPercentType))]
	[XmlInclude(typeof(ParticipationPercentType))]
	[XmlInclude(typeof(PartecipationPercentType))]
	[XmlInclude(typeof(MinimumPercentType))]
	[XmlInclude(typeof(MaximumPercentType))]
	[XmlInclude(typeof(HumidityPercentType))]
	[XmlInclude(typeof(AirFlowPercentType))]
	[XmlInclude(typeof(ValueType1))]
	[XmlInclude(typeof(NumericType1))]
	[XmlInclude(typeof(WeightNumericType))]
	[XmlInclude(typeof(SequenceNumericType))]
	[XmlInclude(typeof(ResidentOccupantsNumericType))]
	[XmlInclude(typeof(ReminderSequenceNumericType))]
	[XmlInclude(typeof(PackSizeNumericType))]
	[XmlInclude(typeof(OrderQuantityIncrementNumericType))]
	[XmlInclude(typeof(OrderIntervalDaysNumericType))]
	[XmlInclude(typeof(MultiplierFactorNumericType))]
	[XmlInclude(typeof(MinimumNumberNumericType))]
	[XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
	[XmlInclude(typeof(MaximumNumberNumericType))]
	[XmlInclude(typeof(MaximumCopiesNumericType))]
	[XmlInclude(typeof(LineNumberNumericType))]
	[XmlInclude(typeof(LineCountNumericType))]
	[XmlInclude(typeof(FrozenPeriodDaysNumericType))]
	[XmlInclude(typeof(CalculationSequenceNumericType))]
	[XmlInclude(typeof(BudgetYearNumericType))]
	[GeneratedCode("xsd", "4.0.30319.33440")]
	[Serializable()]
	[DebuggerStepThrough()]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
	public class NumericType
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}
}
