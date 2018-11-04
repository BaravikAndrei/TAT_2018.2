using System;

namespace Task_DEV5
{
    /// <summary>
    /// Class Functional implements the methods of working with the catalog of machines.
    /// </summary>
    class Functional
    {
        /// <summary>
        /// Method CountTypes calculates and outputs number of different types of cars.
        /// </summary>
        public void CountTypes(CarList carList)
        {
            int countOfTypes=0;
            foreach (Car car in carList.listOfCar)
            {
                countOfTypes+=1;
            }
            Console.WriteLine(countOfTypes);
        }
        /// <summary>
        /// Method CountOfCars calculates and outputs number of cars.
        /// </summary>
        public void CountOfCars(CarList carList)
        {
            int countOfCars=0;
            foreach (Car car in carList.listOfCar)
            {
                countOfCars+=car.quantity;
            }
           Console.WriteLine(countOfCars);
        }
        /// <summary>
        /// Method AveragePrice calculates and outputs average price of all cars.
        /// </summary>
        public void AveragePrice(CarList carList)
        {
            int averagePrice=0;
            int summOfPrice=0;
            int countOfCars=0;
            foreach (Car car in carList.listOfCar)
            {
                summOfPrice+=car.price*car.quantity;
                countOfCars+=car.quantity;
            }
            
            Console.WriteLine(averagePrice=summOfPrice/countOfCars);
        }
        /// <summary>
        /// Method AveragePriceOfType calculates and outputs average price of cars of the same model.
        /// </summary>
        public void AveragePriceOfType(CarList carList, string type)
        {
            int averagePriceOfType=0;
            int summOfPrice=0;
            int countOfCars=0;
            foreach (Car car in carList.listOfCar)
            {
                if (car.brand==type)
                { 
                    summOfPrice+=car.price*car.quantity;
                    countOfCars+=car.quantity;
                }
            }
            Console.WriteLine(averagePriceOfType=summOfPrice/countOfCars);
        }
    }
}
