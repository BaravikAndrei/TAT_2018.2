using System;
using System.Text;

namespace DEV4
{
    class ParcerXML
    {
    private string pathToTheFile;

        public ParcerXML(string pathToXML)
        {
            pathToTheFile = pathToXML;
        }

        /// <summary> 
        /// Method XMLdataToAnotherForm
        /// A method that processes information from a XML file
        /// </summary> 
        /// <returns>Array of generated information</returns>
        private string[] XMLdataToAnotherForm()
        {
            string[] fileStrings = System.IO.File.ReadAllLines(pathToTheFile);
            string[] arrayOfData = new string[fileStrings.Length];
            int numberOfElementOfDataArray = 0;
            StringBuilder element = new StringBuilder();
            StringBuilder fullStringForElement = new StringBuilder();
            foreach (string readString in fileStrings)
            {
                string stringforWork = readString;
                if (stringforWork.StartsWith("<?xml"))
                {
                    continue;
                }
                if (stringforWork.StartsWith("</"))
                {
                    continue;
                }
                if (stringforWork.StartsWith("<") && stringforWork.Contains("</"))
                {
                    int i = 1;
                    while (stringforWork[i] != '>')
                    {
                        element.Append(stringforWork[i]);
                        i++;
                    }
                    element.Append(' ');
                    i++;
                    fullStringForElement.Append(element);
                    while (stringforWork[i] != '<')
                    {
                        fullStringForElement.Append(stringforWork[i]);
                        i++;
                    }
                    arrayOfData[numberOfElementOfDataArray] = fullStringForElement.ToString();
                    fullStringForElement.Remove(0, fullStringForElement.Length);
                    int begin = 0;
                    int end = 0;
                    for (int j = 0; j < stringforWork.Length; j++)
                    {
                        if (stringforWork[j] == '/')
                        {
                            begin = j;
                        }
                        if (stringforWork[j] == '>')
                        {
                            end = j;
                        }
                    }
                    element.Remove(element.Length - (end - begin), (end - begin));
                    numberOfElementOfDataArray++;
                    continue;
                }
                if (stringforWork.StartsWith("<"))
                {
                    int i = 1;
                    while (stringforWork[i] != '>')
                    {
                        element.Append(stringforWork[i]);
                        i++;
                    }
                    element.Append(' ');
                    continue;
                }
            }
            return Sorting(arrayOfData);
        }
        /// <summary> 
        /// Method Sorting
        /// The method that sorting data
        /// </summary>
        private string[] Sorting (string[] arrayForSorting)
        {
            int sizeTheSortedArray = 0;
            foreach (string nextstring in arrayForSorting)
            {
                if (nextstring != null )
                {
                    sizeTheSortedArray++;
                }
            }
            string[] sortedArray = new string[sizeTheSortedArray];
            for(int i=0;i< sizeTheSortedArray;i++)
            {
                sortedArray[i] = arrayForSorting[i];
            }
            Array.Sort(sortedArray, StringComparer.InvariantCulture);
            return sortedArray;
        }
        /// <summary> 
        /// Method OutputtingDataToConsole
        /// The method that outputs information
        /// </summary> 
        public void OutputtData()
        {
            foreach (string nextstring in XMLdataToAnotherForm())
            {  
               Console.WriteLine(nextstring);  
            }
        }
    }
 }