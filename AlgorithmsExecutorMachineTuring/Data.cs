using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmTuringInterface.Program;

namespace AlgorithmTuringInterface
{
    public class Data
    {
        private static Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();
        public static string[] quantities = { "Q1", "Q2" };
        public static Dictionary<int, string> keysIndexes = new Dictionary<int, string>();
        public static Dictionary<long, string> tape = new Dictionary<long, string>();
        public static System.Windows.Forms.DataGridView table = new System.Windows.Forms.DataGridView();

        public static Dictionary<string, List<string>> Actions
        {
            get { return actions; }
            set
            {
                actions = value;
                InitializeKeysIndexes();
            }
        }
        
        public static Dictionary<int, string> KeysIndexes {  get => keysIndexes; private set => keysIndexes = value; }

        public static void InitializeKeysIndexes()
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                KeysIndexes[i] = table.Rows[i].HeaderCell.Value.ToString();
            }
        }
    }
}
