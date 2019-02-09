namespace DEV8
{
    /// <summary>
    /// Represents car entity.
    /// </summary>
    class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }

        /// <summary>
        /// Initialize new car object.
        /// </summary>
        /// <param name="brand">Brend of vehicle.</param>
        /// <param name="model">Model of vehicle.</param>
        /// <param name=quantity">Quantity of vehicle.</param>
        /// <param name="price">Price of one vehicle.</param>
        public Car(string brand, string model, int quantity, decimal price)
        {
            this.brand = brand;
            this.model = model;
            this.quantity = quantity;
            this.price = price;
        }
    }
}

