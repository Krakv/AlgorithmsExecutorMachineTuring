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
