using System;
using System.Collections.Generic;

namespace DEV8
{
    /// <summary>
    /// Store cars list,
    /// engaged in the addition of new car,
    /// and implements methods counting.
    /// </summary>
    class Catalog
    {
        List<Car> carList = new List<Car>();

        /// <summary>
        /// Constructor for Catalog class.
        /// Adds new cars to the list of cars.
        /// </summary>
        public Catalog(List<Car> carList)
        {
            this.carList = carList;
        }


        /// <summary>
        /// Method for count types of cars.
        /// </summary>
        /// <returns>String of count types value.></returns>
        public string CountTypes()
        {
            int countMarks = carList.Count;
            return countMarks.ToString();
        }

        /// <summary>
        /// Method for count all cars.
        /// </summary>
        /// <returns>String of count all cars value.></returns>
        public string CountCars()
        {
            int countCars = 0;
            foreach (Car car in carList)
            {
                countCars += car.quantity;
            }
            return countCars.ToString();
        }

        /// <summary>
        /// Method for count average price of cars.
        /// </summary>
        /// <returns>String of average price of cars value.></returns>
        public string AveragePrice()
        {
            decimal summOfPrice = 0;
            int countOfCars = 0;
            foreach (Car car in carList)
            {
                summOfPrice += car.price * car.quantity;
                countOfCars += car.quantity;
            }
            return (summOfPrice / countOfCars).ToString();
        }

        /// <summary>
        /// Method for count average price of some type cars .
        /// </summary>
        /// <returns>String of average price of some type cars value.></returns>
        public string AveragePriceOfType()
        {
            decimal returnValue = 0;
            Console.WriteLine("Enter a type");
            string type = Console.ReadLine();
            decimal summOfPrice = 0;
            int countOfCars = 0;
            foreach (Car car in carList)
            {
                if (car.brand == type)
                {
                    summOfPrice += car.price * car.quantity;
                    countOfCars += car.quantity;
                    returnValue += summOfPrice / countOfCars;
                }
            }
            return returnValue.ToString();
        }
    }
}
