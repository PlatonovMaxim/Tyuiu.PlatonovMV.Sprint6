using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        private string openFilePath = string.Empty;
        private int[,] resultMatrix = null;

        public FormMain()
        {
            InitializeComponent();

            
            this.Text = "Спринт 6 | Таск 7 | Вариант 17 | Платонов М.В.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

           
            openFileDialogTask_PMV.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialogTask_PMV.Title = "Выберите файл InPutFileTask7V17.csv";

            saveFileDialogTask_PMV.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogTask_PMV.Title = "Сохранить результат";
            saveFileDialogTask_PMV.FileName = "OutPutFileTask7.csv";

            
            toolTip_PMV.IsBalloon = true;
            toolTip_PMV.ShowAlways = true;

            toolTip_PMV.SetToolTip(buttonOpen_PMV, "Открыть файл InPutFileTask7V17.csv");
            toolTip_PMV.SetToolTip(buttonRun_PMV, "Изменить чётные числа во 2-й строке на 4");
            toolTip_PMV.SetToolTip(buttonSave_PMV, "Сохранить результат в OutPutFileTask7.csv");
            toolTip_PMV.SetToolTip(buttonAbout_PMV, "О программе");

            
            buttonOpen_PMV.MouseDown += ButtonIcon_MouseDown_ShowTip;
            buttonRun_PMV.MouseDown += ButtonIcon_MouseDown_ShowTip;
            buttonSave_PMV.MouseDown += ButtonIcon_MouseDown_ShowTip;
            buttonAbout_PMV.MouseDown += ButtonIcon_MouseDown_ShowTip;

            
            labelTask_PMV.Text =
                "Дан файл InPutFileTask7V17.csv в котором хранится матрица целочисленных значений.\r\n" +
                "Загрузить файл через openFileDialog в объект dataGridViewIn.\r\n" +
                "Изменить во второй строке чётные числа на 4.\r\n" +
                "Результат вывести в dataGridViewOut. Сохранить результат через saveFileDialog.";

            textBoxPath_PMV.ReadOnly = true;

            
            SetupGrid(dataGridViewIn_PMV);
            SetupGrid(dataGridViewOut_PMV);

           
            buttonRun_PMV.Enabled = false;
            buttonSave_PMV.Enabled = false;
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.MultiSelect = false;

            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ButtonIcon_MouseDown_ShowTip(object sender, MouseEventArgs e)
        {
            if (sender is not Control c) return;

            string text = toolTip_PMV.GetToolTip(c);
            if (string.IsNullOrWhiteSpace(text)) return;

            toolTip_PMV.Show(text, c, 0, c.Height, 1500); 
        }

        // ================== OPEN ==================
        private void buttonOpen_PMV_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_PMV.ShowDialog() != DialogResult.OK)
                return;

            openFilePath = openFileDialogTask_PMV.FileName;
            textBoxPath_PMV.Text = openFilePath;

            try
            {
                
                FillGridFromFile(dataGridViewIn_PMV, openFilePath);

                
                dataGridViewOut_PMV.Rows.Clear();
                dataGridViewOut_PMV.Columns.Clear();
                resultMatrix = null;

                buttonRun_PMV.Enabled = true;
                buttonSave_PMV.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                buttonRun_PMV.Enabled = false;
                buttonSave_PMV.Enabled = false;
            }
        }

        private void FillGridFromFile(DataGridView dgv, string path)
        {
            string[] lines = File.ReadAllLines(path);
            FillGridFromLines(dgv, lines);
        }

        private void FillGridFromLines(DataGridView dgv, string[] lines)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            
            var list = new System.Collections.Generic.List<string>();
            foreach (var l in lines)
                if (!string.IsNullOrWhiteSpace(l))
                    list.Add(l);

            if (list.Count == 0) return;

            int cols = list[0].Split(';').Length;

            dgv.ColumnCount = cols;
            for (int c = 0; c < cols; c++)
                dgv.Columns[c].Width = 40;

            foreach (string line in list)
            {
                string[] parts = line.Split(';');
                if (parts.Length == cols)
                    dgv.Rows.Add(parts);
            }
        }

        // ================== RUN ==================
        private void buttonRun_PMV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(openFilePath) || !File.Exists(openFilePath))
            {
                MessageBox.Show("Сначала выберите файл.");
                buttonRun_PMV.Enabled = false;
                return;
            }

            try
            {
                // Важно: GetMatrix уже возвращает ИЗМЕНЁННУЮ матрицу по заданию
                resultMatrix = ds.GetMatrix(openFilePath);
                ShowMatrix(dataGridViewOut_PMV, resultMatrix);

                buttonSave_PMV.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowMatrix(DataGridView dgv, int[,] matrix)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dgv.ColumnCount = cols;
            for (int c = 0; c < cols; c++)
                dgv.Columns[c].Width = 40;

            for (int r = 0; r < rows; r++)
            {
                object[] row = new object[cols];
                for (int c = 0; c < cols; c++)
                    row[c] = matrix[r, c];

                dgv.Rows.Add(row);
            }
        }

        // ================== SAVE ==================
        private void buttonSave_PMV_Click(object sender, EventArgs e)
        {
            if (resultMatrix == null)
            {
                MessageBox.Show("Сначала выполните обработку (кнопка Выполнить).");
                return;
            }

            if (saveFileDialogTask_PMV.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                SaveMatrixToCsv(resultMatrix, saveFileDialogTask_PMV.FileName);

                MessageBox.Show("Файл сохранён:\n" + saveFileDialogTask_PMV.FileName,
                    "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMatrixToCsv(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            StringBuilder sb = new StringBuilder();

            for (int r = 0; r < rows; r++)
            {
                string[] parts = new string[cols];
                for (int c = 0; c < cols; c++)
                    parts[c] = matrix[r, c].ToString();

                sb.AppendLine(string.Join(";", parts));
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        // ================== ABOUT ==================
        private void buttonAbout_PMV_Click(object sender, EventArgs e)
        {
            using FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}