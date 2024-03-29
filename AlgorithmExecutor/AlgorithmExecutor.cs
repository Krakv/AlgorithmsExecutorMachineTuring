﻿using System;
using System.Text.RegularExpressions;

namespace AlgorithmExecutor
{
    delegate void History(object source, AlgorithmExecutorEventHandler e);

    public class AlgorithmExecutor
    {
        Dictionary<string, List<string>> statesTable;
        string symbol;
        int state;
        long chosenIndex;
        private event History OnNextStep;

        public AlgorithmExecutor(Dictionary<string, List<string>> statesTable, string symbol, int state, long chosenIndex)
        {
            if (isStatesTableCorrect(statesTable))
                this.statesTable = statesTable;
            else
                throw new ArgumentException($"Wrong structure: {statesTable}");
            this.symbol = symbol;
            this.state = state;
            this.chosenIndex = chosenIndex;
            OnNextStep += Journal.AddToJournalNextHistory;
        }

        private static bool isStatesTableCorrect(Dictionary<string, List<string>> statesTable)
        {
            if (statesTable == null)
                return false;
            Regex regex = new Regex(@"\A[\w_]?[><=]Q\d+\z");
            foreach(string item in statesTable.Values.SelectMany(x => x))
            {
                if (regex.IsMatch(item) || item.Trim() == "")
                {
                    if (item.Trim() != "")
                    {
                        bool flag = false;
                        string sym;
                        if (new Regex(@"[><=]").IsMatch(item[0].ToString()))
                            sym = "_";
                        else
                            sym = item[0].ToString();
                        foreach (string key in statesTable.Keys)
                        {
                            if (key == sym)
                            {
                                int count = statesTable.Values.Max(x => x.Count);
                                if (Int32.Parse(new Regex(@"Q\d+\z").Matches(item).First().ToString().Substring(1)) <= count)
                                    flag = true;
                            }
                        }
                        if (!flag)
                            return false;
                    }
                }
                else return false;
            }
            return true;
        }

        public bool NextStep(ref string symbol, out int state, out long chosenIndex)
        {
            Regex regex = new Regex(@"\A[\w_]?[><=]Q\d+\z");
            if (symbol == "") symbol = "_";
            string actions = statesTable[symbol][this.state - 1];
            if (actions.Trim() != "" && regex.IsMatch(actions))
            {
                OnNextStep(this, new AlgorithmExecutorEventHandler(symbol, this.state, this.chosenIndex));
                string stringState = new Regex(@"Q\d+\z").Matches(actions).First().ToString().Substring(1);
                state = Int32.Parse(stringState);
                this.symbol = symbol;
                symbol = new Regex(@"\A[\w_]?").Matches(actions).First().ToString();
                if (symbol == "")
                    symbol = this.symbol;
                else
                    this.symbol = symbol;
                this.state = state;
                chosenIndex = this.chosenIndex + Int32.Parse(new Regex(@"[><=]")
                    .Matches(actions)
                    .First()
                    .ToString()
                    .Replace("<", "-1")
                    .Replace(">", "1")
                    .Replace("=", "0"));
                this.chosenIndex = chosenIndex;
                return true;
            }
            state = this.state;
            chosenIndex = this.chosenIndex;
            return false;
        }


        public bool PreviousStep(ref string symbol, out int state, out long chosenIndex)
        {
            if (Journal.journal.Count == 0)
            {
                state = this.state;
                chosenIndex = this.chosenIndex;
                return false;
            }
            string[] elems = Journal.GetLast();
            symbol = elems[1];
            state = Int32.Parse(elems[2]);
            chosenIndex = Int32.Parse(elems[3]);
            this.symbol = symbol;
            this.state = state;
            this.chosenIndex = chosenIndex;
            return true;
        }
    }
}
