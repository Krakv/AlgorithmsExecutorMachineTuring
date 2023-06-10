using AlgorithmTuringInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsExecutorMachineTuring
{
    public partial class Tasks : Form
    {
        string currentTask = "";

        public Tasks()
        {
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

            }
        }
    }
}
