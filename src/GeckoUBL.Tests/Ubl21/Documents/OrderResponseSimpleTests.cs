using GeckoUBL.Ubl21.Documents;
using GeckoUBL.Ubl21.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeckoUBL.Tests.Ubl21.Documents
{
	[TestClass]
	public class OrderResponseSimpleTests
	{
		private string _xsdFile;
		private OrderResponseSimpleType _document;

		[TestInitialize]
		public void TestInitialize()
		{
			_xsdFile = Helpers.XsdFolder + "UBL-OrderResponseSimple-2.1.xsd";

			var exampleFile = Helpers.ExampleFolder + "UBL-OrderResponseSimple-2.1-Example.xml";
			_document = UblDocumentLoader<OrderResponseSimpleType>.GetDocument(exampleFile);
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
	}
}
