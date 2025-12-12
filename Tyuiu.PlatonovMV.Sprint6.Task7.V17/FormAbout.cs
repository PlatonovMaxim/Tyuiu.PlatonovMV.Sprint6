using System;
using System.Windows.Forms;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();


            labelInfo_PMV.Text =
                "Разработчик: Платонов М.В.\r\n" +
                "Группа: ИСТНб-25-1\r\n\r\n" +
                "Программа разработана в рамках изучения языка C#.\r\n" +
                "Тюменский индустриальный университет (c) 2025\r\n" +
                "Высшая школа цифровых технологий (c) 2025\r\n\r\n" +
                "Внутреннее имя: Tyuiu.PlatonovMV.Sprint6.Task7.V17";
        }

        private void buttonOk_PMV_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelInfo_PMV_Click(object sender, EventArgs e)
        {

        }
    }
}