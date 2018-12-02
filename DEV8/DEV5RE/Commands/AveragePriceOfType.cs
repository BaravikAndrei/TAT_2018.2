namespace DEV8.Commands
{
    /// <summary>
    /// AveragePriceOfTypeCommand implements method for command selection.
    /// </summary>
    class AveragePriceOfTypeCommand : ICommand
    {
        Catalog catalog;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="catalog">Catalog of commnds.</param>
        public AveragePriceOfTypeCommand(Catalog catalog)
        {
            this.catalog = catalog;
        }

        /// <summary>
        /// Execute this instance.
        /// </summary>
        public string Execute(Catalog catalog)
        {
            return catalog.AveragePriceOfType();
        }
    }
}
