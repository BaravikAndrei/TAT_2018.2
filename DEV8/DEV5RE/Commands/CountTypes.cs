namespace DEV8.Commands
{
    /// <summary>
    /// class CountTypesCommand implements method for command selection.
    /// </summary>
    class CountTypesCommand : ICommand
    {
        Catalog catalog;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="catalog">Catalog of commnds.</param>
        public CountTypesCommand(Catalog catalog)
        {
            this.catalog = catalog;
        }

        /// <summary>
        /// Execute this instance.
        /// </summary>
        public string Execute(Catalog catalog)
        {
            return catalog.CountTypes();
        }
    }
}
