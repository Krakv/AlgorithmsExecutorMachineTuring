using System;

namespace AlgorithmsExecutorMachineTuring
{
    public partial class AboutProgram : Form
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void AboutProgram_Load(object sender, EventArgs e)
        {
            VersionLbl.Text = "Version:\n" + ProductVersion;
        }
    }
}
