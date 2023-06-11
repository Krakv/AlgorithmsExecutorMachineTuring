namespace AlgorithmsExecutorMachineTuring
{
    partial class AboutProgram
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
            VersionLbl = new Label();
            SupportLbl = new Label();
            SuspendLayout();
            // 
            // VersionLbl
            // 
            VersionLbl.AutoSize = true;
            VersionLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VersionLbl.Location = new Point(12, 9);
            VersionLbl.Name = "VersionLbl";
            VersionLbl.Size = new Size(65, 21);
            VersionLbl.TabIndex = 0;
            VersionLbl.Text = "Version:";
            // 
            // SupportLbl
            // 
            SupportLbl.AutoSize = true;
            SupportLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SupportLbl.Location = new Point(12, 145);
            SupportLbl.Name = "SupportLbl";
            SupportLbl.Size = new Size(178, 63);
            SupportLbl.TabIndex = 1;
            SupportLbl.Text = "Support:\r\nidtokmakov@edu.hse.ru\r\nsrermakov@edu.hse.ru";
            // 
            // AboutProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 217);
            Controls.Add(SupportLbl);
            Controls.Add(VersionLbl);
            Name = "AboutProgram";
            Text = "О программе";
            Load += AboutProgram_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VersionLbl;
        private Label SupportLbl;
    }
}