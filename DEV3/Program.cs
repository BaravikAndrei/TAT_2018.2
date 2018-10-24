using System;

namespace DEV3
{
    /// <summary>
    /// The TransferValueToAnotherNumberSystem method takes 2 strings of numbes. The first one is a value.
    /// in a decimal system, the the second is a number of system to be transferred. That metod convert number(1st value)
    /// from decimal to another number (2nd value) system.
    /// The Checkig_for_incorrect_input method check inputed value for an empty string, iteger value and for 
    /// range of number of system.
    /// </summary>
    class TransferToAnotherSystem
    {
        // Entry point of the program
        // The entry point of the program, where the program control starts and ends.  
        // Get the values from the command line argument.
        static void Main(string[] args)
         {
            try
            {
                CheckInput Checkig_for_incorrect_input = new CheckInput();
                if (Checkig_for_incorrect_input.check_for_correct_input(args[0],args[1]))
                { 
                    TransferToAnotherNumberSystem value = new TransferToAnotherNumberSystem();
                    for(int i=0;i<value.TransferValueToAnotherNumberSystem(args[0],args[1]).Length;i++)
                    {
                        Console.Write(value.TransferValueToAnotherNumberSystem(args[0],args[1])[i]);
                    }  
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Incorrect input");
            }
            
        }
    }
}