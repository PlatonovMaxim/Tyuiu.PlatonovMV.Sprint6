using System;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task1.V22.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
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

                textBoxResult_PMV.Text = "";

                // "шапка" таблицы как на картинке
                textBoxResult_PMV.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_PMV.AppendText("|     X     |   F(x)    |" + Environment.NewLine);
                textBoxResult_PMV.AppendText("+-----------+-----------+" + Environment.NewLine);

                int x = startStep;
                for (int i = 0; i <= len - 1; i++)
                {
                    string strLine = string.Format("|{0,5:d}      | {1,7:f2}   |", x, valueArray[i]);
                    textBoxResult_PMV.AppendText(strLine + Environment.NewLine);
                    x++;
                }

                textBoxResult_PMV.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка "Справка"
        private void buttonHelp_PMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6, таск 1, вариант 22.\n" +
                "Табулирование функции F(x) = 3x + 2 - (2x - x)/(cos(x)+1)\n" +
                "Выполнил студент группы ИСТНб-25-1 Платонов Максим Владимирович.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ввод только целых чисел для стартового шага
        private void textBoxStartStep_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // цифры, минус в начале, Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }

        // ввод только целых чисел для конечного шага
        private void textBoxStopStep_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }

        private void labelStopStep_PMV_Click(object sender, EventArgs e)
        {

        }

        private void labelStartStep_PMV_Click(object sender, EventArgs e)
        {

        }
    }
}