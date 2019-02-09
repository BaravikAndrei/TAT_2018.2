namespace DEV8.Commands
{
    /// <summary>
    /// Determines the function of counting.
    /// </summary>
    interface ICommand
    {
        string Execute(Catalog carList);
    }
}
