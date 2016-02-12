using System;
using GeckoUBL.Ubl21.Documents;
using GeckoUBL.Ubl21.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class CatalogueTypeTests
	{
		private static ValidationResponse GetValidationResponse(BaseUblDocument doc)
		{
			return doc.Validate(Helpers.XsdFolder + "UBL-Catalogue-2.1.xsd");
		}

		private static CatalogueType GetDocument()
		{
			var exampleFile = Helpers.ExampleFolder + "UBL-Catalogue-2.1-Example.xml";
			var doc = UblDocumentLoader<CatalogueType>.GetDocument(exampleFile);
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
		public void GivenCatalogueXml_ThenCatalogueLoads()
		{
			var doc = GetDocument();

			Assert.AreEqual("2.1", doc.UBLVersionID.Value);

			Assert.AreEqual("1234", doc.ID.Value);
			Assert.AreEqual("Add", doc.ActionCode.Value);
			Assert.AreEqual(DateTime.Parse("2016-01-05"), doc.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2016-01-01"), doc.ValidityPeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2016-03-31"), doc.ValidityPeriod[0].EndDate.Value);

			Assert.AreEqual("CONTOSO", doc.ProviderParty.PartyIdentification[0].ID.Value);
			Assert.AreEqual("NRTHWND", doc.ReceiverParty.PartyIdentification[0].ID.Value);

			Assert.AreEqual(2, doc.CatalogueLine.Length);
		}
	}
}
