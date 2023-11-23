using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of product to create (PC/Laptop/Console):");
            string productType = Console.ReadLine();

            IAbstractFactory factory;

            switch (productType.ToLower())
            {
                case "pc":
                    factory = new PCFactory();
                    break;
                case "laptop":
                    factory = new LaptopFactory();
                    break;
                case "console":
                    factory = new ConsoleFactory();
                    break;
                default:
                    Console.WriteLine("Invalid product type.");
                    return;
            }

            IScreen screen = factory.CreateScreen();
            IProcessor processor = factory.CreateProcessor();
            ICamera camera = factory.CreateCamera();

            screen.Display();
            processor.PerformOperation();
            camera.Capture();

            Console.ReadLine();
        }
    }
}