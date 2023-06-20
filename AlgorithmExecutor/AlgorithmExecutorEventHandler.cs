using System;

namespace AlgorithmExecutor
{
    public class AlgorithmExecutorEventHandler
    {
        public string symbol;
        public int state;
        public long index;
        public AlgorithmExecutorEventHandler(string symbol, int state, long index)
        {
            this.symbol = symbol;
            this.state = state;
            this.index = index;
        }
    }
}
