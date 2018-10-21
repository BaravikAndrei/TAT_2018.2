using System.Text;

namespace DEV2
{  
    /// <summary>
    /// The InputCheck class check inputed string for the presence of characters of only one alphabet
    /// </summary>
    static class InputCheck
    {
        /// <summary> 
        /// Method CheckInputedString
        /// function for check inputed string for the presence of characters of only one alphabet
        /// and returns true if inputed string contains characters of only one of the alphabets
        /// </summary> 
        /// <param name="args">String, which was inputed</param>
        public static bool CheckInputedString(this string[] args)
        {
            StringBuilder InputedString = new StringBuilder(args[0].ToLower());
            int CountOfEnglishSymbols=0;  //count of english symbols in inputed string
            int CountOfRussianSymbols=0;  //count of russian symbols in inputed string
            bool ReturnCheck;
            for (int i=0; i<InputedString.Length;i++)
            {
                if (InputedString[i]>'a' && InputedString[i]<'z')
                {
                    CountOfEnglishSymbols++;
                }
                if (InputedString[i]>'а' && InputedString[i]<'я')
                {
                    CountOfRussianSymbols++;
                }
            }
           if ((CountOfEnglishSymbols>0 && CountOfRussianSymbols==0)||(CountOfEnglishSymbols==0 && CountOfRussianSymbols>0))
            {
                //return true while inputed contins characters of only one alphabet.
                ReturnCheck=true; 
            }
           else
            {
                //return false while inputed contins characters of both alphabets.
                ReturnCheck=false;
            }
            return ReturnCheck; 
        }
    }
}

