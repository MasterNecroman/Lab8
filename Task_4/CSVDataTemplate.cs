using System;

namespace Task_4
{
    public class CSVDataTemplate : IDataTemplate
    {
        private string csvData;

        public IDataTemplate Clone()
        {
            return new CSVDataTemplate();
        }

        public void FillData()
        {
            Console.WriteLine("Enter CSV data:");
            csvData = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Displaying CSV data: {csvData}");
        }
    }
}