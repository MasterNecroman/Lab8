using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of graph (Line/Bar/Pie):");
            string graphType = Console.ReadLine();

            GraphFactory graphFactory;

            switch (graphType.ToLower())
            {
                case "line":
                    graphFactory = new LineGraphFactory();
                    break;
                case "bar":
                    graphFactory = new BarGraphFactory();
                    break;
                case "pie":
                    graphFactory = new PieChartFactory();
                    break;
                default:
                    Console.WriteLine("Invalid graph type.");
                    return;
            }

            IGraph graph = graphFactory.CreateGraph();
            List<DataPoint> dataPoints = GetDataFromUser(new List<DataPoint>());

            graph.Draw(dataPoints);

            Console.ReadLine();
        }

        static List<DataPoint> GetDataFromUser(List<DataPoint> dataPoints)
        {
            Console.Write("Enter X value: ");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                Console.Write("Enter Y value: ");
                if (int.TryParse(Console.ReadLine(), out int y))
                {
                    dataPoints.Add(new DataPoint { X = x, Y = y });

                    Console.Write("Do you want to enter more data? (yes/no): ");
                    string moreData = Console.ReadLine().ToLower();

                    if (moreData == "yes")
                    {
                        return GetDataFromUser(dataPoints);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Y value. Please enter a valid integer.");
                    return GetDataFromUser(dataPoints);
                }
            }
            else
            {
                Console.WriteLine("Invalid X value. Please enter a valid integer.");
                return GetDataFromUser(dataPoints);
            }

            return dataPoints;
        }
    }
}