using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    public partial class QuantityStatesForm : Form
    {
        Dictionary<string, List<string>> actions;
        Font font = new Font("Microsoft Sans Serif; 16pt", 16);

        public QuantityStatesForm(Dictionary<string, List<string>> actions)
        {
            this.actions = actions;
            InitializeComponent();
            MakeQuantitiesTable();
        }
        
        public void ChangeTableElement(string value, int index)
        {
            QuantitiesTable.Controls[index].Text = value;
        }

        public void ChangeTable(Dictionary<string, List<string>> actions)
        {
            this.actions = actions;
            Controls.Clear();
            MakeQuantitiesTable();
        }

        private void MakeQuantitiesTable()
        {
            foreach (string key in this.actions.Keys.ToArray())
            {
                if (key.Trim() == "")
                {
                    var temp = actions[key];
                    this.actions.Remove(key);
                    actions["_"] = temp;
                }
            }
            QuantitiesTable.Controls.Clear();
            QuantitiesTable.ColumnCount = (from item in actions.Values select item.Count).Max() + 1;
            QuantitiesTable.RowCount = actions.Count + 1;
            QuantitiesTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            QuantitiesTable.AutoSize = true;
            QuantitiesTable.Controls.Add(new Label() { Font = font, AutoSize = true }, 0, 0);
            for (int i = 0; i < QuantitiesTable.ColumnCount - 1; i++)
            {
                Label lbl = new Label() { Text = "Q" + (i + 1), Font = font, Dock = DockStyle.Fill, AutoSize = true, Anchor = AnchorStyles.None };
                QuantitiesTable.Controls.Add(lbl, i + 1, 0);
            }
            int counter = 0;
            foreach (string key in actions.Keys)
            {
                Label lbl1 = new Label() { Text = key, Font = font, Dock = DockStyle.Fill, AutoSize = true, Anchor = AnchorStyles.None };
                QuantitiesTable.Controls.Add(lbl1, 0, ++counter);
                for (int i = 0; i < actions[key].Count; i++)
                {
                    Label lbl = new Label() { Text = actions[key][i], Font = font, AutoSize = true, Dock = DockStyle.Fill, Anchor = AnchorStyles.None };
                    QuantitiesTable.Controls.Add(lbl, i + 1, counter);
                }
            }
            this.Controls.Add(QuantitiesTable);
        }
    }
}
