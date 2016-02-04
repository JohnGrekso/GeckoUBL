using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using GeckoUBL.Ubl21.Documents;

namespace GeckoUBL.Ubl21.Extensions
{
	public static class BaseUblDocumentExtensions
	{
		public static string ToXml(this BaseUblDocument doc)
		{
			var settings = new XmlWriterSettings
			{
				CloseOutput = false,
				Indent = true,
				NamespaceHandling = NamespaceHandling.OmitDuplicates
			};

			var serializer = new XmlSerializer(doc.GetType());

			using (var stringWriter = new StringWriter())
			{
				using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
				{
					serializer.Serialize(xmlWriter, doc, doc.Xmlns);
				}

				return stringWriter.ToString();
			}
		}

		public static ValidationResponse Validate(this BaseUblDocument doc, string xsdLocation)
		{
			var response = new ValidationResponse {IsValid = true, Errors = ""};

			var schemas = new XmlSchemaSet();
			using (var xr = new XmlTextReader(xsdLocation))
			{
				schemas.Add(XmlSchema.Read(xr, null));
			}

			var xmlReader = XmlReader.Create(new StringReader(doc.ToXml()));
			var xDoc = XDocument.Load(xmlReader);

			xDoc.Validate(schemas, (o, e) =>
			{
				response.Errors += e.Message + Environment.NewLine;
				response.IsValid = false;
			});

			return response;
		}
	}
}
