using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    partial class MachineTuring
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineTuring));
            Tape = new TableLayoutPanel();
            textBox12 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox15 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox21 = new TextBox();
            textBox2 = new TextBox();
            textBox22 = new TextBox();
            textBox20 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            TapeLabel = new Label();
            QuantityLabel = new Label();
            QuantityStates = new Panel();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveFileBtn = new ToolStripMenuItem();
            UploadFileBtn = new ToolStripMenuItem();
            TapeMenuItem = new ToolStripMenuItem();
            TapeFile = new ToolStripMenuItem();
            CreateTapeFile = new ToolStripMenuItem();
            SaveTapeFile = new ToolStripMenuItem();
            OpenTapeFile = new ToolStripMenuItem();
            EditTapeFile = new ToolStripMenuItem();
            TapeSeparator = new ToolStripSeparator();
            InitChosenIndexBtn = new ToolStripMenuItem();
            QuantitiesMenuItem = new ToolStripMenuItem();
            QuantitiesFile = new ToolStripMenuItem();
            CreateQuantitiesFile = new ToolStripMenuItem();
            SaveQuantitiesFile = new ToolStripMenuItem();
            OpenQuantitiesFile = new ToolStripMenuItem();
            EditQuantitiesFile = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            OpenQuantitiesTableBtn = new ToolStripMenuItem();
            скоростьToolStripMenuItem = new ToolStripMenuItem();
            CurrentSpeedTxtBx = new ToolStripMenuItem();
            SpeedTxtBx = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ChangeSpeedBtn = new ToolStripMenuItem();
            Tasks = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            UserGuideMenuItem = new ToolStripMenuItem();
            AboutProgramBtn = new ToolStripMenuItem();
            StartBtn = new Button();
            NextStepBtn = new Button();
            PreviousStepBtn = new Button();
            StartNFinishBtn = new Button();
            FinishBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            table = new DataGridView();
            EditTapeFileBtn = new Button();
            EditQuantitiesFileBtn = new Button();
            button1 = new Button();
            PreviousElement = new Button();
            NextElement = new Button();
            helpProvider1 = new HelpProvider();
            Tape.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // Tape
            // 
            resources.ApplyResources(Tape, "Tape");
            Tape.Controls.Add(textBox12, 0, 1);
            Tape.Controls.Add(textBox16, 0, 1);
            Tape.Controls.Add(textBox17, 0, 1);
            Tape.Controls.Add(textBox15, 0, 1);
            Tape.Controls.Add(textBox13, 0, 1);
            Tape.Controls.Add(textBox14, 0, 1);
            Tape.Controls.Add(textBox21, 0, 1);
            Tape.Controls.Add(textBox2, 0, 0);
            Tape.Controls.Add(textBox22, 0, 1);
            Tape.Controls.Add(textBox20, 0, 1);
            Tape.Controls.Add(textBox18, 0, 1);
            Tape.Controls.Add(textBox19, 0, 1);
            Tape.Controls.Add(textBox4, 0, 0);
            Tape.Controls.Add(textBox5, 0, 0);
            Tape.Controls.Add(textBox6, 0, 0);
            Tape.Controls.Add(textBox1, 0, 0);
            Tape.Controls.Add(textBox3, 0, 0);
            Tape.Controls.Add(textBox10, 0, 0);
            Tape.Controls.Add(textBox11, 0, 0);
            Tape.Controls.Add(textBox9, 0, 0);
            Tape.Controls.Add(textBox7, 0, 0);
            Tape.Controls.Add(textBox8, 0, 0);
            helpProvider1.SetHelpKeyword(Tape, resources.GetString("Tape.HelpKeyword"));
            helpProvider1.SetHelpNavigator(Tape, (HelpNavigator)resources.GetObject("Tape.HelpNavigator"));
            Tape.Name = "Tape";
            helpProvider1.SetShowHelp(Tape, (bool)resources.GetObject("Tape.ShowHelp"));
            // 
            // textBox12
            // 
            resources.ApplyResources(textBox12, "textBox12");
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox12, (bool)resources.GetObject("textBox12.ShowHelp"));
            // 
            // textBox16
            // 
            resources.ApplyResources(textBox16, "textBox16");
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox16, (bool)resources.GetObject("textBox16.ShowHelp"));
            // 
            // textBox17
            // 
            resources.ApplyResources(textBox17, "textBox17");
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox17, (bool)resources.GetObject("textBox17.ShowHelp"));
            // 
            // textBox15
            // 
            resources.ApplyResources(textBox15, "textBox15");
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox15, (bool)resources.GetObject("textBox15.ShowHelp"));
            // 
            // textBox13
            // 
            resources.ApplyResources(textBox13, "textBox13");
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox13, (bool)resources.GetObject("textBox13.ShowHelp"));
            // 
            // textBox14
            // 
            resources.ApplyResources(textBox14, "textBox14");
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox14, (bool)resources.GetObject("textBox14.ShowHelp"));
            // 
            // textBox21
            // 
            resources.ApplyResources(textBox21, "textBox21");
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox21, (bool)resources.GetObject("textBox21.ShowHelp"));
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox2, (bool)resources.GetObject("textBox2.ShowHelp"));
            // 
            // textBox22
            // 
            resources.ApplyResources(textBox22, "textBox22");
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox22, (bool)resources.GetObject("textBox22.ShowHelp"));
            // 
            // textBox20
            // 
            resources.ApplyResources(textBox20, "textBox20");
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox20, (bool)resources.GetObject("textBox20.ShowHelp"));
            // 
            // textBox18
            // 
            resources.ApplyResources(textBox18, "textBox18");
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox18, (bool)resources.GetObject("textBox18.ShowHelp"));
            // 
            // textBox19
            // 
            resources.ApplyResources(textBox19, "textBox19");
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox19, (bool)resources.GetObject("textBox19.ShowHelp"));
            // 
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox4, (bool)resources.GetObject("textBox4.ShowHelp"));
            // 
            // textBox5
            // 
            resources.ApplyResources(textBox5, "textBox5");
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox5, (bool)resources.GetObject("textBox5.ShowHelp"));
            // 
            // textBox6
            // 
            resources.ApplyResources(textBox6, "textBox6");
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox6, (bool)resources.GetObject("textBox6.ShowHelp"));
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox1, (bool)resources.GetObject("textBox1.ShowHelp"));
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox3, (bool)resources.GetObject("textBox3.ShowHelp"));
            // 
            // textBox10
            // 
            resources.ApplyResources(textBox10, "textBox10");
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox10, (bool)resources.GetObject("textBox10.ShowHelp"));
            // 
            // textBox11
            // 
            resources.ApplyResources(textBox11, "textBox11");
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox11, (bool)resources.GetObject("textBox11.ShowHelp"));
            // 
            // textBox9
            // 
            resources.ApplyResources(textBox9, "textBox9");
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox9, (bool)resources.GetObject("textBox9.ShowHelp"));
            // 
            // textBox7
            // 
            resources.ApplyResources(textBox7, "textBox7");
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox7, (bool)resources.GetObject("textBox7.ShowHelp"));
            // 
            // textBox8
            // 
            resources.ApplyResources(textBox8, "textBox8");
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            helpProvider1.SetShowHelp(textBox8, (bool)resources.GetObject("textBox8.ShowHelp"));
            // 
            // TapeLabel
            // 
            resources.ApplyResources(TapeLabel, "TapeLabel");
            helpProvider1.SetHelpKeyword(TapeLabel, resources.GetString("TapeLabel.HelpKeyword"));
            helpProvider1.SetHelpNavigator(TapeLabel, (HelpNavigator)resources.GetObject("TapeLabel.HelpNavigator"));
            TapeLabel.Name = "TapeLabel";
            helpProvider1.SetShowHelp(TapeLabel, (bool)resources.GetObject("TapeLabel.ShowHelp"));
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(QuantityLabel, "QuantityLabel");
            helpProvider1.SetHelpKeyword(QuantityLabel, resources.GetString("QuantityLabel.HelpKeyword"));
            helpProvider1.SetHelpNavigator(QuantityLabel, (HelpNavigator)resources.GetObject("QuantityLabel.HelpNavigator"));
            QuantityLabel.Name = "QuantityLabel";
            helpProvider1.SetShowHelp(QuantityLabel, (bool)resources.GetObject("QuantityLabel.ShowHelp"));
            // 
            // QuantityStates
            // 
            QuantityStates.BorderStyle = BorderStyle.FixedSingle;
            helpProvider1.SetHelpKeyword(QuantityStates, resources.GetString("QuantityStates.HelpKeyword"));
            helpProvider1.SetHelpNavigator(QuantityStates, (HelpNavigator)resources.GetObject("QuantityStates.HelpNavigator"));
            resources.ApplyResources(QuantityStates, "QuantityStates");
            QuantityStates.Name = "QuantityStates";
            helpProvider1.SetShowHelp(QuantityStates, (bool)resources.GetObject("QuantityStates.ShowHelp"));
            // 
            // menuStrip1
            // 
            helpProvider1.SetHelpKeyword(menuStrip1, resources.GetString("menuStrip1.HelpKeyword"));
            helpProvider1.SetHelpNavigator(menuStrip1, (HelpNavigator)resources.GetObject("menuStrip1.HelpNavigator"));
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, TapeMenuItem, QuantitiesMenuItem, скоростьToolStripMenuItem, Tasks, помощьToolStripMenuItem, AboutProgramBtn });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            helpProvider1.SetShowHelp(menuStrip1, (bool)resources.GetObject("menuStrip1.ShowHelp"));
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveFileBtn, UploadFileBtn });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // SaveFileBtn
            // 
            SaveFileBtn.Name = "SaveFileBtn";
            resources.ApplyResources(SaveFileBtn, "SaveFileBtn");
            SaveFileBtn.Click += SaveFileBtn_Click;
            // 
            // UploadFileBtn
            // 
            UploadFileBtn.Name = "UploadFileBtn";
            resources.ApplyResources(UploadFileBtn, "UploadFileBtn");
            UploadFileBtn.Click += UploadFileBtn_Click;
            // 
            // TapeMenuItem
            // 
            TapeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TapeFile, TapeSeparator, InitChosenIndexBtn });
            TapeMenuItem.Name = "TapeMenuItem";
            resources.ApplyResources(TapeMenuItem, "TapeMenuItem");
            // 
            // TapeFile
            // 
            TapeFile.DropDownItems.AddRange(new ToolStripItem[] { CreateTapeFile, SaveTapeFile, OpenTapeFile, EditTapeFile });
            TapeFile.Name = "TapeFile";
            resources.ApplyResources(TapeFile, "TapeFile");
            // 
            // CreateTapeFile
            // 
            CreateTapeFile.Name = "CreateTapeFile";
            resources.ApplyResources(CreateTapeFile, "CreateTapeFile");
            CreateTapeFile.Click += CreateTapeFile_Click;
            // 
            // SaveTapeFile
            // 
            SaveTapeFile.Name = "SaveTapeFile";
            resources.ApplyResources(SaveTapeFile, "SaveTapeFile");
            SaveTapeFile.Click += SaveTapeFile_Click;
            // 
            // OpenTapeFile
            // 
            OpenTapeFile.Name = "OpenTapeFile";
            resources.ApplyResources(OpenTapeFile, "OpenTapeFile");
            OpenTapeFile.Click += OpenTapeFile_Click;
            // 
            // EditTapeFile
            // 
            EditTapeFile.Name = "EditTapeFile";
            resources.ApplyResources(EditTapeFile, "EditTapeFile");
            EditTapeFile.Click += EditTapeFile_Click;
            // 
            // TapeSeparator
            // 
            TapeSeparator.Name = "TapeSeparator";
            resources.ApplyResources(TapeSeparator, "TapeSeparator");
            // 
            // InitChosenIndexBtn
            // 
            InitChosenIndexBtn.Name = "InitChosenIndexBtn";
            resources.ApplyResources(InitChosenIndexBtn, "InitChosenIndexBtn");
            InitChosenIndexBtn.Click += InitChosenIndexBtn_Click;
            // 
            // QuantitiesMenuItem
            // 
            QuantitiesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QuantitiesFile, toolStripSeparator2, OpenQuantitiesTableBtn });
            QuantitiesMenuItem.Name = "QuantitiesMenuItem";
            resources.ApplyResources(QuantitiesMenuItem, "QuantitiesMenuItem");
            // 
            // QuantitiesFile
            // 
            QuantitiesFile.DropDownItems.AddRange(new ToolStripItem[] { CreateQuantitiesFile, SaveQuantitiesFile, OpenQuantitiesFile, EditQuantitiesFile });
            QuantitiesFile.Name = "QuantitiesFile";
            resources.ApplyResources(QuantitiesFile, "QuantitiesFile");
            // 
            // CreateQuantitiesFile
            // 
            CreateQuantitiesFile.Name = "CreateQuantitiesFile";
            resources.ApplyResources(CreateQuantitiesFile, "CreateQuantitiesFile");
            CreateQuantitiesFile.Click += CreateQuantitiesFile_Click;
            // 
            // SaveQuantitiesFile
            // 
            SaveQuantitiesFile.Name = "SaveQuantitiesFile";
            resources.ApplyResources(SaveQuantitiesFile, "SaveQuantitiesFile");
            SaveQuantitiesFile.Click += SaveQuantitiesFile_Click;
            // 
            // OpenQuantitiesFile
            // 
            OpenQuantitiesFile.Name = "OpenQuantitiesFile";
            resources.ApplyResources(OpenQuantitiesFile, "OpenQuantitiesFile");
            OpenQuantitiesFile.Click += OpenQuantitiesFile_Click;
            // 
            // EditQuantitiesFile
            // 
            EditQuantitiesFile.Name = "EditQuantitiesFile";
            resources.ApplyResources(EditQuantitiesFile, "EditQuantitiesFile");
            EditQuantitiesFile.Click += EditQuantitiesFile_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // OpenQuantitiesTableBtn
            // 
            OpenQuantitiesTableBtn.Name = "OpenQuantitiesTableBtn";
            resources.ApplyResources(OpenQuantitiesTableBtn, "OpenQuantitiesTableBtn");
            OpenQuantitiesTableBtn.Click += OpenQuantitiesTableBtn_Click;
            // 
            // скоростьToolStripMenuItem
            // 
            скоростьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CurrentSpeedTxtBx, SpeedTxtBx, toolStripSeparator3, ChangeSpeedBtn });
            скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            resources.ApplyResources(скоростьToolStripMenuItem, "скоростьToolStripMenuItem");
            // 
            // CurrentSpeedTxtBx
            // 
            resources.ApplyResources(CurrentSpeedTxtBx, "CurrentSpeedTxtBx");
            CurrentSpeedTxtBx.Name = "CurrentSpeedTxtBx";
            // 
            // SpeedTxtBx
            // 
            resources.ApplyResources(SpeedTxtBx, "SpeedTxtBx");
            SpeedTxtBx.Name = "SpeedTxtBx";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // ChangeSpeedBtn
            // 
            ChangeSpeedBtn.Name = "ChangeSpeedBtn";
            resources.ApplyResources(ChangeSpeedBtn, "ChangeSpeedBtn");
            ChangeSpeedBtn.Click += ChangeSpeedBtn_Click;
            // 
            // Tasks
            // 
            Tasks.Name = "Tasks";
            resources.ApplyResources(Tasks, "Tasks");
            Tasks.Click += Tasks_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UserGuideMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            resources.ApplyResources(помощьToolStripMenuItem, "помощьToolStripMenuItem");
            // 
            // UserGuideMenuItem
            // 
            UserGuideMenuItem.Name = "UserGuideMenuItem";
            resources.ApplyResources(UserGuideMenuItem, "UserGuideMenuItem");
            UserGuideMenuItem.Click += UserGuideMenuItem_Click;
            // 
            // AboutProgramBtn
            // 
            AboutProgramBtn.Name = "AboutProgramBtn";
            resources.ApplyResources(AboutProgramBtn, "AboutProgramBtn");
            AboutProgramBtn.Click += AboutProgramBtn_Click;
            // 
            // StartBtn
            // 
            resources.ApplyResources(StartBtn, "StartBtn");
            helpProvider1.SetHelpKeyword(StartBtn, resources.GetString("StartBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(StartBtn, (HelpNavigator)resources.GetObject("StartBtn.HelpNavigator"));
            StartBtn.Name = "StartBtn";
            helpProvider1.SetShowHelp(StartBtn, (bool)resources.GetObject("StartBtn.ShowHelp"));
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // NextStepBtn
            // 
            resources.ApplyResources(NextStepBtn, "NextStepBtn");
            helpProvider1.SetHelpKeyword(NextStepBtn, resources.GetString("NextStepBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(NextStepBtn, (HelpNavigator)resources.GetObject("NextStepBtn.HelpNavigator"));
            NextStepBtn.Name = "NextStepBtn";
            helpProvider1.SetShowHelp(NextStepBtn, (bool)resources.GetObject("NextStepBtn.ShowHelp"));
            NextStepBtn.UseVisualStyleBackColor = true;
            // 
            // PreviousStepBtn
            // 
            resources.ApplyResources(PreviousStepBtn, "PreviousStepBtn");
            helpProvider1.SetHelpKeyword(PreviousStepBtn, resources.GetString("PreviousStepBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(PreviousStepBtn, (HelpNavigator)resources.GetObject("PreviousStepBtn.HelpNavigator"));
            PreviousStepBtn.Name = "PreviousStepBtn";
            helpProvider1.SetShowHelp(PreviousStepBtn, (bool)resources.GetObject("PreviousStepBtn.ShowHelp"));
            PreviousStepBtn.UseVisualStyleBackColor = true;
            // 
            // StartNFinishBtn
            // 
            resources.ApplyResources(StartNFinishBtn, "StartNFinishBtn");
            helpProvider1.SetHelpKeyword(StartNFinishBtn, resources.GetString("StartNFinishBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(StartNFinishBtn, (HelpNavigator)resources.GetObject("StartNFinishBtn.HelpNavigator"));
            StartNFinishBtn.Name = "StartNFinishBtn";
            helpProvider1.SetShowHelp(StartNFinishBtn, (bool)resources.GetObject("StartNFinishBtn.ShowHelp"));
            StartNFinishBtn.UseVisualStyleBackColor = true;
            // 
            // FinishBtn
            // 
            resources.ApplyResources(FinishBtn, "FinishBtn");
            helpProvider1.SetHelpKeyword(FinishBtn, resources.GetString("FinishBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(FinishBtn, (HelpNavigator)resources.GetObject("FinishBtn.HelpNavigator"));
            FinishBtn.Name = "FinishBtn";
            helpProvider1.SetShowHelp(FinishBtn, (bool)resources.GetObject("FinishBtn.ShowHelp"));
            FinishBtn.UseVisualStyleBackColor = true;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(table, "table");
            table.Name = "table";
            table.StandardTab = true;
            table.CellEndEdit += Table_CellEndEdit;
            table.ColumnAdded += table_ColumnAdded;
            table.ColumnRemoved += table_ColumnRemoved;
            table.RowsAdded += table_RowAdded;
            table.RowsRemoved += table_RowRemoved;
            // 
            // EditTapeFileBtn
            // 
            EditTapeFileBtn.BackgroundImage = AlgorithmsExecutorMachineTuring.Properties.Resources._1159633;
            resources.ApplyResources(EditTapeFileBtn, "EditTapeFileBtn");
            helpProvider1.SetHelpKeyword(EditTapeFileBtn, resources.GetString("EditTapeFileBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(EditTapeFileBtn, (HelpNavigator)resources.GetObject("EditTapeFileBtn.HelpNavigator"));
            EditTapeFileBtn.Name = "EditTapeFileBtn";
            helpProvider1.SetShowHelp(EditTapeFileBtn, (bool)resources.GetObject("EditTapeFileBtn.ShowHelp"));
            EditTapeFileBtn.UseVisualStyleBackColor = true;
            EditTapeFileBtn.Click += EditTapeFile_Click;
            // 
            // EditQuantitiesFileBtn
            // 
            EditQuantitiesFileBtn.BackgroundImage = AlgorithmsExecutorMachineTuring.Properties.Resources._1159633;
            resources.ApplyResources(EditQuantitiesFileBtn, "EditQuantitiesFileBtn");
            helpProvider1.SetHelpKeyword(EditQuantitiesFileBtn, resources.GetString("EditQuantitiesFileBtn.HelpKeyword"));
            helpProvider1.SetHelpNavigator(EditQuantitiesFileBtn, (HelpNavigator)resources.GetObject("EditQuantitiesFileBtn.HelpNavigator"));
            EditQuantitiesFileBtn.Name = "EditQuantitiesFileBtn";
            helpProvider1.SetShowHelp(EditQuantitiesFileBtn, (bool)resources.GetObject("EditQuantitiesFileBtn.ShowHelp"));
            EditQuantitiesFileBtn.UseVisualStyleBackColor = true;
            EditQuantitiesFileBtn.Click += EditQuantitiesFile_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = AlgorithmsExecutorMachineTuring.Properties.Resources._109164;
            resources.ApplyResources(button1, "button1");
            helpProvider1.SetHelpKeyword(button1, resources.GetString("button1.HelpKeyword"));
            helpProvider1.SetHelpNavigator(button1, (HelpNavigator)resources.GetObject("button1.HelpNavigator"));
            button1.Name = "button1";
            helpProvider1.SetShowHelp(button1, (bool)resources.GetObject("button1.ShowHelp"));
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // PreviousElement
            // 
            PreviousElement.BackgroundImage = AlgorithmsExecutorMachineTuring.Properties.Resources.w512h5121390846436left512;
            resources.ApplyResources(PreviousElement, "PreviousElement");
            helpProvider1.SetHelpKeyword(PreviousElement, resources.GetString("PreviousElement.HelpKeyword"));
            helpProvider1.SetHelpNavigator(PreviousElement, (HelpNavigator)resources.GetObject("PreviousElement.HelpNavigator"));
            PreviousElement.Name = "PreviousElement";
            helpProvider1.SetShowHelp(PreviousElement, (bool)resources.GetObject("PreviousElement.ShowHelp"));
            PreviousElement.UseVisualStyleBackColor = true;
            PreviousElement.Click += PreviousElement_Click;
            PreviousElement.Paint += PreviousElement_Paint;
            // 
            // NextElement
            // 
            NextElement.BackgroundImage = AlgorithmsExecutorMachineTuring.Properties.Resources.w512h5121390846449right512;
            resources.ApplyResources(NextElement, "NextElement");
            helpProvider1.SetHelpKeyword(NextElement, resources.GetString("NextElement.HelpKeyword"));
            helpProvider1.SetHelpNavigator(NextElement, (HelpNavigator)resources.GetObject("NextElement.HelpNavigator"));
            NextElement.Name = "NextElement";
            helpProvider1.SetShowHelp(NextElement, (bool)resources.GetObject("NextElement.ShowHelp"));
            NextElement.UseVisualStyleBackColor = true;
            NextElement.Click += NextElement_Click;
            NextElement.Paint += NextElement_Paint;
            // 
            // helpProvider1
            // 
            resources.ApplyResources(helpProvider1, "helpProvider1");
            // 
            // MachineTuring
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Window;
            Controls.Add(EditTapeFileBtn);
            Controls.Add(EditQuantitiesFileBtn);
            Controls.Add(button1);
            Controls.Add(FinishBtn);
            Controls.Add(StartNFinishBtn);
            Controls.Add(PreviousStepBtn);
            Controls.Add(NextStepBtn);
            Controls.Add(StartBtn);
            Controls.Add(QuantityStates);
            Controls.Add(QuantityLabel);
            Controls.Add(TapeLabel);
            Controls.Add(PreviousElement);
            Controls.Add(NextElement);
            Controls.Add(Tape);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            helpProvider1.SetHelpNavigator(this, (HelpNavigator)resources.GetObject("$this.HelpNavigator"));
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MachineTuring";
            helpProvider1.SetShowHelp(this, (bool)resources.GetObject("$this.ShowHelp"));
            FormClosing += MachineTuring_FormClosing;
            Shown += MachineTuring_Shown;
            Tape.ResumeLayout(false);
            Tape.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TableLayoutPanel Tape;
        private TextBox textBox8;
        private TextBox textBox19;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox7;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox15;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox21;
        private TextBox textBox2;
        private TextBox textBox22;
        private TextBox textBox20;
        private Button NextElement;
        private Button PreviousElement;
        private TextBox textBox16;
        private TextBox textBox12;
        private Label TapeLabel;
        private Label QuantityLabel;
        public Panel QuantityStates;
        private MenuStrip menuStrip1;
        private Button StartBtn;
        private Button NextStepBtn;
        private Button PreviousStepBtn;
        private Button StartNFinishBtn;
        private Button FinishBtn;
        private ErrorProvider errorProvider1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveFileBtn;
        private ToolStripMenuItem UploadFileBtn;
        private ToolStripMenuItem TapeMenuItem;
        private ToolStripMenuItem TapeFile;
        private ToolStripMenuItem CreateTapeFile;
        private ToolStripMenuItem SaveTapeFile;
        private ToolStripMenuItem OpenTapeFile;
        private ToolStripMenuItem EditTapeFile;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem QuantitiesMenuItem;
        private ToolStripMenuItem QuantitiesFile;
        private ToolStripSeparator TapeSeparator;
        private ToolStripMenuItem InitChosenIndexBtn;
        private ToolStripMenuItem CreateQuantitiesFile;
        private ToolStripMenuItem SaveQuantitiesFile;
        private ToolStripMenuItem OpenQuantitiesFile;
        private ToolStripMenuItem EditQuantitiesFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem скоростьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ChangeSpeedBtn;
        private Button EditQuantitiesFileBtn;
        private Button EditTapeFileBtn;
        private ToolStripMenuItem Tasks;
        private ToolStripMenuItem OpenQuantitiesTableBtn;
        private ToolStripMenuItem AboutProgramBtn;
        private ToolStripMenuItem CurrentSpeedTxtBx;
        private ToolStripMenuItem SpeedTxtBx;
        private ToolStripMenuItem UserGuideMenuItem;
        private HelpProvider helpProvider1;
    }
}

