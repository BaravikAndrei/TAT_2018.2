using System;

namespace Task_DEV5
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
                Controller contr = new Controller();
                AddingToCarList cars = new AddingToCarList();
                contr.MethodsControll(cars.AddingCarsToList());
            }
            catch (Exception)
            {
                Console.WriteLine("incorrect input");
            }
        }
        
    }
}
