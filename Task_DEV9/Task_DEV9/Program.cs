using System;

namespace Task_DEV9
{
    /// <summary>
    /// Class EntryPoint is an entry point in the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            UnreadMessages unreadedMessages = new UnreadMessages();
            Console.WriteLine(unreadedMessages.GetUnreadedMessages());
        }
    }
}
