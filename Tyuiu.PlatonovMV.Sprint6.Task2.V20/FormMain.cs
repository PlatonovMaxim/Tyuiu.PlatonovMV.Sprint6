using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task2.V20.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task2.V20
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();

            // Оформление формы
            this.Text = "Спринт 6 | Таск 2 | Вариант 20 | Платонов М.В.";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Кнопка "Выполнить" - базовый вид
            buttonDone_PMV.BackColor = Color.LimeGreen;
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.FlatAppearance.BorderSize = 1;
            buttonDone_PMV.FlatAppearance.BorderColor = Color.DarkGreen;

            // Настройка графика
            chartFunction_PMV.Titles.Clear();
            chartFunction_PMV.Titles.Add("График функции F(x)");
            chartFunction_PMV.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction_PMV.ChartAreas[0].AxisY.Title = "Ось Y";

            // График изначально пустой, без легенды
            chartFunction_PMV.Series[0].Points.Clear();
            chartFunction_PMV.Series[0].IsVisibleInLegend = false;

            // Столбцы DataGridView (если не заданы в дизайнере)
            if (dataGridViewFunction_PMV.Columns.Count == 0)
            {
                dataGridViewFunction_PMV.Columns.Add("colX", "X");
                dataGridViewFunction_PMV.Columns.Add("colFx", "F(x)");
            }

            dataGridViewFunction_PMV.ReadOnly = true;
            dataGridViewFunction_PMV.AllowUserToAddRows = false;
            dataGridViewFunction_PMV.RowHeadersVisible = false;
        }

        // кнопка "Выполнить"
        private void buttonDone_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_PMV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_PMV.Text);

                if (startStep > stopStep)
                {
                    MessageBox.Show("Начало диапазона не может быть больше конца",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;

                // Очищаем таблицу и график
                dataGridViewFunction_PMV.Rows.Clear();
                chartFunction_PMV.Series[0].Points.Clear();

                int x = startStep;
                for (int i = 0; i < len; i++)
                {
                    // строка в DataGridView
                    dataGridViewFunction_PMV.Rows.Add(
                        x.ToString(),
                        valueArray[i].ToString("F2"));

                    // точка на графике
                    chartFunction_PMV.Series[0].Points.AddXY(x, valueArray[i]);

                    x++;
                }

                // показываем легенду после построения
                chartFunction_PMV.Series[0].IsVisibleInLegend = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка "Справка"2
        private void buttonHelp_PMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6, таск 2, вариант 20.\n" +
                "Табулирование функции F(x) = sin(x)/(x+1,2) - sin(x)*2 - 2x\n" +
                "Выполнил студент группы ИСТНб-25-1 Платонов Максим Владимирович.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Ограничение ввода (старт)
        private void textBoxStartStep_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }

        // Ограничение ввода (конец)
        private void textBoxStopStep_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }

        // Подсветка кнопки "Выполнить" – как у препода,
        // события вешаются через Designer:
        // MouseEnter → buttonDone_PMV_MouseEnter
        // MouseLeave → buttonDone_PMV_MouseLeave
        // MouseDown  → buttonDone_PMV_MouseDown
        // MouseUp    → buttonDone_PMV_MouseUp

        private void buttonDone_PMV_MouseEnter(object sender, EventArgs e)
        {
            // Навели мышь
            buttonDone_PMV.BackColor = Color.Blue;
        }

        private void buttonDone_PMV_MouseLeave(object sender, EventArgs e)
        {
            // Увели мышь
            buttonDone_PMV.BackColor = Color.Red;
        }

        private void buttonDone_PMV_MouseDown(object sender, MouseEventArgs e)
        {
            // Нажали кнопку
            buttonDone_PMV.BackColor = Color.Green;
        }

        private void buttonDone_PMV_MouseUp(object sender, MouseEventArgs e)
        {
            // Отпустили кнопку
            buttonDone_PMV.BackColor = Color.Yellow;
        }

        // Пустой обработчик, если случайно кликнули по графику в дизайнере
        private void chartFunction_PMV_Click(object sender, EventArgs e)
        {
        }
    }
}