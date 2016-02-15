using System;
using GeckoUBL.Ubl21.Documents;
using GeckoUBL.Ubl21.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class CatalogueTypeTests
	{
		private string _xsdFile;
		private CatalogueType _document;

		[TestInitialize]
		public void TestInitialize()
		{
			_xsdFile = Helpers.XsdFolder + "UBL-Catalogue-2.1.xsd";

			var exampleFile = Helpers.ExampleFolder + "UBL-Catalogue-2.1-Example.xml";
			_document = UblDocumentLoader<CatalogueType>.GetDocument(exampleFile);
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
		public void GivenCatalogueXml_ThenCatalogueLoads()
		{
			Assert.AreEqual("2.1", _document.UBLVersionID.Value);

			Assert.AreEqual("1234", _document.ID.Value);
			Assert.AreEqual("Add", _document.ActionCode.Value);
			Assert.AreEqual(DateTime.Parse("2016-01-05"), _document.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2016-01-01"), _document.ValidityPeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2016-03-31"), _document.ValidityPeriod[0].EndDate.Value);

			Assert.AreEqual("CONTOSO", _document.ProviderParty.PartyIdentification[0].ID.Value);
			Assert.AreEqual("NRTHWND", _document.ReceiverParty.PartyIdentification[0].ID.Value);

			Assert.AreEqual(2, _document.CatalogueLine.Length);
		}
	}
}
