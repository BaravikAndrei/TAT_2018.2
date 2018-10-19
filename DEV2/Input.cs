using System.Text;


namespace DEV2
{
   // Class for inputing string from comand line.
   static class Input
    {   
        // Realisation of inputing string from comand line.  
        public static string InputString(this string[] args)
        {
            string input="";
            StringBuilder SumOfStrings = new StringBuilder();
            //making a string from inputed strings from comaand line.
            foreach (string i in args)
            {
                SumOfStrings.Append(i + " ");
            }
            input=(SumOfStrings.ToString());
            if(input.Length>0)
            { 
                input.Remove(input.Length - 1, 1);  //Remove last space.
            } 
          
            return input.ToLower();   //Return string at lower bracket
        }
    }
}
