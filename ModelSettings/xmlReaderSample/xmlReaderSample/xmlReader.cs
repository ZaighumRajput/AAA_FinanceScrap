using System.Xml;
using System.IO;
using System;

namespace xmlReaderSample
{
    class reader
    {
        public static void Read(string fileName)
        {
            string path = Directory.GetCurrentDirectory()  ;
            string fullPathName = System.IO.Path.Combine(path, fileName);
            XmlReader xmlReader = XmlReader.Create(fullPathName);
            while (xmlReader.Read())
            {
                 if((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
                    if(xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));                    
                }
            }
            Console.ReadKey();

            }
        }
    }


