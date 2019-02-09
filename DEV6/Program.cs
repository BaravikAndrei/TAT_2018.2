using System;

namespace DEV6
{
    /// <summary>
    /// Class EntryPoint is the entry point of program.
    /// </summary>
    class EntryPoint
    {   
        /// <summary>
        /// Class CarsCatalog is an entry point in the program.
        /// </summary>
        static void Main(string[] args)
        {
            if (args[0].Contains(".JSON"))
            {
                JSONtoXMLConvertor jtx = new JSONtoXMLConvertor(args[0]);
                Console.WriteLine(jtx.ConvertJSONtoXML());
            }
            else if (args[0].Contains(".xml"))
            {
                XMLtoJSONconvertor xtj = new XMLtoJSONconvertor(args[0]);
                Console.WriteLine(xtj.ConvertXMLtoJSON());
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.ReadKey(true);
        }
        
    }
}
