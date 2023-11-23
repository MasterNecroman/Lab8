using System;

namespace Task_4
{
    public class XMLDataTemplate : IDataTemplate
    {
        private string xmlData;

        public IDataTemplate Clone()
        {
            return new XMLDataTemplate();
        }

        public void FillData()
        {
            Console.WriteLine("Enter XML data:");
            xmlData = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Displaying XML data: {xmlData}");
        }
    }
}