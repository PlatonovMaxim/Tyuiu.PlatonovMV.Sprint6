using System;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task3.V25.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        // исходная матрица из условия
        int[,] mtrx =
        {
            { 14,  5,  -9, 18, 21 },
            { -5, -12, -12,  4, 28 },
            { 27, -2, -14, 23, 27 },
            { -19, -15, 17, 15,  1 },
            { 33,  2,   6, 24, 24 }
        };

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Платонов М.В.";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Настройка DataGridView для матрицы
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_PMV.ColumnCount = columns;
            dataGridViewMatrix_PMV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_PMV.Columns[i].Width = 40;
                dataGridViewMatrix_PMV.Columns[i].HeaderText = (i + 1).ToString();
            }

            // Заполняем сетку исходной матрицей
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    dataGridViewMatrix_PMV.Rows[i].Cells[j].Value = mtrx[i, j];

            textBoxResult_PMV.ReadOnly = true;
            textBoxResult_PMV.Text = ""; // сюда можно выводить какие-то доп. данные, если надо
        }

        private void buttonDone_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] sorted = ds.Calculate(mtrx);

                int rows = sorted.GetUpperBound(0) + 1;
                int columns = sorted.GetUpperBound(1) + 1;

                // Перезаполняем DataGridView отсортированной матрицей
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        dataGridViewMatrix_PMV.Rows[i].Cells[j].Value = sorted[i, j];

                textBoxResult_PMV.Text = "Сортировка выполнена по 3-му столбцу (по возрастанию).";
            }
            catch
            {
                MessageBox.Show("Ошибка при обработке матрицы.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6, таск 3, вариант 25.\n" +
                "Дана матрица 5x5. Выполнить сортировку строк по возрастанию в третьем столбце.\n" +
                "Результат вывести в DataGridView.\n" +
                "Выполнил студент группы ИСТНб-25-1 Платонов Максим Владимирович.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dataGridViewMatrix_PMV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}