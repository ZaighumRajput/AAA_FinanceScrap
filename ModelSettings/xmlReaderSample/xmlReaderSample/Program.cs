using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace xmlReaderSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = Directory.GetCurrentDirectory();

            XmlSchemaSetExample.TestAgainstSchema();
            //xmlDocument.Read(path, "eurofxref-daily.xml");
            
            //reader.Read(path,"eurofxref-daily.xml");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }
    }
}
