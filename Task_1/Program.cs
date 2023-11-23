using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            Console.WriteLine("Welcome to Configuration Manager Console App");

            while (true)
            {
                Console.WriteLine("\n1. Display Current Settings");
                Console.WriteLine("2. Change Log Mode");
                Console.WriteLine("3. Change Database Connection");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        configManager.DisplaySettings();
                        break;
                    case "2":
                        Console.Write("Enter new Log Mode: ");
                        configManager.LogMode = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Enter new Database Connection: ");
                        configManager.DatabaseConnection = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }
    }
}