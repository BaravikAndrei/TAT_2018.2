﻿using System;

namespace DEV7
{
    /// <summary>
    /// The CheckInput class check inputed strings for the presence of value and system only from 2 to 20.
    /// </summary>
    public class CheckInput
    {   
       /// <summary> 
       /// Method CheckForCorrectInput
       /// function for check inputed strings for the presence of value of only integer and system only from 2 to 20.
       /// </summary> 
       /// <param name="taked_value">Value in deciml system</param>
       /// <param name="taked_number_of_system">Number of system to convert</param>
       const int minRadix = 2;
       const int maxRadix = 20;
       public bool CheckForCorrectInput(string decimalValue, string radix)
       {    
           bool returnValue = false;  //return false or true if input incorrect or correct respectively
           //checking for empty input; checking for range of number of system.
           if ((decimalValue.Length > 0 && radix.Length > 0) && (Convert.ToInt32(radix) >= minRadix && Convert.ToInt32(radix) <= maxRadix))
           {
               returnValue = true;
           }
           return returnValue; //return bool value.
        }
    }
}