using GeckoUBL.Ubl21.Documents;
using GeckoUBL.Ubl21.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class OrderResponseSimpleTests
	{
		private static ValidationResponse GetValidationResponse(BaseUblDocument doc)
		{
			return doc.Validate(Helpers.XsdFolder + "UBL-OrderResponseSimple-2.1.xsd");
		}

		private static OrderResponseSimpleType GetDocument()
		{
			var exampleFile = Helpers.ExampleFolder + "UBL-OrderResponseSimple-2.1-Example.xml";
			var doc = UblDocumentLoader<OrderResponseSimpleType>.GetDocument(exampleFile);
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
	}
}
