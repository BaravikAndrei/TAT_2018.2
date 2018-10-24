using System;

namespace DEV3
{
    /// <summary>
    /// The CheckInput class check inputed strings for the presence of value of only integer and system only from 2 to 20.
    /// </summary>
    class CheckInput
    {   
       /// <summary> 
       /// Method check_for_correct_input
       /// function for check inputed strings for the presence of value of only integer and system only from 2 to 20.
       /// </summary> 
       /// <param name="taked_value">Value in deciml system</param>
       /// <param name="taked_number_of_system">Number of system to convert</param>
       bool returnvalue=false;
       public bool check_for_correct_input(string taked_value, string taked_number_of_system)
       {    
           //checking for empty input
           if (taked_value.Length==0 || taked_number_of_system.Length==0)
           {
               returnvalue=false;
           }
           //checking for integer input
           else if(Convert.ToDouble(taked_value)!=Convert.ToInt32(taked_value))
           {
               returnvalue=false;
           }
           //checking for range of number of system.
           else if(Convert.ToInt32(taked_number_of_system)<2 || Convert.ToInt32(taked_number_of_system)>20)
           {
               returnvalue=false;
           }
           //if input not empty,  value is integer and the range of system is between 2 and 20 return true.
           else
           {
               returnvalue=true;
           }
           return returnvalue; //return bool value
        }
    }
}