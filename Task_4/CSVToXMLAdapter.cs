using System;

namespace Task_4
{
    public class CSVToXMLAdapter : IDataFormatAdapter
    {
        public void ConvertData(IDataTemplate sourceTemplate, IDataTemplate targetTemplate)
        {
            Console.WriteLine("Converting data from CSV to XML");
            targetTemplate.FillData();
        }
    }
}