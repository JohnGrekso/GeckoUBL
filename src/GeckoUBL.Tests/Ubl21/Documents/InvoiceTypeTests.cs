using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class InvoiceTypeTests
	{
		[TestMethod]
		public void GivenInvoiceTrivialXml_ThenInvoiceLoads()
		{
			var doc = UblDocumentHandler<InvoiceType>.GetDocument("UBL-Invoice-2.1-Example-Trivial.xml");

			Assert.AreEqual("123", doc.ID.Value);
			Assert.AreEqual(DateTime.Parse("2011-09-22"), doc.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2011-08-01"), doc.InvoicePeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2011-08-31"), doc.InvoicePeriod[0].EndDate.Value);

			Assert.AreEqual("Custom Cotter Pins", doc.AccountingSupplierParty.Party.PartyName[0].Name.Value);
			Assert.AreEqual("North American Veeblefetzer", doc.AccountingCustomerParty.Party.PartyName[0].Name.Value);

			Assert.AreEqual(100, doc.LegalMonetaryTotal.PayableAmount.Value);
			Assert.AreEqual("CAD", doc.LegalMonetaryTotal.PayableAmount.currencyID);

			Assert.AreEqual("1", doc.InvoiceLine[0].ID.Value);
			Assert.AreEqual(100, doc.InvoiceLine[0].LineExtensionAmount.Value);
			Assert.AreEqual("CAD", doc.InvoiceLine[0].LineExtensionAmount.currencyID);
			Assert.AreEqual("Cotter pin, MIL-SPEC", doc.InvoiceLine[0].Item.Description[0].Value);
		}

		[TestMethod]
		public void GivenInvoiceXml_ThenInvoiceLoads()
		{
			var doc = UblDocumentHandler<InvoiceType>.GetDocument("UBL-Invoice-2.1-Example.xml");

			Assert.AreEqual("TOSL108", doc.ID.Value);
			Assert.AreEqual(DateTime.Parse("2009-12-15"), doc.IssueDate.Value);
			Assert.AreEqual(DateTime.Parse("2009-11-01"), doc.InvoicePeriod[0].StartDate.Value);
			Assert.AreEqual(DateTime.Parse("2009-11-30"), doc.InvoicePeriod[0].EndDate.Value);

			Assert.AreEqual(729, doc.LegalMonetaryTotal.PayableAmount.Value);
			Assert.AreEqual("EUR", doc.LegalMonetaryTotal.PayableAmount.currencyID);

			Assert.AreEqual(5, doc.InvoiceLine.Count());
		}
	}

	public class UblDocumentHandler<T>
	{
		public static T GetDocument(string filename)
		{
			const string subdirectory = @"Ubl21\Examples";

			var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			var file = string.Format(@"{0}\{1}\{2}", directory, subdirectory, filename);

			T doc;
			using (var xr = XmlReader.Create(file))
			{
				var xs = new XmlSerializer(typeof(T));
				doc = (T)xs.Deserialize(xr);
			}

			return doc;
		}
	}
}
