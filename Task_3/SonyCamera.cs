using System;

namespace Task_3
{
    public class SonyCamera : ICamera
    {
        public void Capture()
        {
            Console.WriteLine("Capturing photo with Sony Camera");
        }
    }
}