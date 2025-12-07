using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.PlatonovMV.Sprint6.Task6.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();

            this.Text = "Спринт 6 | Таск 6 | Вариант 10 | Платонов М.В.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxIn_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIn_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            buttonOpen_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDo_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            
            textBoxIn_PMV.Multiline = true;
            textBoxIn_PMV.ScrollBars = ScrollBars.Vertical;

            textBoxOut_PMV.ReadOnly = true;
            textBoxOut_PMV.ScrollBars = ScrollBars.Vertical;

            textBoxPath_PMV.ReadOnly = true;

            
            buttonDo_PMV.Enabled = false;

            
            toolTip_PMV.SetToolTip(buttonOpen_PMV, "Выбрать файл InPutFileTask6V10.txt");
            toolTip_PMV.SetToolTip(buttonDo_PMV, "Найти все слова, содержащие букву 'w'");
            toolTip_PMV.SetToolTip(buttonAbout_PMV, "Информация о программе");
        }

        
        private void buttonOpen_PMV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите файл InPutFileTask6V10.txt";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = ofd.FileName;
                    string text = File.ReadAllText(path);

                    textBoxPath_PMV.Text = path;
                    textBoxIn_PMV.Text = text;

                    buttonDo_PMV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла:\n" + ex.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void buttonDo_PMV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBoxPath_PMV.Text;

                if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                {
                    MessageBox.Show("Файл не найден. Снова выберите файл.");
                    buttonDo_PMV.Enabled = false;
                    return;
                }

                string res = ds.CollectTextFromFile(path);
                textBoxOut_PMV.Text = res;

                if (string.IsNullOrWhiteSpace(res))
                {
                    MessageBox.Show("Слов с буквой 'w' не найдено.",
                                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке файла:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void buttonAbout_PMV_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}