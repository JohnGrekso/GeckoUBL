using System;
using System.Linq;
using GeckoUBL.Ubl21.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class CatalogueTypeTests
	{
		[TestMethod]
		public void GivenCatalogueXml_ThenInvoiceLoads()
		{
			var doc = UblDocumentHandler<CatalogueType>.GetDocument("UBL-Catalogue-2.1-Example.xml");

			Assert.AreEqual("2.1", doc.UBLVersionID.Value);

			Assert.AreEqual("1234", doc.ID.Value);
			Assert.AreEqual(DateTime.Parse("2016-01-05"), doc.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2016-01-01"), doc.ValidityPeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2016-03-31"), doc.ValidityPeriod[0].EndDate.Value);

			Assert.AreEqual("CONTOSO", doc.ProviderParty.PartyIdentification[0].ID.Value);
			Assert.AreEqual("NRTHWND", doc.ReceiverParty.PartyIdentification[0].ID.Value);

			Assert.AreEqual(2, doc.CatalogueLine.Count());
		}
	}
}
