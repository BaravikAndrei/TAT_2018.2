using System.Collections.Generic;
using DEV8.Commands;

namespace DEV8
{
    /// <summary>
    /// Invoker used for invoking required methods.
    /// </summary>
    class Invoker
    {
        public List<ICommand> commands = new List<ICommand>();

        /// <summary>
        /// Initialize new Invoker object.
        /// </summary>
        /// <param name="countTypes">Command for count types.</param>
        /// <param name="countCars">Command for count cars.</param>
        /// <param name=averagePrice">Command for count average price of carrs.</param>
        /// <param name="averagePriceOfTypes">Command for count average price of some type carrs.</param>
        public Invoker(ICommand countTypes, ICommand countCars, ICommand averagePrice, ICommand averagePriceOfTypes)
        {
            commands.Add(countTypes);
            commands.Add(countCars);
            commands.Add(averagePrice);
            commands.Add(averagePriceOfTypes);
        }
    }
}
