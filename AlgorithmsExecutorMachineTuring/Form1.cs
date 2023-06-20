using System;
using System.Text.RegularExpressions;
using static AlgorithmTuringInterface.Program;
using AlgorithmsExecutorMachineTuring;
using System.ComponentModel;

namespace AlgorithmTuringInterface
{
    public partial class MachineTuring : Form
    {
        Dictionary<long, string> tape;
        DataGridView table;
        long shift = 0;
        internal long chosenIndex = 0;
        int state = 1;
        int speed;
        bool isCreated = false;
        System.Windows.Forms.Timer timer;
        internal AlgorithmExecutor.AlgorithmExecutor executor;
        internal QuantityStatesForm frm;

        public MachineTuring()
        {
            InitializeComponent();

            // Заполнение значений таблицы состояний по умолчанию
            InitializeActions();

            // Создание таблицы состояний
            table = InitializeTable(Data.Actions, table);

            // Сохранение таблицы в общем классе Data
            Data.table = table;

            // Считывание скорости из текстового бокса
            speed = Int32.Parse(Regex.Replace(SpeedTxtBx.Text, @"[^\d]+", ""));

            // Инициализация индексов названий строк (Для удаления строк)
            Data.InitializeKeysIndexes();

            timer = new System.Windows.Forms.Timer() { Interval = speed };
            timer.Tick += NextStepBtn_Click;

            // флажок, указывающий, что объект не находится в процессе инициализации
            isCreated = true;
        }

        public string GetSymbol
        {
            get
            {
                try
                {
                    return Data.tape[chosenIndex];
                }
                catch
                {
                    return "_";
                }
            }
        }

        private void MachineTuring_Shown(object sender, EventArgs e)
        {
            PaintQuantitiesStatesForm(); // Прорисовка таблицы состояний
            InitializeTape(); // Прорисовка значений на ленте
            SymbolsTxtBx.Text = (from DataGridViewRow item in table.Rows
                                 where item.HeaderCell.Value.ToString() != "_"
                                 select item.HeaderCell.Value.ToString())
                                 .ToArray().Aggregate((a, b) => a + b);
        }

        private void MachineTuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Подтверждение выхода из программы
            var res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = !(res == DialogResult.Yes);
        }

        #region Initializing

