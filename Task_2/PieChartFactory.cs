using System;
using System.Collections.Generic;

namespace Task_2
{
    public class PieChartFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new PieChart();
        }

        public override List<DataPoint> CollectData()
        {
            return new List<DataPoint>();
        }
    }
}