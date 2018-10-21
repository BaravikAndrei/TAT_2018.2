using System;
using System.Text;

namespace DEV2
{
    /// <summary>
    /// The Transliteration method takes a string in Russian (or in Latin) language
    /// and translates the string into the required language
    /// The CheckInputedString method check inputed string for the presence of characters of only one alphabet
    /// and returns true if inputed string contains characters of only one of the alphabets
    /// </summary>
    class TranslitString
    {
        // Entry point of the program
	    // The entry point of the program, where the program control starts and ends.  
	    // Get the value from the command line argument.
       public static void Main(string[] args)
        {    
            // checking for empty input line
            try
            {

            
                if (args.Length==0)
                {
                    Console.WriteLine("You didn't input a string line");
                    Console.ReadKey();
                }
                else
                {
                    if (args.CheckInputedString())
                    {
                        Console.WriteLine (args.Transliteration());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine ("inputed uncorrect string");
                        Console.ReadKey();
                    } 
                 }
            }
            catch (Exception)
            {
                 Console.WriteLine("program execution error");
            }
        }   
    }
}
