using AlgorithmTuringInterface;

namespace AlgorithmsExecutorMachineTuring
{
    public partial class Tasks : Form
    {
        string currentTask = "";
        Dictionary<long, string> tape;
        DataGridView table;
        MachineTuring owner;

        public Tasks(ref DataGridView table, MachineTuring owner)
        {
            this.owner = owner;
            this.table = table;
            InitializeComponent();
        }

        private void Task_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                TaskText.Text = Program.ReadTask(btn.Name);
                currentTask = btn.Name;
            }
            catch
            {
                MessageBox.Show("Задание не найдено.");
            }
        }

        private void StartTask_Click(object sender, EventArgs e)
        {
            if (currentTask != "")
            {
                try
                {
                    Button btn = sender as Button;
                    object[] objects = Program.ReadFile("Tasks\\" + currentTask + ".csv");
                    Data.Actions = objects[0] as Dictionary<string, List<string>>;
                    Data.tape = objects[1] as Dictionary<long, string>;
                    owner.CreateTable(Data.Actions, ref table);
                    QuantityStatesForm tablePanel = owner.QuantityStates.Controls[0] as QuantityStatesForm;
                    tablePanel.ChangeTable(Data.Actions);
                    owner.InitializeTape();
                    owner.QuantityStates.Size = new Size(900, 223);
                    owner.TaskBox.Visible = true;
                    owner.TaskBox.Text = TaskText.Text;
                    owner.CloseTaskBoxBtn.Visible = true;
                    MessageBox.Show("Успешно");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Задание не найдено.");
                }
            }
        }
    }
}
