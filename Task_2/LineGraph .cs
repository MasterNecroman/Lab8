// LineGraph.cs
using System;
using System.Collections.Generic;

namespace Task_2
{
    public class LineGraph : IGraph
    {
        public void Draw(List<DataPoint> dataPoints)
        {
            Console.WriteLine("Drawing Line Graph");
            foreach (var point in dataPoints)
            {
                Console.WriteLine($"Point: ({point.X}, {point.Y})");
            }
        }
    }
}