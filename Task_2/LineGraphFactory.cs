using System;
using System.Collections.Generic;

namespace Task_2
{
    public class LineGraphFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new LineGraph();
        }

        public override List<DataPoint> CollectData()
        {
            return new List<DataPoint>();
        }
    }
}