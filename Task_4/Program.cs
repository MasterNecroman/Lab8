using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Data Format Conversion App!");
            Console.WriteLine("-----------------------------------------");

            do
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Convert Data");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice (1/2): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertData();
                        break;
                    case "2":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (true);
        }

        static void ConvertData()
        {
            Console.WriteLine("\nChoose source data format (CSV/XML/JSON):");
            string sourceFormat = Console.ReadLine().ToLower();

            IDataTemplate sourceTemplate = CreateTemplate(sourceFormat);

            Console.WriteLine("\nChoose target data format (CSV/XML/JSON):");
            string targetFormat = Console.ReadLine().ToLower();

            IDataTemplate targetTemplate = CreateTemplate(targetFormat);

            try
            {
                Console.WriteLine("\nEnter data for source format:");
                sourceTemplate.FillData();

                Console.WriteLine("\nData in source format:");
                sourceTemplate.DisplayData();

                IDataFormatAdapter adapter = CreateAdapter(sourceFormat, targetFormat);
                adapter.ConvertData(sourceTemplate, targetTemplate);

                Console.WriteLine("\nData in target format:");
                targetTemplate.DisplayData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static IDataTemplate CreateTemplate(string format)
        {
            switch (format)
            {
                case "csv":
                    return new CSVDataTemplate();
                case "xml":
                    return new XMLDataTemplate();
                case "json":
                    return new JSONDataTemplate();
                default:
                    throw new ArgumentException("Invalid data format.");
            }
        }

        static IDataFormatAdapter CreateAdapter(string sourceFormat, string targetFormat)
        {
            if ((sourceFormat == "csv" && targetFormat == "xml") || (sourceFormat == "xml" && targetFormat == "csv"))
            {
                return new CSVToXMLAdapter();
            }
            else if ((sourceFormat == "json" && targetFormat == "xml") || (sourceFormat == "xml" && targetFormat == "json"))
            {
                return new JSONToXMLAdapter();
            }
            else
            {
                throw new ArgumentException("No direct conversion adapter available.");
            }
        }
    }
}