using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW1
{
    /// <summary> 
    /// SymbolsRepeatCounter class implements methods counting repeated symbols.
    /// </summary>
    class SymbolsRepeatCounter
    {
        /// <summary>
        /// CountRepeatSymbols method used for find repeated symbols and count 
        /// amount of repeatyng of every symbol.
        /// </summary>
        /// <returns>String with column of symbels and column of count repeatings this symbols.></returns>
        public string CountRepeatSymbols(string args)
        {
            int curSize = 0;    
            int N = args.Length;
            StringBuilder returnValue = new StringBuilder();
            int[] memorizing_duplicate = new int[256]; //256 is max value of symbol in  ASCII table
            if(args.Length == 0)
            {
                Console.WriteLine("Empty string");
            }
            else
            {
                for (int curElementIndex = 0; curElementIndex < args.Length; curElementIndex++)
            {
                memorizing_duplicate[args[curElementIndex]]++;
            }
            for (int i = 0; i < memorizing_duplicate.Length; i++)
            {
                if (memorizing_duplicate[i] > 1)
                {
                    returnValue.Append(Convert.ToChar(i));
                    returnValue.Append(" " + memorizing_duplicate[i]);
                    returnValue.Append("\n");
                }
            }
            }
            
            return returnValue.ToString();
        }
    }
}
