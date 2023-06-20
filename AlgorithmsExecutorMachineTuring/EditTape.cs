using System;
using System.ComponentModel;

namespace AlgorithmTuringInterface
{
    public partial class EditTape : Form
    {
        Dictionary<long, string> tape = new Dictionary<long, string>();
        long shift = 0;
        long chosenIndex = 0;
        MachineTuring owner;

        public EditTape(MachineTuring owner, Dictionary<long, string> tape)
        {
            this.owner = owner;
            foreach (long key in tape.Keys)
            {
                this.tape[key] = tape[key];
            }
            InitializeComponent();
        }

        private void PrintIndex(TextBox box, long shift)
        {
            box.Text = (box.TabIndex - 6 + shift).ToString();
        }

        private void PrintTapeElement(TextBox box, long shift, string gap = "")
        {
            Color defaultColor = Color.FromArgb(255, 240, 240, 240);
            long index = box.TabIndex - 17 + shift;
            try
            {
                box.Text = tape[index];
            }
            catch
            {
                box.Text = gap;
            }
            if (chosenIndex == index)
                box.BackColor = Color.LightYellow;
            else
                box.BackColor = defaultColor;
        }

        private void InitializeTape()
        {
            foreach (TextBox textbox in Tape.Controls)
            {
                if (textbox.TabIndex <= 11)
                    PrintIndex(textbox, shift);
                else
                    PrintTapeElement(textbox, shift);
            }
        }

        private void EditTape_Load(object sender, EventArgs e)
        {

        }

        private void NextElement_Click(object sender, EventArgs e)
        {
            shift++;
            InitializeTape();
        }

        private void PreviousElement_Click(object sender, EventArgs e)
        {
            shift--;
            InitializeTape();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shift = chosenIndex;
            InitializeTape();
        }

        private void ChooseElementIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chosenIndex = Int64.Parse(ChooseElementIndexTextBox.Text);
                errorProvider1.SetError(ChooseElementIndexTextBox, "");
            }
            catch
            {
                errorProvider1.SetError(ChooseElementIndexTextBox, "Некорректно введен индекс.");
            }
        }

        private void textBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtbx = sender as TextBox;
            foreach (string index in Data.Actions.Keys)
            {
                if (index == txtbx.Text && index != "_")
                {
                    tape[txtbx.TabIndex - 17 + shift] = txtbx.Text;
                    errorProvider1.SetError(txtbx, null);
                    return;
                }
            }
            if (txtbx.Text != "")
                errorProvider1.SetError(txtbx, "Символ не найден в алфавите таблицы множества состояний.");
            else
            {
                tape.Remove(txtbx.TabIndex - 17 + shift);
                errorProvider1.SetError(txtbx, null);
            }
        }

        private void textBoxes_Validated(object sender, EventArgs e)
        {
            TextBox txtbx = sender as TextBox;

        }

        private void EditTape_Shown(object sender, EventArgs e)
        {
            InitializeTape();
        }

        private void EditTape_Deactivate(object sender, EventArgs e)
        {
            owner.InitializeTape();
        }

        private void EditTape_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Хотите сохранить изменения?", "Выход из программы",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Data.tape = this.tape;
            }
            e.Cancel = !(res == DialogResult.No || res == DialogResult.Yes);
        }
    }
}
