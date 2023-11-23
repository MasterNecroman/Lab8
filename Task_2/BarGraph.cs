using System;
using System.Collections.Generic;

namespace Task_2
{
    public class BarGraph : IGraph
    {
        public void Draw(List<DataPoint> dataPoints)
        {
            Console.WriteLine("Drawing Bar Graph");
            foreach (var point in dataPoints)
            {
                Console.WriteLine($"Bar: ({point.X}, {point.Y})");
            }
        }
    }
}