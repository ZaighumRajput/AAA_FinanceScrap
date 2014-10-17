
using System;
using System.Xml.Linq;
using System.Linq;

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

               
               var modelAndParameters = equity.Elements() ;
               var modelType = modelAndParameters.First().Name;

               Console.WriteLine("The index {0} will use {1} which has paramaters",
                                equity.FirstAttribute.Value,
                                
                                modelType);
               

               
              
               
               
               //foreach(var blah in modelAndParameters){
               //    Console.WriteLine(blah.Name);
               //}
        

           }

         }

        //class EQSettings
        //{
        //    private:
        //    string _indexName;
        //    string _model;
        //    Dictionary<
        //}

        public static void Read(string path, string fileName)
        {
            XDocument doc = XDocument.Load(fileName);

            var equityList = doc.Descendants("equity");

            foreach (var equity in equityList)
            {


                var modelAndParameters = equity.Elements();
                var modelType = modelAndParameters.First().Name;

                Console.WriteLine("The index {0} will use {1} which has paramaters",
                                 equity.FirstAttribute.Value,

                                 modelType);


                //foreach(var blah in modelAndParameters){
                //    Console.WriteLine(blah.Name);
                //}


            }

        }



    }


}


