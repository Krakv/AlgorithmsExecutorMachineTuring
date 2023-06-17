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
        public AlgorithmExecutorEventHandler(string symbol, int state)
        {
            this.symbol = symbol;
            this.state = state;
        }
    }
}
