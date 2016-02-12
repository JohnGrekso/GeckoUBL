using System.Xml;
using System.Xml.Serialization;

namespace GeckoUBL.Tests
{
	public class UblDocumentLoader<T>
	{
		public static T GetDocument(string filename)
		{
			T doc;
			using (var xr = XmlReader.Create(filename))
			{
				var xs = new XmlSerializer(typeof(T));
				doc = (T)xs.Deserialize(xr);
			}

			return doc;
		}
	}
}
