using System;


namespace DEV1
{
    /// <summary>
    /// Class MaxSequence implements methods of getting max sequence of unrepeated symbls.
    /// </summary>
    class MaxSequence
    {
        public string args;
        public MaxSequence(string sequence)
        {
            this.args = sequence;
        }
        /// <summary>
        /// Method FindMaxSequenc for getting max sequence of unrepeated symbls.
        /// </summary>
        /// <returns>Integer value of max length sequence with unrepeated symbls.></returns>
        public int FindMaxSequence()
        {
            int maxSize = 0;
            if (args.Length == 0)
            {
                Console.WriteLine("empty sequence");
                Console.ReadKey(true);
            }
            else
            {
                int curSize = 0;
                int curElementIndex = 0;
                int N = args.Length;
                bool[] memorizing_duplicate = new bool[256]; //256 is max value of symbol in  ASCII table   
                for (int start = 0; start < N; start++)
                {
                    curElementIndex = start;
                    while (curElementIndex < N)
                    {
                        if (!memorizing_duplicate[args[curElementIndex]] && curElementIndex < N)
                        {
                            curSize++;
                            memorizing_duplicate[args[curElementIndex]] = true;
                            curElementIndex++;
                        }
                        else
                            break;
                    }
                    if (curSize > maxSize)
                    {
                        maxSize = curSize;
                    }
                    curSize = 0;
                    for (int i = 0; i < memorizing_duplicate.Length; i++)
                    {
                        memorizing_duplicate[i] = false;
                    }
                }
            }
            return maxSize;
        }
    }
}
