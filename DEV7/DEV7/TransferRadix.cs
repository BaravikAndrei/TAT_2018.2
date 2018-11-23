using System;
using System.Text;

namespace DEV7
{ 
    /// <summary>
    /// Class for transfer to another number system.
    /// Contains the method of transfer from decimal to another number system.
    /// </summary>
    public class TransferRadix
    {
        /// <summary> 
        /// Method TransferValueToAnotherNumberSystem.
        /// Function transfer from decimal system to another selected system with radix from 2 to 20.
        /// </summary> 
        /// <param name="taked_value">Value in deciml system</param>
        /// <param name="taked_number_of_system">Number of system to convert</param>
        static string[] PossibleValuesOfTheSystem = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C",
        "D", "E", "F", "G", "H", "I"};  //string of possible values of the radix 

        public string TransferValueToAnotherNumberSystem(string valueInDecimalSystem, string newRadix)
        {   
            StringBuilder convertedValue=new StringBuilder();
            //convert inputed strings into integer vaalues.
            int inputedValue = Convert.ToInt32(valueInDecimalSystem); 
            int numberOfRadix = Convert.ToInt32(newRadix);
            //check for negative value 
            string sign ="";
            if (inputedValue < 0)
            {
                inputedValue = inputedValue * -1;
                sign="-";
            }
            //transfer value from decimal to selected system.
            int i = 0;
            for (; ; )
            {
                if (inputedValue >= numberOfRadix)
                {
                    if (inputedValue % numberOfRadix == 0)
                    {
                        convertedValue.Insert (0, PossibleValuesOfTheSystem[0]);
                        inputedValue /= numberOfRadix;
                    }
                    else if (inputedValue % numberOfRadix > 0)
                    {
                        convertedValue.Insert (0, PossibleValuesOfTheSystem[inputedValue % numberOfRadix]);
                        inputedValue = inputedValue / numberOfRadix;
                    }
                }
                else if(inputedValue < numberOfRadix)
                {
                    convertedValue.Insert (0, PossibleValuesOfTheSystem[inputedValue]);
                    break;
                }
                i++;
            }
            convertedValue.Insert (0, sign);
            return convertedValue.ToString(); //return converted value.
        }
    }
}
