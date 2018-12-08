using System;

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
                if (args[0] == string.Empty)
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    Console.WriteLine(symbolsRepeatCount.CountRepeatSymbols(args[0]));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
