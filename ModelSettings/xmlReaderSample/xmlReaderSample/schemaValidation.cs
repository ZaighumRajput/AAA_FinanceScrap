using System;
using System.Xml;
using System.Xml.Schema;
using System.IO;


namespace xmlReaderSample
{
    class XmlSchemaSetExample
    {
        public static void TestAgainstSchema()
        {
            XmlReaderSettings booksSettings = new XmlReaderSettings();
            string curPath = Directory.GetCurrentDirectory();


            booksSettings.Schemas.Add(null,Path.Combine(curPath, "eurofxref-daily2.xsd"));
            booksSettings.Schemas.Add(null, Path.Combine(curPath, "eurofxref-daily3.xsd"));


            booksSettings.ValidationType = ValidationType.Schema  ;

            booksSettings.ValidationEventHandler += new ValidationEventHandler(booksSettingsValidationEventHandler);

            XmlReader books = XmlReader.Create("eurofxref-daily.xml", booksSettings);

            while (books.Read()) { }
            Console.WriteLine("OK!");
        }

        private static void booksSettingsValidationEventHandler(object sender, ValidationEventArgs e)
        {
     
            
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(e.Message);

            }
        }
    }
}