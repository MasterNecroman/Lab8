using System.Collections.Generic;

namespace Task_2
{
    public abstract class GraphFactory
    {
        public abstract IGraph CreateGraph();

        public abstract List<DataPoint> CollectData();
    }
}