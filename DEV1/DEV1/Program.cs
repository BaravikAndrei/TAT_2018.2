using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C:\Users\Jelezo\Documents\Visual Studio 2015\Projects\prog
namespace DEV1
{
    /// <summary>
    /// Class EntryPoint is an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            MaxSequence maxSequence = new MaxSequence(args[0]);
            Console.WriteLine("Max length " + maxSequence.FindMaxSequence());
        }
        //checking for empty sequence

    }
}

