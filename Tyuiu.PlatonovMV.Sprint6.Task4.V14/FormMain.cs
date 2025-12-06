using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task4.V14.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Спринт 6 | Таск 4 | Вариант 14 | Платонов М.В.";
            this.StartPosition = FormStartPosition.CenterScreen;

            // график чистый при старте
            chartFunction_PMV.Series[0].Points.Clear();
        }

        // ВЫПОЛНИТЬ
        private void buttonDone_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_PMV.Text);
                int stop = Convert.ToInt32(textBoxStop_PMV.Text);

                if (start > stop)
                {
                    MessageBox.Show("Старт не может быть больше конца");
                    return;
                }

                double[] values = ds.GetMassFunction(start, stop);

                textBoxResult_PMV.Clear();
                chartFunction_PMV.Series[0].Points.Clear();

                int x = start;
                for (int i = 0; i < values.Length; i++)
                {
                    textBoxResult_PMV.AppendText(values[i].ToString("F2") + Environment.NewLine);
                    chartFunction_PMV.Series[0].Points.AddXY(x, values[i]);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        // СОХРАНИТЬ
        private void buttonSave_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                string dir = Directory.GetCurrentDirectory();
                string path = Path.Combine(dir, "OutPutFileTask4V14.txt");

                File.WriteAllText(path, textBoxResult_PMV.Text);

                DialogResult dr = MessageBox.Show(
                    $"Файл сохранён:\n{path}\nОткрыть в Блокноте?",
                    "Сохранение", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", path);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла");
            }
        }

        // СПРАВКА
        private void buttonHelp_PMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6, таск 4, вариант 14.\n" +
                "F(x) = 2x - 4 + (2x - 1)/(sin(x)+1)\n" +
                "Выполнил студент группы ИСТНб-25-1 Платонов Максим Владимирович.",
                "Справка");
        }

        // Ограничение ввода (целые, можно с минусом)
        private void textBoxStart_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }

        private void textBoxStop_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}