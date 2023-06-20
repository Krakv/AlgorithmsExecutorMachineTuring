namespace AlgorithmTuringInterface
{
    partial class QuantityStatesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QuantitiesTable = new TableLayoutPanel();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // QuantitiesTable
            // 
            QuantitiesTable.AutoSize = true;
            QuantitiesTable.BackColor = SystemColors.Window;
            QuantitiesTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            QuantitiesTable.ColumnCount = 1;
            QuantitiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            QuantitiesTable.Location = new Point(0, 0);
            QuantitiesTable.Margin = new Padding(4, 3, 4, 3);
            QuantitiesTable.Name = "QuantitiesTable";
            QuantitiesTable.RowCount = 1;
            QuantitiesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            QuantitiesTable.Size = new Size(233, 115);
            QuantitiesTable.TabIndex = 0;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "UserGuide.chm";
            // 
            // QuantityStatesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(700, 422);
            Controls.Add(QuantitiesTable);
            FormBorderStyle = FormBorderStyle.None;
            helpProvider1.SetHelpKeyword(this, "91");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.TopicId);
            Margin = new Padding(2);
            Name = "QuantityStatesForm";
            helpProvider1.SetShowHelp(this, true);
            Text = "Таблица состояний";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel QuantitiesTable;
        private HelpProvider helpProvider1;
    }
}