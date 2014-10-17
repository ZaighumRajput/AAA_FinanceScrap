
using System;
using System.Xml.Linq;

namespace xmlReaderSample
{
    class xDocumentExample
    {
        public static void Read(string path, string fileName)
        {
           XDocument doc = XDocument.Load(fileName);

           var equityList = doc.Descendants("equity");
           
           foreach (var equity in equityList)
           {

               Console.WriteLine(equity.FirstAttribute.Value);
               Console.Write(equity.Descendants("BlackScholes"));

           }

         }



    }


}


