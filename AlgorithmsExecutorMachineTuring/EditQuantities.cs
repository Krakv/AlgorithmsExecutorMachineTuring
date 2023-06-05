using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    public partial class EditQuantities : Form
    {
        MachineTuring owner;
        DataGridView table;

        public EditQuantities(MachineTuring owner, DataGridView table)
        {
            InitializeComponent();
            this.owner = owner; // Добавление формы-владельца, которая инициировала запуск данной формы
            this.table = table; // Передача таблицы DataGridVie
            Controls.Add(table); // Добавление таблицы в форму
        }

        private void EditQuantities_Shown(object sender, EventArgs e)
        {
            owner.Enabled = false; // Выключение формы-владельца
            SymbolsTxtBx.Text = (from DataGridViewRow item in table.Rows
                                 where item.HeaderCell.Value.ToString() != "_"
                                 select item.HeaderCell.Value.ToString())
                                 .ToArray().Aggregate((a, b) => a + b);
            StatesNumberTxtBx.Text = table.ColumnCount.ToString();
        }

        private void EditQuantities_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls.Clear(); // Для избежания удаления таблицы в качестве мусора
            QuantityStatesForm tablePanel = owner.QuantityStates.Controls[0] as QuantityStatesForm;
            tablePanel.ChangeTable(Data.Actions); // Перерисовка таблицы в форме-владельце
            owner.Enabled = true; // Включение формы-владельца
        }

        #region RowFuncs

        private void SaveRowsBtn_Click(object sender, EventArgs e)
        {
            var rows = from DataGridViewRow row in table.Rows select row;
            var syms = from DataGridViewRow item in table.Rows select item.HeaderCell.Value?.ToString();
            var symbols = from sym in SymbolsTxtBx.Text.Trim() select sym.ToString();
            {
                foreach (var sym in syms.Except(symbols))
                {
                    foreach (var item in rows)
                        if (item.HeaderCell.Value.ToString() == sym && item.HeaderCell.Value.ToString() != "_")
                        {
                            table.Rows.Remove(item);
                            break;
                        }
                }
                foreach (var sym in symbols.Except(from item in rows select item.HeaderCell.Value?.ToString()))
                {
                    DataGridViewRow row = new DataGridViewRow() { HeaderCell = new DataGridViewRowHeaderCell() { Value = sym } };
                    table.Rows.Add(row);
                }
            }
        }

        private void SymbolsTxtBx_TextChanged(object sender, EventArgs e)
        {
            //SaveRowsBtn.Enabled = true;
        }
        private void SymbolsTxtBx_Validating(object sender, CancelEventArgs e)
        {
            SymbolsTxtBx.Text = new String(SymbolsTxtBx.Text.Where(c => Char.IsLetter(c) || Char.IsDigit(c)).Distinct().ToArray()); ;
        }

        #endregion RowFuncs

        #region ColumnFuncs

        private void SetStatesNumberBtn_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(StatesNumberTxtBx.Text.Trim());
            if (index > table.ColumnCount)
                for (int i = table.ColumnCount + 1; i <= index; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn() { HeaderText = "Q" + i };
                    table.Columns.Add(column);
                }
            else
            {
                for (int i = table.ColumnCount; i > index; i--)
                {
                    table.Columns.RemoveAt(i - 1);
                }
            }

        }

        private void ColumnNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            SetStatesNumberBtn.Enabled = true;
        }

        private void ColumnNameTxtBx_Validating(object sender, CancelEventArgs e)
        {
            // Если в текстовом боксе ничего не написано
            if (StatesNumberTxtBx.Text.Trim() == "")
                return;

            int number;
            // если введенный номер состояния не натуральное число
            if (!Int32.TryParse(StatesNumberTxtBx.Text, out number) || number < 1)
            {
                if (StatesNumberTxtBx.Text != "")
                    errorProvider1.SetError(StatesNumberTxtBx, "Введите натуральное число - количество состояний.");
                SetStatesNumberBtn.Enabled = false;
                return;
            }
            // если введенный номер удовлетворяет ограничениям
            errorProvider1.SetError(StatesNumberTxtBx, null);
            SetStatesNumberBtn.Enabled = true;
        }

        #endregion ColumnFuncs




    }
}
