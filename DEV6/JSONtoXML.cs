using System.Text;

namespace DEV6
{
    class JSONtoXMLConvertor
    {
       /// <summary>
       /// Class JSONtoXMLConvertor for convert files from JSON to XML type.
       /// </summary>
       private string pathToFile="";

       public JSONtoXMLConvertor(string pathToJSONfile)
        {
           pathToFile=pathToJSONfile;
        }
        /// <summary>
        /// Method ConvertJSONtoXML converts files from JSON to XML type.
        /// </summary>
        public string ConvertJSONtoXML()
        {
            string[] fileStrings = System.IO.File.ReadAllLines(pathToFile);
            string[] arrayOfData = new string[fileStrings.Length];
            StringBuilder elements = new StringBuilder();
            StringBuilder fullStringForElement = new StringBuilder();
            StringBuilder feeld = new StringBuilder();
            StringBuilder feeld2 = new StringBuilder();
            bool nestingСounter = false;
            bool counterr = true;
            foreach (string element in fileStrings)
            {
                if (element.StartsWith("{"))
                {
                    continue;
                }
                else if (element.StartsWith("}"))
                {
                    fullStringForElement.Append("</Root>");
                }
                else if (element.Contains("@Id"))
                {
                    elements.Append("<Root Id =");
                    int i = 0;
                    int counter = 0;
                    while (element[i] != ',')
                    {
                        if (element[i] == ':')
                        {   
                            i++;
                            counter = 1;
                        }
                        if (counter == 1)
                        {
                            elements.Append(element[i]);
                        }
                        i++;
                    }
                    fullStringForElement.Append(elements + ">" + "\n");
                    elements.Clear();
                }
                else if (element.Contains("[") || nestingСounter)
                {
                    if (counterr)
                    {
                        foreach(char c in element)
                        {
                            if (c != '"' && c != '[' && c != ':' && c !=' ')
                            feeld.Append(c);
                        }
                        counterr = false;
                    }
                    if (nestingСounter && !element.Contains("]"))
                    {
                        elements.Append(element).Replace('"'.ToString(),"").Replace(",","").Replace(" ","");
                        fullStringForElement.Append(" " + "<" + feeld + ">" + elements + "</" + feeld + ">" + "\n");
                        elements.Clear();
                    }
                    nestingСounter = true;
                    if (element.Contains("]"))
                    {
                        nestingСounter = false;
                        feeld.Clear();
                    }
                }
                else if (element.Contains("{"))
                {
                        foreach(char c in element)
                        {
                            if (c != '"' && c != '{' && c != ':' && c !=' ')
                            feeld2.Append(c);
                        }
                fullStringForElement.Append("<" + feeld2 + ">" + "\n");
                }
                else if (element.Contains("}"))
                {
                    fullStringForElement.Append("</" + feeld2 + ">" + "\n");
                    feeld2.Clear();
                }
                else if (element.Contains(":"))
                {
                    int i=0;
                    int j = 0;
                    while (element[i] != ':')
                    {
                        if (element[i] != '"' && element[i] != ' ')
                        {
                            feeld.Append(element[i]);
                        }  
                        i++;
                    }
                    while (i < element.Length)
                    {
                        if (element[i] != '"' && element[i] != ',' && element[i] != ':')
                        {
                            elements.Append(element[i]);
                        }
                        i++;
                    }
                    fullStringForElement.Append(" " + "<" + feeld + ">" + elements + "</" + feeld + ">" + "\n");
                    elements.Clear();
                    feeld.Clear();
                }
            }  
            return fullStringForElement.ToString();
        }

    }
}
