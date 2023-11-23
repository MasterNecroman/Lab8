using System;

namespace Task_3
{
    public class DesktopScreen : IScreen
    {
        public void Display()
        {
            Console.WriteLine("Displaying on Desktop Screen");
        }
    }
}