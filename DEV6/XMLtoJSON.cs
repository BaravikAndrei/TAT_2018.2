using System;
using System.Text;

namespace DEV6
{
    /// <summary>
    /// Class XMLtoJSONconvertor for convert files from XML to JSON type.
    /// </summary>
    class XMLtoJSONconvertor
    {   
        private string pathToFile = "";

        public XMLtoJSONconvertor(string pathToXMLfile)
        {
            pathToFile = pathToXMLfile;
        }
        /// <summary>
        /// Method ConvertXMLtoJSON converts files from XML to JSON type.
        /// </summary>
        public string ConvertXMLtoJSON()
        {
            string[] fileStrings = System.IO.File.ReadAllLines(pathToFile);
            string[] arrayOfData = new string[fileStrings.Length];
            StringBuilder elements = new StringBuilder();
            StringBuilder fullStringForElement = new StringBuilder();
            StringBuilder feeld = new StringBuilder();
            StringBuilder feeld2 = new StringBuilder();
            string[] nest = new string[3];
            int nestingСounter = 0;
            foreach (string element in fileStrings)
            {
                if (element.Contains("Id="))
                {
                    nestingСounter += 1;
                    int i = 2;
                    while (element[i] != '=' && i < element.Length)
                    {
                        if (element[i] != '<' && element[i-2] != ' ' && element[i-1] != ' ' )
                        nest[nestingСounter] += element[i-1];
                        i++;
                    }
                    while (element[i] != '>' && i < element.Length)
                    {
                        feeld2.Append(element[i]).Replace('"'.ToString(), "").Replace(" ","").Replace("=", "");
                        i++;
                    }
                    fullStringForElement.Append('"'.ToString() + nest[nestingСounter] + '"'.ToString() + ": {" + "\n");
                    fullStringForElement.Append('"'.ToString() + "@Id" + '"'.ToString() + ": " + feeld2 + ", \n");
                    feeld2.Clear();
                }
                else if (nestingСounter > 0)
                {
                    if (element.Contains(nest[nestingСounter]))
                    {
                        fullStringForElement.Append("} \n");
                        nestingСounter -= 1;
                        feeld.Clear(); 
                    }
                    else
                    {
                        int i = 0;
                        while (element[i] != '>' && i < element.Length)
                        {
                            if (element[i] != '<' && element[i] != ' ')
                            feeld2.Append(element[i]);
                            i++;
                        }
                        while (/*element[i] != '<' && */i < element.Length && element[i] != '<')
                        {
                            if (element[i] != '>'/* && element[i] != ' '*/)
                            elements.Append(element[i]);
                            i++;
                        }
                        fullStringForElement.Append('"'.ToString()  + feeld2 + '"'.ToString() + ": " + '"'.ToString() + elements + '"'.ToString() + ", \n");
                        elements.Clear();
                        feeld2.Clear();
                    }
                }
            }  
            return fullStringForElement.ToString();
        }
    }
}
