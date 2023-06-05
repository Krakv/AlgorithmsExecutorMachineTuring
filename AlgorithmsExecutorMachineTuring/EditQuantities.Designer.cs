using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    partial class EditQuantities
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
            components = new System.ComponentModel.Container();
            SaveRowsBtn = new Button();
            RowNameLbl = new Label();
            SymbolsTxtBx = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            StatesNumberTxtBx = new TextBox();
            ColumnNameLbl = new Label();
            SetStatesNumberBtn = new Button();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // SaveRowsBtn
            // 
            SaveRowsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveRowsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveRowsBtn.Location = new Point(761, 634);
            SaveRowsBtn.Margin = new Padding(4, 3, 4, 3);
            SaveRowsBtn.Name = "SaveRowsBtn";
            SaveRowsBtn.Size = new Size(204, 31);
            SaveRowsBtn.TabIndex = 1;
            SaveRowsBtn.Text = "Сохранить";
            SaveRowsBtn.UseVisualStyleBackColor = true;
            SaveRowsBtn.Click += SaveRowsBtn_Click;
            // 
            // RowNameLbl
            // 
            RowNameLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RowNameLbl.AutoSize = true;
            RowNameLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RowNameLbl.Location = new Point(24, 637);
            RowNameLbl.Margin = new Padding(4, 0, 4, 0);
            RowNameLbl.Name = "RowNameLbl";
            RowNameLbl.Size = new Size(293, 25);
            RowNameLbl.TabIndex = 2;
            RowNameLbl.Text = "Введите символы алфавита";
            // 
            // SymbolsTxtBx
            // 
            SymbolsTxtBx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SymbolsTxtBx.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SymbolsTxtBx.Location = new Point(356, 634);
            SymbolsTxtBx.Margin = new Padding(4, 3, 4, 3);
            SymbolsTxtBx.MaxLength = 300000;
            SymbolsTxtBx.Name = "SymbolsTxtBx";
            SymbolsTxtBx.Size = new Size(397, 31);
            SymbolsTxtBx.TabIndex = 3;
            SymbolsTxtBx.TextChanged += SymbolsTxtBx_TextChanged;
            SymbolsTxtBx.Validating += SymbolsTxtBx_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // StatesNumberTxtBx
            // 
            StatesNumberTxtBx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StatesNumberTxtBx.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StatesNumberTxtBx.Location = new Point(356, 674);
            StatesNumberTxtBx.Margin = new Padding(4, 3, 4, 3);
            StatesNumberTxtBx.MaxLength = 10;
            StatesNumberTxtBx.Name = "StatesNumberTxtBx";
            StatesNumberTxtBx.Size = new Size(397, 31);
            StatesNumberTxtBx.TabIndex = 7;
            StatesNumberTxtBx.TextChanged += ColumnNameTxtBx_TextChanged;
            StatesNumberTxtBx.Validating += ColumnNameTxtBx_Validating;
            // 
            // ColumnNameLbl
            // 
            ColumnNameLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ColumnNameLbl.AutoSize = true;
            ColumnNameLbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ColumnNameLbl.Location = new Point(24, 677);
            ColumnNameLbl.Margin = new Padding(4, 0, 4, 0);
            ColumnNameLbl.Name = "ColumnNameLbl";
            ColumnNameLbl.Size = new Size(324, 25);
            ColumnNameLbl.TabIndex = 6;
            ColumnNameLbl.Text = "Введите количество состояний";
            // 
            // SetStatesNumberBtn
            // 
            SetStatesNumberBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetStatesNumberBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetStatesNumberBtn.Location = new Point(761, 674);
            SetStatesNumberBtn.Margin = new Padding(4, 3, 4, 3);
            SetStatesNumberBtn.Name = "SetStatesNumberBtn";
            SetStatesNumberBtn.Size = new Size(204, 31);
            SetStatesNumberBtn.TabIndex = 5;
            SetStatesNumberBtn.Text = "Сохранить";
            SetStatesNumberBtn.UseVisualStyleBackColor = true;
            SetStatesNumberBtn.Click += SetStatesNumberBtn_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "UserGuide.chm";
            // 
            // EditQuantities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1008, 729);
            Controls.Add(StatesNumberTxtBx);
            Controls.Add(ColumnNameLbl);
            Controls.Add(SetStatesNumberBtn);
            Controls.Add(SymbolsTxtBx);
            Controls.Add(RowNameLbl);
            Controls.Add(SaveRowsBtn);
            helpProvider1.SetHelpKeyword(this, "24");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.TopicId);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditQuantities";
            helpProvider1.SetShowHelp(this, true);
            Text = "EditQuantities";
            FormClosing += EditQuantities_FormClosing;
            Shown += EditQuantities_Shown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveRowsBtn;
        private Label RowNameLbl;
        private TextBox SymbolsTxtBx;
        private ErrorProvider errorProvider1;
        private TextBox StatesNumberTxtBx;
        private Label ColumnNameLbl;
        private Button SetStatesNumberBtn;
        private HelpProvider helpProvider1;
    }
}