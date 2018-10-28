using System;

namespace DEV4
{
    class EnteryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ParcerXML str = new ParcerXML(args[0]);
                str.OutputtData();
            }
            catch (Exception)
            {
                Console.WriteLine("program error");
            }
        }
    }
}
