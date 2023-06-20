using System;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;

namespace AlgorithmTuringInterface
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MachineTuring());
        }

        static Encoding code = Encoding.UTF8;
        static string[] quantity = new string[0];
        static Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();
        static Dictionary<long, string> tape = new Dictionary<long, string>();

        public static Dictionary<long, string> ReadTape(string filename)
        {
            tape = new Dictionary<long, string>();
            List<string> lines = new List<string>(File.ReadAllLines(filename));
            string[] keys = lines[0].Split(';');
            string[] values = lines[1].Split(';');
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Trim() != "" && values[i].Trim() != "")
                    tape.Add(Int32.Parse(keys[i]), values[i]);
            }
            return tape;
        }

        public static Dictionary<string, List<string>> ReadActionsFile(string filename)
        {
            actions = new Dictionary<string, List<string>>();
            string[] lines = File.ReadLines(filename, code).ToArray();
            int j = 0;
            while (++j < lines.Length)
            {
                //for (int i = 0; i < lines[j].Length; i++)
                //    lines[j] = lines[j].Replace(";;", ";");
                string[] acts = lines[j].Split(";");
                if (acts[0].Trim() == "")
                    acts[0] = "_";
                actions.Add(acts[0], acts.Skip(1).ToList());
            }
            return actions;
        }

        public static object[] ReadFile(string filename)
        {
            actions = new Dictionary<string, List<string>>();
            tape = new Dictionary<long, string>();
            string[] lines = File.ReadLines(filename, code).ToArray();
            string[] keys = lines[0].Split(';');
            string[] values = lines[1].Split(';');
            for(int i = 0; i < keys.Length; i++)
            {
                if (keys[i] != "")
                    tape.Add(Int64.Parse(keys[i]), values[i]);
            }
            int j = 3;
            while (++j < lines.Length)
            {
                //for (int i = 0; i < lines[j].Length; i++)
                //    lines[j] = lines[j].Replace(";;", ";");
                string[] acts = lines[j].Split(";");
                if (acts[0].Trim() == "")
                    acts[0] = "_";
                actions.Add(acts[0], acts.Skip(1).ToList());
            }
            return new object[] { actions, tape };
        }

        public static string FindPathManually()
        {
            string path = "";
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                if (filePath != string.Empty)
                {
                    path = filePath;
                }
            }
            return path;
        }

        public static void OpenHelpFile(Form form, string path, HelpNavigator navigator = HelpNavigator.TableOfContents)
        {
            System.Windows.Forms.Help.ShowHelp(form, path, navigator);
        }

        public static string ReadTask(string TaskName)
        {
            string filename = "Tasks\\" + TaskName + ".txt";
            return File.ReadAllText(filename);
        }

        public static bool isCorrectTable(Dictionary<string, List<string>> table)
        {
            return true;

        }
        
        public static bool isCorrectTape(Dictionary<long, string> tape, string table)
        {
            return true;

        }
    }
}
