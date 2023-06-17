using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExecutor
{
    internal class Journal
    {

        public static int index = -1;
        public static List<string> journal = new List<string>();

        public static void AddToJournalNextHistory(object source, AlgorithmExecutorEventHandler e)
        {
            journal.Add(source.GetType() + ";" + e.symbol + ";" + e.state + ";" + e.index);
            index = journal.Count - 1;
        }

        public static string[] GetLast()
        {
            return journal[index--].Split(';');
        }
    }
}
