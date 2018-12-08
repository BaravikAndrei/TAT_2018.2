using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW1
{
    /// <summary>
    /// Class EntryPoint is an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                SymbolsRepeatCounter symbolsRepeatCount = new SymbolsRepeatCounter();
                Console.WriteLine(symbolsRepeatCount.CountRepeatSymbols(args[0]));
            }
            catch (Exception)
            {
                Console.WriteLine("Program crash");
            }
        }
    }
}
