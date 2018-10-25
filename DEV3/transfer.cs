using System;
using System.Text;

namespace DEV3
{ 
    /// <summary>
    /// Class for transfer to another number system.
    /// Contains the method of transfer from decimal to another number system.
    /// </summary>
    class TransferToAnotherNumberSystem
    {
        /// <summary> 
        /// Method string_of_possible_values_of_the_system.
        /// function transfer from decimal to another number system.
        /// </summary> 
        /// <param name="taked_value">Value in deciml system</param>
        /// <param name="taked_number_of_system">Number of system to convert</param>
        public string[] PossibleValuesOfTheSystem = { "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J" }; //string of possible values of the system 

        public string TransferValueToAnotherNumberSystem(string taked_value, string taked_number_of_system)
        {   
            //convert inputed strings into integer vaalues.
            int inputed_value=Convert.ToInt32(taked_value); 
            int number_of_system= Convert.ToInt32(taked_number_of_system);
            StringBuilder NewString=new StringBuilder();
            //transfer value from decimal to selected system.
            int i=0;
            for (; ; )
            {
                if (inputed_value>=number_of_system)
                {
                    if (inputed_value % number_of_system ==0)
                    {
                        NewString.Insert (0, PossibleValuesOfTheSystem[0]);
                        inputed_value /= number_of_system;
                    }
                    else if (inputed_value % number_of_system >0)
                    {
                        NewString.Insert (0, PossibleValuesOfTheSystem[inputed_value % number_of_system]);
                        inputed_value = inputed_value / number_of_system;
                    }
                }
                else if(inputed_value<number_of_system)
                {
                    NewString.Insert (0, PossibleValuesOfTheSystem[inputed_value]);
                    break;
                }
                i++;
            }
            return NewString.ToString(); //return transfer value.
        }
    }
}
