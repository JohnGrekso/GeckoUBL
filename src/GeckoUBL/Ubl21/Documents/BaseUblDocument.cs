using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace GeckoUBL.Ubl21.Documents
{
	public class BaseUblDocument
	{
		/// <summary>
		/// Takes care of namespace prefix in saved xml documents
		/// </summary>
		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns
		{
			get
			{
				return new XmlSerializerNamespaces(
					new[] 
					{
						new XmlQualifiedName("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
						new XmlQualifiedName("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
						new XmlQualifiedName("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"),
						new XmlQualifiedName("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"),
						new XmlQualifiedName("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"),
						new XmlQualifiedName("", (GetType().GetCustomAttributes(typeof(XmlTypeAttribute), false).FirstOrDefault() as XmlTypeAttribute).Namespace)
					});
			}
		}
	}
}
