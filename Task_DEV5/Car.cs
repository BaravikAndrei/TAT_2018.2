using System;

namespace Task_DEV5
{
    /// <summary>
    /// Inputing fields Car.
    /// </summary>
    class Car
    {
        public string brand;
        public string model;
        public int quantity;
        public int price;

        public Car()
        {
            Console.WriteLine("Input brand");
            brand=Console.ReadLine();
            Console.WriteLine("Input model");
            model=Console.ReadLine();
            Console.WriteLine("Input quantity");
            quantity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input price");
            price=Convert.ToInt32(Console.ReadLine());
        }
    }
}
