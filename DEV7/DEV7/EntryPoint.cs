﻿using System;

namespace DEV7
{
    /// <summary>
    /// The TransferValueToAnotherNumberSystem method takes 2 strings of numbes. The first one is a value.
    /// in a decimal system, the the second is a number of system to be transferred. That metod convert number(1st value)
    /// from decimal to another number (2nd value) system.
    /// The CheckForCorrectInput method check inputed value for an empty string, iteger value and for 
    /// range of number of system.
    /// </summary>
    public class EntryPoint
    {
        // Entry point of the program
        // The entry point of the program, where the program control starts and ends.  
        // Get the values from the command line argument.
        static void Main(string[] args)
         {
            try
            {
                CheckInput check = new CheckInput();
                if (check.CheckForCorrectInput(args[0], args[1]))
                { 
                    TransferRadix convertedValue = new TransferRadix();
                    Console.WriteLine(convertedValue.TransferValueToAnotherNumberSystem(args[0], args[1]));
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