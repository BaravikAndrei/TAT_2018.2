namespace DEV8.Commands
{
    /// <summary>
    /// AveragePriceCommand implements method for command selection.
    /// </summary>
    class AveragePriceCommand : ICommand
    {
        Catalog catalog;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="catalog">Catalog of commnds.</param>
        public AveragePriceCommand(Catalog catalog)
        {
            this.catalog = catalog;
        }

        /// <summary>
        ///  Execute this instance.
        /// </summary>
        public string Execute(Catalog catalog)
        {
            return catalog.AveragePrice();
        }
    }
}
