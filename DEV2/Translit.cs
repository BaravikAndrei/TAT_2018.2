using System.Text;

namespace DEV2
{  
    /*
	    Class for transliteration inputed string.
	    Contains the method of transliteration.
	*/
    static class Translit
    {
	    // Realisation of transliteration inputed string.  
        public static string Transliteration(this string[] args)
        {
            StringBuilder InputedString = new StringBuilder(args[0].ToLower());
            //Inputed string language definition.
            char check=InputedString[0];
            //If language of inputed string is russian transsliteration in english.
            if (check>='а')
            { 
                //Replaceing russian character into english
                InputedString.Replace("а","a");
                InputedString.Replace("б","b");
                InputedString.Replace("в","v");
                InputedString.Replace("г","g");
                InputedString.Replace("д","d");
                InputedString.Replace("е","e");
                InputedString.Replace("ё","yo");
                InputedString.Replace("ж","zh");
                InputedString.Replace("з","z");
                InputedString.Replace("и","i");
                InputedString.Replace("й","y");
                InputedString.Replace("к","k");
                InputedString.Replace("л","l");
                InputedString.Replace("м","m");
                InputedString.Replace("н","n");
                InputedString.Replace("о","o");
                InputedString.Replace("п","p");
                InputedString.Replace("р","r");
                InputedString.Replace("с","s");
                InputedString.Replace("т","t");
                InputedString.Replace("у","u");
                InputedString.Replace("ф","f");
                InputedString.Replace("х","kh");
                InputedString.Replace("ц","ts");
                InputedString.Replace("ч","ch");
                InputedString.Replace("ш","sh");
                InputedString.Replace("щ","sch");
                InputedString.Replace("ы","y");
                InputedString.Replace("э","e");
                InputedString.Replace("ю","yu");
                InputedString.Replace("я","yа");
                InputedString.Replace("ь",string.Empty);
                InputedString.Replace("ъ",string.Empty);

            }
            //If language of inputed string is english transsliteration in russian.
            else
            {   
                //Replaceing english character into russian.
                InputedString.Replace("sch","щ");
                InputedString.Replace("sh","ш");
                InputedString.Replace("yo","ё");
                InputedString.Replace("yu","ю");
                InputedString.Replace("ya","я");
                InputedString.Replace("kh","х");
                InputedString.Replace("ts","ц");
                InputedString.Replace("ch","ч");
                InputedString.Replace("zh","ж");
                InputedString.Replace("a","а");
                InputedString.Replace("b","б");
                InputedString.Replace("v","в");
                InputedString.Replace("g","г");
                InputedString.Replace("d","д");
                InputedString.Replace("e","е");
                InputedString.Replace("z","з");
                InputedString.Replace("i","и");
                InputedString.Replace("y","й");
                InputedString.Replace("k","к");
                InputedString.Replace("l","л");
                InputedString.Replace("m","м");
                InputedString.Replace("n","н");
                InputedString.Replace("o","о");
                InputedString.Replace("p","п");
                InputedString.Replace("r","р");
                InputedString.Replace("s","с");
                InputedString.Replace("t","т");
                InputedString.Replace("u","у");
                InputedString.Replace("f","ф");   
            }
            return InputedString.ToString();  //Return transliterated string
        }
    }
}
