using System;
using System.Text;

namespace DEV2
{
    /*
	    The main program class.
	    Contains the entry point method of the programm.
	*/
    class TranslitString
    {
        // Entry point of the program
	    // The entry point of the program, where the program control starts and ends.  
	    // Get the value from the command line argument.
       public static void Main(string[] args)
        {    
            // checking for empty input line
            //string input=args.InputString();
            if(args.CheckInputedString())
            {
                if (args[0].Length==0)
                {
                    Console.WriteLine("You didn't input a string line");
                    Console.ReadKey();
                }
                else
                {   
                    Console.WriteLine (args.Transliteration());
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine ("inputed uncorrect string");
                Console.ReadKey();
            }
        }
    }
      
}
