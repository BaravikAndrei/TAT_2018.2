using System;
using System.Collections.Generic;


namespace Task_DEV5
{
    /// <summary>
    /// Class CarList for making list from cars.
    /// </summary>
    class CarList
    {
        /// <summary>
        /// Method AddToCarlist checks for correct input and adds cars in list.
        /// </summary>
        public List<Car> listOfCar = new List<Car>();
        public List<Car> AddToCarList(Car car,List<Car> listOfCars)
        {
            if (listOfCars.Count == 0 )
            {
                listOfCars.Add(car);
            }
            else
            {
                 foreach (Car c in listOfCars)
                 {
                     if (c.brand == car.brand && c.model == car.model && c.price == car.price)
                    {
                       c.quantity += car.quantity;
                       break;
                     }
                     else if (c.brand == car.brand && c.model == car.model && c.price != car.price)
                     {
                        Console.WriteLine("incorrect input");
                        break;
                     }
                     else
                     {
                        listOfCars.Add(car);
                        break;
                     }
                }
    
            }


            return listOfCar = listOfCars; //return list of cars
        }
    }
}