        public DataGridView InitializeTable(Dictionary<string, List<string>> actions, DataGridView table = null)
        {
            if (table == null)
            {
                table = new System.Windows.Forms.DataGridView();
                table.AllowUserToAddRows = false;
                table.AllowUserToDeleteRows = false;
                table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                table.Name = "table";
                table.StandardTab = true;
                table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEndEdit);
                table.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_ColumnAdded);
                table.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_ColumnRemoved);
                table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_RowAdded);
                table.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_RowRemoved);
            }
            CreateTable(actions, ref table);
            table.Size = new Size(988, 600);
            table.Location = new Point(12, 12);
            table.Dock = DockStyle.None;
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            var rows = from DataGridViewRow row in table.Rows select row;
            foreach (var row in rows)
                if (row.HeaderCell.Value.ToString()?.Trim() == "")
                {
                    row.HeaderCell.Value = "_";
                    return table;
                }
            table.Rows.Add(new DataGridViewRow() { HeaderCell = new DataGridViewRowHeaderCell() { Value = "_" } });
            return table;
        }

        public void CreateTable(Dictionary<string, List<string>> actions, ref DataGridView table)
        {
            isCreated = false;
            table.Rows.Clear();
            table.Columns.Clear();
            // Adding first row (quantities)
            for (int i = 1; i <= actions.Select(x => x.Value.Count).Max(); i++)
            {
                table.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Q" + i, SortMode = DataGridViewColumnSortMode.NotSortable });
            }
            // Adding Rows (actions)
            foreach (string key in actions.Keys)
            {
                DataGridViewCell[] array = new DataGridViewCell[actions[key].Count];
                for (int i = 0; i < actions[key].Count; i++)
                {
                    array[i] = new DataGridViewTextBoxCell() { Value = actions[key][i] };
                }
                DataGridViewRow row = new DataGridViewRow() { HeaderCell = new DataGridViewRowHeaderCell() { Value = key } };
                row.Cells.AddRange(array);
                table.Rows.Add(row);
            }
            isCreated = true;
        }

        private void InitializeActions()
        {
            try
            {
                Data.Actions.Add("", new List<string> { "", "" });
                Data.Actions.Add("0", new List<string> { "", "" });
                Data.Actions.Add("1", new List<string> { "", "" });
            }
            catch
            {
                //nothing
            }
        }

        public void InitializeTape()
        {
            if (chosenIndex > shift + 5)
                shift = chosenIndex - 4;
            if (chosenIndex < shift - 5)
                shift = chosenIndex + 4;
            tape = Data.tape;
            foreach (TextBox textbox in Tape.Controls)
            {
                if (textbox.TabIndex <= 11)
                    PrintIndex(textbox, shift);
                else
                    PrintTapeElement(textbox, shift);
            }
            QuantityStatesForm tablePanel = (QuantityStatesForm)QuantityStates.Controls[0];
            tablePanel.MarkCell(state);
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

        public void PaintQuantitiesStatesForm()
        {
            this.QuantityStates.Controls.Clear();
            QuantityStatesForm frm = new QuantityStatesForm(Data.Actions, ref chosenIndex, ref state, this) { BackColor = Color.White, TopLevel = false, Dock = DockStyle.Fill, TopMost = true };
            this.QuantityStates.Controls.Add(frm);
            frm.Show();
        }

        #region change the square button to a circular button

        // This method will change the square button to a circular button by 
        // creating a new circle-shaped GraphicsPath object and setting it 
        // to the RoundButton objects region.
        private void NextElement_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = NextElement.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-3, -3);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            NextElement.Region = new System.Drawing.Region(buttonPath);
        }

        private void PreviousElement_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = PreviousElement.ClientRectangle;
            newRectangle.Inflate(-3, -3);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            PreviousElement.Region = new System.Drawing.Region(buttonPath);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = button1.ClientRectangle;
            newRectangle.Inflate(-3, -3);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            button1.Region = new System.Drawing.Region(buttonPath);
        }

        #endregion change the square button to a circular button

        #endregion Initializing

        #region Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            shift = chosenIndex;
            InitializeTape();
        }

        private void PreviousElement_Click(object sender, EventArgs e)
        {
            shift--;
            InitializeTape();
        }

        private void NextElement_Click(object sender, EventArgs e)
        {
            shift++;
            InitializeTape();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = true;
            PreviousStepBtn.Enabled = true;
            FinishBtn.Enabled = true;
            StartBtn.Enabled = false;
            InitChosenIndexBtn.Enabled = false;
            File.Enabled = false;
            TapeFile.Enabled = false;
            QuantitiesFile.Enabled = false;
            EditQuantitiesFileBtn.Enabled = false;
            EditTapeFileBtn.Enabled = false;
            Tasks.Enabled = false;
            this.executor = new AlgorithmExecutor.AlgorithmExecutor(Data.Actions, GetSymbol, state, chosenIndex);
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = false;
            PreviousStepBtn.Enabled = false;
            FinishBtn.Enabled = false;
            executor = null;
            state = 1;
            chosenIndex = 0;
            InitializeTape();
            StartBtn.Enabled = true;
            InitChosenIndexBtn.Enabled = true;
            File.Enabled = true;
            TapeFile.Enabled = true;
            QuantitiesFile.Enabled = true;
            EditQuantitiesFileBtn.Enabled = true;
            EditTapeFileBtn.Enabled = true;
            Tasks.Enabled = true;
            StartNFinishBtn.Text = "Выполнить полностью";

        }

        private void StartNFinishBtn_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                if (StartBtn.Enabled)
                    StartBtn_Click(sender, e);
                StartNFinishBtn.Text = "Приостановить";
                timer.Start();
            }
            else
            {
                timer.Stop();
                StartNFinishBtn.Text = "Выполнить полностью";
            }
        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if (executor == null)
            {
                timer.Stop();
                FinishBtn_Click(sender, e);
                return;
            }
            string symbol = GetSymbol;
            long chosenIndex;
            int state;
            bool isFinished = !executor.NextStep(ref symbol, out state, out chosenIndex);
            if (isFinished)
            {
                FinishBtn_Click(sender, e);
                return;
            }
            this.state = state;
            if (symbol == "_")
                tape.Remove(this.chosenIndex);
            else
                tape[this.chosenIndex] = symbol;
            this.chosenIndex = chosenIndex;
            InitializeTape();
        }

        private void PreviousStepBtn_Click(object sender, EventArgs e)
        {
            string symbol = GetSymbol;
            long chosenIndex;
            int state;
            bool isFinished = !executor.PreviousStep(ref symbol, out state, out chosenIndex);
            if (isFinished)
            {
                FinishBtn_Click(sender, e);
                return;
            }
            this.state = state;
            this.chosenIndex = chosenIndex;
            tape[this.chosenIndex] = symbol.Replace("_", "");
            InitializeTape();
        }

        #endregion Buttons

        #region Upper Menu

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    myStream = saveFileDialog1.OpenFile();
                }
                catch
                {
                    MessageBox.Show("Файл используется другим процессом.");
                    return;
                }
                if (myStream != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        if (Data.tape.Keys.Count == 0)
                        {
                            MessageBox.Show("Лента пустая.");
                        }
                        else
                        {
                            long[] keys = new long[Data.tape.Count];
                            long counter = 0;
                            foreach (long index in Data.tape.Keys)
                            {
                                keys[counter++] = index;
                            }
                            Array.Sort(keys);
                            for (long i = keys[0]; i <= keys[keys.Length - 1]; i++)
                            {
                                writer.Write(i);
                                writer.Write(';');
                            }
                            writer.WriteLine();
                            for (long i = keys[0]; i <= keys[keys.Length - 1]; i++)
                            {
                                try
                                {
                                    writer.Write(Data.tape[i]);
                                }
                                catch
                                {
                                }
                                writer.Write(';');
                            }
                        }
                        writer.WriteLine();
                        writer.WriteLine();
                        writer.Write(' ');
                        int length = (from item in Data.Actions.Values
                                      select item.Count())
                                      .Max();
                        for (int i = 1; i <= length; i++)
                        {
                            writer.Write(';');
                            writer.Write("Q" + i);
                        }
                        writer.WriteLine();
                        foreach (string str in Data.Actions.Keys)
                        {
                            writer.Write(str.Replace("_", " "));
                            foreach (string action in Data.Actions[str])
                            {
                                writer.Write(';');
                                writer.Write(action);
                            }
                            writer.WriteLine();
                        }
                    }
                    myStream.Close();
                }
            }
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            string path = FindPathManually();
            try
            {
                var objects = Program.ReadFile(path);
                Dictionary<string, List<string>> actions = (Dictionary<string, List<string>>)objects[0];
                if (!isCorrectTable(actions))
                {
                    throw new Exception();
                }
                Data.Actions = actions;
                Dictionary<long, string> tape = (Dictionary<long, string>)objects[1];
                if (!isCorrectTape(tape, SymbolsTxtBx.Text))
                    throw new Exception();
                Data.tape = tape;
                CreateTable(Data.Actions, ref table);
                QuantityStatesForm? tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                tablePanel?.ChangeTable(Data.Actions);
                InitializeTape();
                MessageBox.Show("Успешно");
            }
            catch
            {
                MessageBox.Show("Не удалось");
            }
        }

        #region TapeFile

        private void OpenTapeFile_Click(object sender, EventArgs e)
        {
            string tapePath = string.Empty;
            try
            {
                tapePath = Program.FindPathManually();
                Dictionary<long, string> tape = Program.ReadTape(tapePath);
                if (!isCorrectTape(tape, SymbolsTxtBx.Text))
                    throw new Exception();
                Data.tape = tape;
                InitializeTape();
            }
            catch
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Не удалось считать файл из выбранного пути.";
                string caption = "Ошибка ввода";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void EditTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(this, tape);
            editTape.Show();
        }

        private void CreateTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(this, new Dictionary<long, string>());
            editTape.Show();
        }

        private void SaveTapeFile_Click(object sender, EventArgs e)
        {
            if (Data.tape.Keys.Count == 0)
            {
                MessageBox.Show("Лента пустая.");
                return;
            }

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        long[] keys = new long[Data.tape.Count];
                        long counter = 0;
                        foreach (long index in Data.tape.Keys)
                        {
                            keys[counter++] = index;
                        }
                        Array.Sort(keys);
                        for (long i = keys[0]; i <= keys[keys.Length - 1]; i++)
                        {
                            writer.Write(i);
                            writer.Write(';');
                        }
                        writer.WriteLine();
                        for (long i = keys[0]; i <= keys[keys.Length - 1]; i++)
                        {
                            try
                            {
                                writer.Write(Data.tape[i]);
                            }
                            catch
                            {
                            }
                            writer.Write(';');
                        }
                        writer.Close();
                    }

                    myStream.Close();
                }
            }
        }

        #endregion TapeFile

        #region QuantitiesFile

        private void OpenQuantitiesFile_Click(object sender, EventArgs e)
        {
            string actionsPath = string.Empty;
            try
            {
                actionsPath = Program.FindPathManually();
                Dictionary<string, List<string>> actions = Program.ReadActionsFile(actionsPath);
                if (!isCorrectTable(actions))
                {
                    throw new Exception();
                }
                Data.Actions = actions;
                CreateTable(Data.Actions, ref table);
                QuantityStatesForm tablePanel = (QuantityStatesForm)QuantityStates.Controls[0];
                tablePanel.ChangeTable(Data.Actions);
            }
            catch
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Не удалось считать файл из выбранного пути.";
                string caption = "Ошибка ввода";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void EditQuantitiesFile_Click(object sender, EventArgs e)
        {
            EditQuantities editQuantities = new EditQuantities(this, table);
            editQuantities.Show();
        }

        private void CreateQuantitiesFile_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();
            actions.Add("_", new List<string>() { " " });
            isCreated = false;
            EditQuantities editQuantities = new EditQuantities(this, InitializeTable(actions));
            isCreated = true;
            editQuantities.Show();
        }

        private void SaveQuantitiesFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        writer.Write(' ');
                        int length = (from item in Data.Actions.Values
                                      select item.Count())
                                      .Max();
                        for (int i = 1; i <= length; i++)
                        {
                            writer.Write(';');
                            writer.Write("Q" + i);
                        }
                        writer.WriteLine();
                        foreach (string str in Data.Actions.Keys)
                        {
                            writer.Write(str);
                            foreach (string action in Data.Actions[str])
                            {
                                writer.Write(';');
                                writer.Write(action);
                            }
                            writer.WriteLine();
                        }
                    }
                    myStream.Close();
                }
            }
        }

        #endregion QuantitiesFile

        #region other

        private void AboutProgramBtn_Click(object sender, EventArgs e)
        {
            Form form = new AboutProgram();
            form.Show();
        }

        private void Tasks_Click(object sender, EventArgs e)
        {
            Form form = new Tasks(ref table, this);
            form.Show();
        }

        private void InitChosenIndexBtn_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите целое число - индекс элемента, с которого будет произведен запуск алогритма:");
            bool isSuccess = result == "" || Int64.TryParse(result, out chosenIndex);
            if (!isSuccess)
            {
                MessageBox.Show("Введенный индекс не является целым числом", "Ошибка ввода", MessageBoxButtons.OK);
                InitChosenIndexBtn_Click(sender, e);
                return;
            }
            if (result != "")
                InitializeTape();
        }

        private void OpenQuantitiesTableBtn_Click(object sender, EventArgs e)
        {
            QuantityStatesForm frm = new QuantityStatesForm(Data.Actions, ref chosenIndex, ref state, this, true) { FormBorderStyle = FormBorderStyle.Sizable };
            this.frm = frm;
            frm.Show();
        }

        private void ChangeSpeedBtn_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите положительное число - скорость выполнения алгоритма:");
            bool isSuccess = result == "" || Int32.TryParse(result, out speed) && speed >= 0;
            if (!isSuccess)
            {
                MessageBox.Show("Не удалось получить положительное число", "Ошибка ввода", MessageBoxButtons.OK);
                ChangeSpeedBtn_Click(sender, e);
                return;
            }
            timer.Interval = speed;
            if (result != "")
                SpeedTxtBx.Text = speed.ToString() + " мс";
        }

        private void UserGuideMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Environment.CurrentDirectory + "\\UserGuide.chm");
        }

        #endregion other

        #endregion Upper menu

        #region TableEdited

        public void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Regex regex = new Regex(@"\A[\w_]?[><=]Q\d+\z");
            string? text = table[e.ColumnIndex, e.RowIndex].Value?.ToString();
            if (text == null)
            {
                Data.Actions[table.Rows[e.RowIndex].HeaderCell.Value.ToString()][e.ColumnIndex] = "";
                return;
            }
            if (regex.IsMatch(text))
            {
                table[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                Data.Actions[table.Rows[e.RowIndex].HeaderCell.Value.ToString()][e.ColumnIndex] = table[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            else
            {
                table[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.IndianRed;
                if (new Regex(@"\A\W[><=]").IsMatch(text))
                    MessageBox.Show("Символ алфавита перед символом перемещения (><=) не должен быть знаком\n" +
                        "Пример: (*Символ*>Q1)");
                if (!new Regex(@"[><=]").IsMatch(text))
                    MessageBox.Show("Ячейка должна содержать символ перемещения (><=)\n" +
                        "Пример: (*Символ*>Q1)");
                if (!new Regex(@"Q\d+").IsMatch(text))
                    MessageBox.Show("Ячейка должна содержать символ состояния (Q) и его номер\n" +
                        "Пример: (*Символ*>Q12)");
            }
            //    QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
            //    tablePanel.ChangeTableElement(table[e.ColumnIndex, e.RowIndex].Value.ToString(), (e.RowIndex + 1) * (table.ColumnCount + 1)  + e.ColumnIndex + 1);
        }

        private void table_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (isCreated)
            {
                string[] states = new string[table.Columns.Count];
                int counter = 0;
                foreach (DataGridViewColumn dataGridViewColumn in table.Columns)
                    states[counter++] = dataGridViewColumn.HeaderText;
                Data.quantities = states;
                foreach (List<string> list in Data.Actions.Values)
                    list.Add("");
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }

        private void table_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            if (isCreated)
            {
                string[] states = new string[table.Columns.Count];
                int counter = 0;
                foreach (DataGridViewColumn dataGridViewColumn in table.Columns)
                    states[counter++] = dataGridViewColumn.HeaderText;
                Data.quantities = states;
                foreach (List<string> list in Data.Actions.Values)
                    list.RemoveAt(e.Column.DisplayIndex);
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }

        private void table_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (isCreated)
            {
                List<string> elems = new List<string>();
                for (int i = 0; i < table.Columns.Count; i++)
                    elems.Add("");
                Data.Actions.Add(table.Rows[e.RowIndex].HeaderCell.Value.ToString(), elems);
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }

        private void table_RowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (isCreated)
            {
                Data.Actions.Remove(Data.KeysIndexes[e.RowIndex]);
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.AutoScrollPosition = new Point(0, 0);
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }

        #endregion TableEdited

        private void CloseTaskBoxBtn_Click(object sender, EventArgs e)
        {
            QuantityStates.Size = new Size(900, 323);
            TaskBox.Visible = false;
            TaskBox.Text = "";
            CloseTaskBoxBtn.Visible = false;
        }

        private void MachineTuring_Load(object sender, EventArgs e)
        {
        }

        private void SaveRowsBtn_Click(object sender, EventArgs e)
        {
            var rows = from DataGridViewRow row in table.Rows select row;
            var syms = from DataGridViewRow item in table.Rows select item.HeaderCell.Value?.ToString();
            var symbols = from sym in SymbolsTxtBx.Text.Trim() select sym.ToString();
            {
                foreach (var sym in syms.Except(symbols).ToArray())
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
            QuantityStatesForm tablePanel = (QuantityStatesForm)QuantityStates.Controls[0];
            tablePanel.ChangeTable(Data.Actions); // Перерисовка таблицы в форме-владельце
        }

        private void SymbolsTxtBx_Validating(object sender, CancelEventArgs e)
        {
            SymbolsTxtBx.Text = new String(SymbolsTxtBx.Text.Where(c => Char.IsLetter(c) || Char.IsDigit(c)).Distinct().ToArray());
        }
    }
}
