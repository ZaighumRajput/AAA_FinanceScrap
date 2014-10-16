using System.Xml;
using System;

namespace xmlReaderSample
{
    class xmlDocument
    {
        public static void Read(string path, string fileName)
        {
            string fullPathName = System.IO.Path.Combine(path, fileName);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fullPathName);

            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
                
                Console.WriteLine(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);
            Console.ReadKey();

        }
            


        }


    }


