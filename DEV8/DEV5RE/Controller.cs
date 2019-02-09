using System;
using System.Collections.Generic;
using DEV8.Commands;

namespace DEV8
{
    /// <summary>
    /// Controller implements command processing.
    /// </summary>
    class Controller
    {
        /// <summary>
        /// Manage the commands and invokes the required method entered from the keyboard.
        /// </summary>
        /// <param name="pathToCarXML">Path to XML file with cars.</param>
        /// <param name="pathToTruckXML">Path to XML file with trucks.</param>
        public void Manage(string pathToCarXML, string pathToTruckXML)
        {
            ListFromXMLdataBase carList = ListFromXMLdataBase.GetInstance();
            Catalog catalogCar = new Catalog(carList.MakeListFromXMLdataBase(pathToCarXML));
            Catalog catalogTruck = new Catalog(carList.MakeListFromXMLdataBase(pathToTruckXML));
            Invoker invoker = new Invoker(new CountTypesCommand(catalogCar), new CountCarsCommand(catalogCar),
                new AveragePriceCommand(catalogCar), new AveragePriceOfTypeCommand(catalogCar));
            List<ICommand> listCommand = new List<ICommand>();

            string command = "";
            bool exit = false;
            do
            {
                Console.WriteLine("Commands: count types | count all | average price | average price of type | execute");
                command = Console.ReadLine();
                switch (command)
                {
                    case "count types":
                        Console.WriteLine("Input 'c' for car, or 't' for trucks");
                        char kindOfCar = Console.ReadLine().ToCharArray()[0];
                        if (kindOfCar == 'c')
                        {
                            Console.WriteLine(catalogCar.CountTypes());
                        }
                        else if (kindOfCar == 't')
                        {
                            Console.WriteLine(catalogTruck.CountTypes());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    case "count all":
                        Console.WriteLine("Input 'c' for car, or 't' for trucks");
                        kindOfCar = Console.ReadLine().ToCharArray()[0];
                        if (kindOfCar == 'c')
                        {
                            Console.WriteLine(catalogCar.CountCars());
                        }
                        else if (kindOfCar == 't')
                        {
                            Console.WriteLine(catalogTruck.CountCars());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    case "average price":
                        Console.WriteLine("Input 'c' for car, or 't' for trucks");
                        kindOfCar = Console.ReadLine().ToCharArray()[0];
                        if (kindOfCar == 'c')
                        {
                            Console.WriteLine(catalogCar.AveragePrice());
                        }
                        else if (kindOfCar == 't')
                        {
                            Console.WriteLine(catalogTruck.AveragePrice());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    case "average price of type":
                        Console.WriteLine("Input 'c' for car, or 't' for trucks");
                        kindOfCar = Console.ReadLine().ToCharArray()[0];
                        if (kindOfCar == 'c')
                        {
                            Console.WriteLine(catalogCar.AveragePriceOfType());
                        }
                        else if (kindOfCar == 't')
                        {
                            Console.WriteLine(catalogTruck.AveragePriceOfType());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    case "execute":
                        foreach (ICommand ic in invoker.commands)
                        {
                            Console.WriteLine(ic.Execute(catalogCar));
                        }
                        foreach (ICommand ic in invoker.commands)
                        {
                            Console.WriteLine(ic.Execute(catalogTruck));
                        }
                        break;
                    case "exit":
                        exit = true;
                        break;
                }
            } while (exit == false);
        }
    }
}
