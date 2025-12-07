using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task5.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        // Жёстко заданный путь к файлу
        // УБЕДИСЬ, что он совпадает с реальным расположением InPutFileTask5V10.txt
        string path = @"C:\Users\Admin\source\repos\Tyuiu.PlatonovMV.Sprint6\Tyuiu.PlatonovMV.Sprint6.Task5.V10\bin\InPutFileTask5V10.txt";

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Спринт 6 | Таск 5 | Вариант 10 | Платонов М.В.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;

            // Привязки (растягивание)
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewNums_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chartDiag_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDone_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // DataGridView
            dataGridViewNums_PMV.RowHeadersVisible = false;
            dataGridViewNums_PMV.ReadOnly = true;
            dataGridViewNums_PMV.AllowUserToAddRows = false;

            dataGridViewNums_PMV.ColumnCount = 2;
            dataGridViewNums_PMV.Columns[0].HeaderText = "№";
            dataGridViewNums_PMV.Columns[0].Width = 30;
            dataGridViewNums_PMV.Columns[1].HeaderText = "Значение";
            dataGridViewNums_PMV.Columns[1].Width = 80;

            // Chart
            chartDiag_PMV.Series[0].Points.Clear();
            chartDiag_PMV.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartDiag_PMV.ChartAreas[0].AxisX.Title = "Ось X";
            chartDiag_PMV.ChartAreas[0].AxisY.Title = "Ось Y";
        }

        // Кнопка "Выполнить"
        private void buttonDone_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                double[] nums = ds.LoadFromDataFile(path);

                dataGridViewNums_PMV.Rows.Clear();
                chartDiag_PMV.Series[0].Points.Clear();

                for (int i = 0; i < nums.Length; i++)
                {
                    dataGridViewNums_PMV.Rows.Add(
                        (i + 1).ToString(),
                        nums[i].ToString("F3"));

                    chartDiag_PMV.Series[0].Points.AddXY(i + 1, nums[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка "Открыть файл" – просто открыть InPutFileTask5V10.txt в Блокноте
        private void buttonOpenFile_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                // если файла нет – будет исключение
                Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка "Справка"
        private void buttonHelp_PMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6, таск 5, вариант 10.\n" +
                "Прочитать данные из файла InPutFileTask5V10.txt.\n" +
                "Вывести в DataGridView все числа, не равные 0.\n" +
                "Построить диаграмму по этим значениям.\n" +
                "Округлить вещественные значения до трёх знаков.\n" +
                "Выполнил студент группы ИСТНб-25-1 Платонов Максим Владимирович.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}