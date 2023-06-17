using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmExecutor
{
    delegate void History(object source, AlgorithmExecutorEventHandler e);

    public class AlgorithmExecutor
    {
        Dictionary<string, List<string>> statesTable;
        string symbol;
        int state;
        private event History OnNextStep;

        public AlgorithmExecutor(Dictionary<string, List<string>> statesTable, string symbol, int state)
        {
            if (isStatesTableCorrect(statesTable))
                this.statesTable = statesTable;
            else
                throw new ArgumentException($"Wrong structure: {statesTable}");
            this.symbol = symbol;
            this.state = state;
            OnNextStep += Journal.AddToJournalNextHistory;
        }

        private static bool isStatesTableCorrect(Dictionary<string, List<string>> statesTable)
        {
            Regex regex = new Regex(@"\A[\w_]?[><=]Q\d+\z");
            foreach(string item in statesTable.Values.SelectMany(x => x))
            {
                if (regex.IsMatch(item))
                {
                    foreach(string key in statesTable.Keys)
                    {
                        if (key == item[0].ToString())
                        {
                            int count = statesTable.Values.Max(x => x.Count);
                            if(Int32.Parse(new Regex(@"Q\d+\z").Matches(item).First().ToString().Substring(1)) <= count)
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool NextStep(out string symbol, out int state, out int shift)
        {
            Regex regex = new Regex(@"\A[\w_]?[><=]Q\d+\z");
            string actions = statesTable[this.symbol][this.state - 1];
            if (regex.IsMatch(actions))
            {
                OnNextStep(this, new AlgorithmExecutorEventHandler(this.symbol, this.state));
                string stringState = new Regex(@"Q\d+\z").Matches(actions).First().ToString().Substring(1);
                state = Int32.Parse(stringState);
                symbol = new Regex(@"\A[\w_]?").Matches(actions).First().ToString();
                if (symbol == "")
                    symbol = "_";
                this.symbol = symbol;
                this.state = state;
                shift = Int32.Parse(new Regex(@"[><=]")
                    .Matches(actions)
                    .First()
                    .ToString()
                    .Replace("<", "-1")
                    .Replace(">", "1")
                    .Replace("=", "0"));
                return true;
            }
            symbol = this.symbol;
            state = this.state;
            shift = 0;
            return false;
        }


        public bool PreviousStep(out string symbol, out int state)
        {
            if (Journal.journal.Count == 0)
            {
                symbol = this.symbol;
                state = this.state;
                return false;
            }
            string[] elems = Journal.GetLast();
            symbol = elems[1];
            state = Int32.Parse(elems[2]);
            this.symbol = symbol;
            this.state = state;
            return true;
        }
    }
}
