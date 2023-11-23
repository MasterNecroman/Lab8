using System;

namespace Task_4
{
    public class JSONToXMLAdapter : IDataFormatAdapter
    {
        public void ConvertData(IDataTemplate sourceTemplate, IDataTemplate targetTemplate)
        {
            Console.WriteLine("Converting data from JSON to XML");
            targetTemplate.FillData();
        }
    }
}