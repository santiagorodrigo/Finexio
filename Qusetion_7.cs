//7.Given the following XML file, use the XPath support in .NET to write out all the names, one on each line: (8 points)
//< Root >
//  < Item >

//	< Name > Smith </ Name >
//  </ Item >
//  < Item >

//	< Name > Brown </ Name >
//  </ Item >
//  < Item >

//	< Name > Jones </ Name >
//  </ Item >
//  < Item >

//	< Name > John </ Name >
//  </ Item >
//</ Root >


using System;
using System.Xml;

namespace Finexio
{
	public class Qusetion_7
	{
		public Qusetion_7()
		{
			// Load data from XML into xml object
			XmlDocument data = new XmlDocument();
			data.Load(@"Question_7.xml");

			XmlNodeList nodesList = data.SelectNodes(@"/Root/Item/Name");

            foreach (XmlNode item in nodesList)
            {
				Console.WriteLine(item.InnerText);
            }

		}
	}
}

