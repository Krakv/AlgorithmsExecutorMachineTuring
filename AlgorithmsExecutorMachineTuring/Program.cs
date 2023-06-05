using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                tape.Add(Int32.Parse(keys[i]), values[i]);
            }
            return tape;
        }

        public static object[] ReadActionsFile(string filename)
        {
            actions = new Dictionary<string, List<string>>();
            IEnumerable<string> lines = File.ReadLines(filename, code);
            foreach (string line in lines)
            {
                if (quantity == null)
                    quantity = line.Split(';');
                else
                {
                    List<string> parts = new List<string>(line.Split(';'));
                    string key = parts[0];
                    parts.RemoveAt(0);
                    actions.Add(key, parts);
                }
            }
            return new object[2] { actions, quantity };
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
    }
}
