using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C:\Users\Jelezo\Documents\Visual Studio 2015\Projects\prog
namespace ConsoleApp1
{
    class Program
    {   
            static void Main(string[] args)
        {
            string symbols = InputSymbols(args);
            MaxSequence(symbols);
         }

          public static string InputSymbols(string[] args)
        {   
            string symbols = "";
            Console.WriteLine("Enter sequence of symbols");
            symbols=Console.ReadLine();
            return symbols;
        }
        //checking for empty sequence
        public static void MaxSequence(string args)
        {
            if(args.Length==0)
                {
                    Console.WriteLine("empty sequence");
                    Console.ReadKey(true);
                }
            //if sequence not empty find max size of sequence with non-repeating characters in a string
            else
                { 
        
                    int curSize = 0;    //sizes of sequence of non-repeating characters in a string
                    int maxSize = 0;    //max from curSize
                    int curElementIndex = 0; 
                    int N=args.Length;
                    bool[] memorizing_duplicate = new bool[256]; //256 is max value of symbol in  ASCII table
        
                    //starting check from first element to lest element of inputed sequence        
                    for (int start = 0; start < N; start++)
                    {
                        curElementIndex = start;  
                        while (curElementIndex < N)
                        {
                            //checks whether the current number of element repeats 
                            if (!memorizing_duplicate[args[curElementIndex]] && curElementIndex < N)
                            {
                                //while no repeating current size is increasing and adding this element in memory of "present" as true
                                curSize++;
                                memorizing_duplicate[args[curElementIndex]] = true;
                                curElementIndex++;
                            }
                            else
                                break;
                        }
                        //find maximum from sizes of sequence with non-repeating characters
                        if (curSize > maxSize)
                        {
                            maxSize = curSize;
                        }
                        //reset current size and the set all letter to false
                        curSize = 0;
                        for (int i = 0; i < memorizing_duplicate.Length; i++)
                            memorizing_duplicate[i] = false;
                     }
             Console.WriteLine ("max lenth of sequence with non-repeating characters="+maxSize);
             Console.ReadKey(true);
            }
        }
    }
}
    
