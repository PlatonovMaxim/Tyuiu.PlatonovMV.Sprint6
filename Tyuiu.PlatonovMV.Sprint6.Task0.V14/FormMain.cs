using System;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task0.V14.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // кнопка "Выполнить"
        private void buttonDone_PMV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_PMV.Text);
                double y = ds.Calculate(x);
                textBoxResult_PMV.Text = y.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // кнопка "?"
        private void buttonHelp_PMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, вариант 14.\n" +
                            "Выполнил студент группы <ИСТНб-25-1> Платонов Максим Владимирович.",
                            "Справка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // ввод только целых чисел
        private void textBoxVarX_PMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelVarX_PMV_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_PMV_Click(object sender, EventArgs e)
        {

        }

        private void labelTask_PMV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_PMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInputData_PMV_Enter(object sender, EventArgs e)
        {

        }
    }
}