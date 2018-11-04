using System;

namespace Task_DEV5
{
    /// <summary>
    /// Class Controller for calling the required methods.
    /// </summary>
    class Controller
    {
        /// <summary>
        /// Method MethodsControll for calling the required methods.
        /// </summary>
        public void MethodsControll(CarList carList)
        {
            Functional func = new Functional();
            string command ="";
            bool exit = false;
            do
            {
                Console.WriteLine("input command: count types | count all | average price | average price of type");
                command=Console.ReadLine();
                switch (command)
                {
                    case "count types":
                        func.CountTypes(carList);
                        break;
                    case "count all":
                        func.CountOfCars(carList);
                        break;
                    case "average price":
                        func.AveragePrice(carList);
                        break;
                    case "average price of type":
                        Console.WriteLine("input type");
                        string type = Console.ReadLine();
                        func.AveragePriceOfType(carList,type);
                        break;
                    case "exit":
                        exit = true;
                        break;
                }
            }while (exit ==false);
        }
    }
}
