using System;

namespace DEV8
{
    /// <summary>
    /// Class CarsCatalog is an entry point in the program.
    /// </summary>
    class CarsCatalog
    {

        static void Main(string[] args)
        {
            try
            {
                Controller controll = new Controller();
                controll.Manage(args[0], args[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("program error");
            }
        }
    }
}
