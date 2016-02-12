using System;
using GeckoUBL.Ubl21.Documents;
using GeckoUBL.Ubl21.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class InvoiceTypeTests
	{
		private static ValidationResponse GetValidationResponse(BaseUblDocument doc)
		{
			return doc.Validate(Helpers.XsdFolder + "UBL-Invoice-2.1.xsd");
		}

		private static InvoiceType GetDocument()
		{
			var exampleFile = Helpers.ExampleFolder + "UBL-Invoice-2.1-Example.xml";
			var doc = UblDocumentLoader<InvoiceType>.GetDocument(exampleFile);
			return doc;
		}

		[TestMethod]
		public void GivenObject_ThenSchemaIsValid()
		{
			var doc = GetDocument();

			var actual = GetValidationResponse(doc);

			Assert.IsTrue(actual.IsValid, actual.Errors);
		}

		[TestMethod]
		public void GivenObject_ThenSchemaIsNotValid()
		{
			var doc = GetDocument();

			doc.ID = null;

			var actual = GetValidationResponse(doc);

			Assert.IsFalse(actual.IsValid);
		}

		[TestMethod]
		public void GivenInvoiceXml_ThenInvoiceLoads()
		{
			var doc = GetDocument();

			Assert.AreEqual("2.1", doc.UBLVersionID.Value);

			Assert.AreEqual("TOSL108", doc.ID.Value);
			Assert.AreEqual(DateTime.Parse("2009-12-15"), doc.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2009-11-01"), doc.InvoicePeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2009-11-30"), doc.InvoicePeriod[0].EndDate.Value);

			Assert.AreEqual(729, doc.LegalMonetaryTotal.PayableAmount.Value);
			Assert.AreEqual("EUR", doc.LegalMonetaryTotal.PayableAmount.currencyID);

			Assert.AreEqual(5, doc.InvoiceLine.Length);
		}
	}
}
