using System.IO;
using System.Reflection;

namespace GeckoUBL.Tests
{
	public class Helpers
	{
		public static string XsdFolder
		{
			get { return @"..\..\..\..\xsd\os-UBL-2.1\xsd\maindoc\";} 
			
		}
		
		public static string ExampleFolder 
		{
			get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Ubl21\Examples\"; }
		}
	}
}
