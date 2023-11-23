using System;

namespace Task_3
{
    public class ConsoleScreen : IScreen
    {
        public void Display()
        {
            Console.WriteLine("Displaying on Console Screen");
        }
    }
}