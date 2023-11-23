using System;

namespace Task_3
{
    public class CanonCamera : ICamera
    {
        public void Capture()
        {
            Console.WriteLine("Capturing photo with Canon Camera");
        }
    }
}