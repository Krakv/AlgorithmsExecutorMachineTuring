using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
