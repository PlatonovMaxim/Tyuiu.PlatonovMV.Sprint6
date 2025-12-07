using System.Windows.Forms;

namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            this.Text = "О программе";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            labelInfo_PMV.Text =
                "Спринт 6, таск 6, вариант 10.\n" +
                "Чтение файла InPutFileTask6V10.txt,\n" +
                "отбор слов, содержащих букву 'w'.\n\n" +
                "Выполнил студент группы ИСТНб-25-1\n" +
                "Платонов Максим Владимирович.";
        }
    }
}