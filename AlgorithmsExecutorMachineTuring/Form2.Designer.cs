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
            this.QuantitiesTable = new System.Windows.Forms.TableLayoutPanel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // QuantitiesTable
            // 
            this.QuantitiesTable.AutoSize = true;
            this.QuantitiesTable.BackColor = System.Drawing.SystemColors.Window;
            this.QuantitiesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.QuantitiesTable.ColumnCount = 1;
            this.QuantitiesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuantitiesTable.Location = new System.Drawing.Point(0, 0);
            this.QuantitiesTable.Name = "QuantitiesTable";
            this.QuantitiesTable.RowCount = 1;
            this.QuantitiesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuantitiesTable.Size = new System.Drawing.Size(200, 100);
            this.QuantitiesTable.TabIndex = 0;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "UserGuide.chm";
            // 
            // QuantityStatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.QuantitiesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpKeyword(this, "91");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuantityStatesForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel QuantitiesTable;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}