using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string openFilePath = "";

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Спринт 6 | Таск 7 | Вариант 17 | Платонов М.В.";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // панель с кнопками сверху
            panelTop_PMV.Dock = DockStyle.Top;

            // условие
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // таблицы и разделитель
            SetupGrid(dataGridViewIn_PMV);
            SetupGrid(dataGridViewOut_PMV);

            dataGridViewIn_PMV.Dock = DockStyle.Left;
            splitter_PMV.Dock = DockStyle.Left;
            dataGridViewOut_PMV.Dock = DockStyle.Fill;

            // путь к файлу
            textBoxPath_PMV.ReadOnly = true;

            // кнопки изначально
            buttonRun_PMV.Enabled = false;
            buttonSave_PMV.Enabled = false;

            // ToolTip
            toolTip_PMV.SetToolTip(buttonOpen_PMV, "Открыть файл InPutFileTask7V17.csv");
            toolTip_PMV.SetToolTip(buttonRun_PMV, "Изменить чётные числа во 2-й строке на 4");
            toolTip_PMV.SetToolTip(buttonSave_PMV, "Сохранить результат в OutPutFileTask7.csv");
            toolTip_PMV.SetToolTip(buttonAbout_PMV, "О программе");
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.GridColor = System.Drawing.Color.LightGray;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Открыть файл
        private void buttonOpen_PMV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите файл InPutFileTask7V17.csv";
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openFilePath = ofd.FileName;
                textBoxPath_PMV.Text = openFilePath;

                try
                {
                    string fileData = File.ReadAllText(openFilePath);
                    fileData = fileData.Replace("\r\n", "\n");
                    string[] lines = fileData.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    FillGridFromCsv(dataGridViewIn_PMV, lines);

                    dataGridViewOut_PMV.Rows.Clear();
                    dataGridViewOut_PMV.Columns.Clear();

                    buttonRun_PMV.Enabled = true;
                    buttonSave_PMV.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла:\n" + ex.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FillGridFromCsv(DataGridView dgv, string[] lines)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            if (lines.Length == 0) return;

            string[] firstRow = lines[0].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            int cols = firstRow.Length;

            dgv.ColumnCount = cols;
            for (int c = 0; c < cols; c++)
                dgv.Columns[c].Width = 30;

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == cols)
                    dgv.Rows.Add(parts);
            }
        }

        // Выполнить
        private void buttonRun_PMV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(openFilePath) || !File.Exists(openFilePath))
            {
                MessageBox.Show("Файл не найден. Повторите выбор.");
                buttonRun_PMV.Enabled = false;
                return;
            }

            try
            {
                // читаем матрицу из файла
                int[,] matrix = ds.GetMatrix(openFilePath);

                int rows = matrix.GetUpperBound(0) + 1;
                int cols = matrix.GetUpperBound(1) + 1;

                // изменяем чётные во второй строке (индекс 1) на 4
                int targetRow = 1;
                if (targetRow < rows)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (matrix[targetRow, c] % 2 == 0)
                            matrix[targetRow, c] = 4;
                    }
                }

                ShowMatrix(dataGridViewOut_PMV, matrix);

                buttonSave_PMV.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке матрицы:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowMatrix(DataGridView dgv, int[,] matrix)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            dgv.ColumnCount = cols;
            for (int c = 0; c < cols; c++)
                dgv.Columns[c].Width = 30;

            for (int r = 0; r < rows; r++)
            {
                object[] row = new object[cols];
                for (int c = 0; c < cols; c++)
                    row[c] = matrix[r, c];

                dgv.Rows.Add(row);
            }
        }

        // Сохранить
        private void buttonSave_PMV_Click(object sender, EventArgs e)
        {
            if (dataGridViewOut_PMV.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить результат в OutPutFileTask7.csv";
            sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.FileName = "OutPutFileTask7.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveGridToCsv(dataGridViewOut_PMV, sfd.FileName);
                    MessageBox.Show("Файл успешно сохранён:\n" + sfd.FileName,
                                    "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла:\n" + ex.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveGridToCsv(DataGridView dgv, string path)
        {
            int rows = dgv.RowCount;
            int cols = dgv.ColumnCount;

            StringBuilder sb = new StringBuilder();

            for (int r = 0; r < rows; r++)
            {
                string[] cells = new string[cols];
                for (int c = 0; c < cols; c++)
                {
                    cells[c] = dgv.Rows[r].Cells[c].Value?.ToString() ?? "0";
                }
                sb.AppendLine(string.Join(";", cells));
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        // О программе
        private void buttonAbout_PMV_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}