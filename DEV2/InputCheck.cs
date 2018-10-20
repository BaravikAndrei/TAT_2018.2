using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text;

namespace DEV2
{  
    /*
	    Class for transliteration inputed string.
	    Contains the method of transliteration.
	*/
    static class InputCheck
    {
	    // Realisation of transliteration inputed string.  
        public static bool CheckInputedString(this string[] args)
        {
            StringBuilder InputedString = new StringBuilder(args[0].ToLower());
            //Inputed string language definition.
            int CountOfEnglishSymbols=0;
            int CountOfRussianSymbols=0;
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
                ReturnCheck=true;
            }
           else
            {
                ReturnCheck=false;
            }
            return ReturnCheck;  //Return transliterated string
        }
    }
}

