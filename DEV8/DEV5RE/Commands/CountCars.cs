namespace DEV8.Commands
{
    /// <summary>
    /// CountCarsCommand implements method for command selection.
    /// </summary>
    class CountCarsCommand : ICommand
    {
        Catalog catalog;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="catalog">Catalog of commnds.</param>
        public CountCarsCommand(Catalog catalog)
        {
            this.catalog = catalog;
        }

        /// <summary>
        /// Execute this instance.
        /// </summary>
        public string Execute(Catalog catalog)
        {
            return catalog.CountCars();
        }
    }
}
