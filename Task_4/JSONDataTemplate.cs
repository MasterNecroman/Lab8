using System;

namespace Task_4
{
    public class JSONDataTemplate : IDataTemplate
    {
        private string jsonData;

        public IDataTemplate Clone()
        {
            return new JSONDataTemplate();
        }

        public void FillData()
        {
            Console.WriteLine("Enter JSON data:");
            jsonData = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Displaying JSON data: {jsonData}");
        }
    }
}