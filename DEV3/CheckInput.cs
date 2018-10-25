using System;

namespace DEV3
{
    /// <summary>
    /// The CheckInput class check inputed strings for the presence of value of only integer and system only from 2 to 20.
    /// </summary>
    class CheckInput
    {   
       /// <summary> 
       /// Method CheckForCorrectInput
       /// function for check inputed strings for the presence of value of only integer and system only from 2 to 20.
       /// </summary> 
       /// <param name="taked_value">Value in deciml system</param>
       /// <param name="taked_number_of_system">Number of system to convert</param>
       public bool CheckForCorrectInput(string TakedValue, string TakedNumberOfSystem)
       {    
           bool returnvalue = false;  //return false or true if input incorrect or correct respectively
           //checking for empty input; checking for integer input;  checking for range of number of system.
           if ((TakedValue.Length > 0 && TakedNumberOfSystem.Length > 0) && (Convert.ToDouble(TakedValue) == Convert.ToInt32(TakedValue)) &&
           (Convert.ToInt32(TakedNumberOfSystem) >= 2 && Convert.ToInt32(TakedNumberOfSystem) <= 20))
           {
               returnvalue = true;
           }
           return returnvalue; //return bool value.
        }
    }
}