// PieChart.cs
using System;
using System.Collections.Generic;

namespace Task_2
{
    public class PieChart : IGraph
    {
        public void Draw(List<DataPoint> dataPoints)
        {
            Console.WriteLine("Drawing Pie Chart");
            foreach (var point in dataPoints)
            {
                Console.WriteLine($"Slice: ({point.X}, {point.Y})");
            }
        }
    }
}