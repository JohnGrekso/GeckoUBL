using System;
using GeckoUBL.Ubl21.Documents;
using GeckoUBL.Ubl21.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class InvoiceTypeTests
	{
		private string _xsdFile;
		private InvoiceType _document;

		[TestInitialize]
		public void TestInitialize()
		{
			_xsdFile = Helpers.XsdFolder + "UBL-Invoice-2.1.xsd";

			var exampleFile = Helpers.ExampleFolder + "UBL-Invoice-2.1-Example.xml";
			_document = UblDocumentLoader<InvoiceType>.GetDocument(exampleFile);
		}

		[TestMethod]
		public void GivenObject_ThenSchemaIsValid()
		{
			var actual = _document.Validate(_xsdFile);

			Assert.IsTrue(actual.IsValid, actual.Errors);
		}

		[TestMethod]
		public void GivenObject_ThenSchemaIsNotValid()
		{
			_document.ID = null;

			var actual = _document.Validate(_xsdFile);

			Assert.IsFalse(actual.IsValid);
		}

		[TestMethod]
		public void GivenInvoiceXml_ThenInvoiceLoads()
		{
			Assert.AreEqual("2.1", _document.UBLVersionID.Value);

			Assert.AreEqual("TOSL108", _document.ID.Value);
			Assert.AreEqual(DateTime.Parse("2009-12-15"), _document.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2009-11-01"), _document.InvoicePeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2009-11-30"), _document.InvoicePeriod[0].EndDate.Value);

			Assert.AreEqual(729, _document.LegalMonetaryTotal.PayableAmount.Value);
			Assert.AreEqual("EUR", _document.LegalMonetaryTotal.PayableAmount.currencyID);

			Assert.AreEqual(5, _document.InvoiceLine.Length);
		}
	}
}
