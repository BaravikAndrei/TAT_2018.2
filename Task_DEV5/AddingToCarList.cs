using System;
using System.Collections.Generic;

namespace Task_DEV5
{
    /// <summary>
    /// Class AddingToCarList for repeatyng input cars in list.
    /// </summary>
    class AddingToCarList
    {
        /// <summary>
        /// Method AddingCarsToList repeat request to add cars.
        /// </summary>
        public CarList AddingCarsToList()
        {

            string inputCommand;
            List<Car> listOfCars = new List<Car>();
            CarList carList = new CarList();

            for ( ; ; )
            {   
                inputCommand="y";
                Car car = new Car();
                carList.AddToCarList(car,listOfCars);
                Console.WriteLine("continue input? (y/n)");
                inputCommand = Console.ReadLine();
                if (inputCommand != "y")
                {
                    break;
                }
            }
            return carList;
        }
    }
}
