using System;

namespace AlgorithmExecutor
{
    public class Journal
    {

        public static List<string> journal = new List<string>();

        public static void AddToJournalNextHistory(object source, AlgorithmExecutorEventHandler e)
        {
            journal.Add(source.GetType() + ";" + e.symbol + ";" + e.state + ";" + e.index);
        }

        public static string[] GetLast()
        {
            if (journal.Count == 0)
                return new string[4] { "None", "", "1", "0"};
            string[] result = journal.Last().Split(";");
            journal.RemoveAt(journal.Count - 1);
            return result;
        }
    }
}
