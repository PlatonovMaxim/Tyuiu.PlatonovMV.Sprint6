using System;
using System.Windows.Forms;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            this.Text = "О программе";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelInfo_PMV.Text =
                "Разработчик: Платонов М.В.\n" +
                "Группа: ИСТНб-25-1\n\n" +
                "Программа разработана в рамках изучения языка C#.\n" +
                "Тюменский индустриальный университет (c) 2025\n" +
                "Высшая школа цифровых технологий (c) 2025\n\n" +
                "Внутреннее имя: Tyuiu.PlatonovMV.Sprint6.Task7.V17";
        }

        private void buttonOk_PMV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}