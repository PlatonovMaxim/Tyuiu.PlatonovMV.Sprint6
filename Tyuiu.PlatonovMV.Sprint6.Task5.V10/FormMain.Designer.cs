
namespace Tyuiu.PlatonovMV.Sprint6.Task5.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_PMV = new GroupBox();
            labelTask_PMV = new Label();
            groupBoxOutput_PMV = new GroupBox();
            dataGridViewNums_PMV = new DataGridView();
            chartDiag_PMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_PMV = new Button();
            buttonHelp_PMV = new Button();
            buttonOpenFile_PMV = new Button();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxOutput_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_PMV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_PMV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Location = new Point(13, 15);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(430, 94);
            groupBoxTask_PMV.TabIndex = 0;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTask_PMV.AutoSize = true;
            labelTask_PMV.Location = new Point(6, 19);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(414, 45);
            labelTask_PMV.TabIndex = 0;
            labelTask_PMV.Text = "Прочитать данные из файла InPutFileTask5V10.txt. Вывести в DataGridView.\r\nДан список из чисел. Вывести все числа, не равные 0.\r\nПостроить диаграмму по этим значениям. Округлить до трёх знаков.";
            // 
            // groupBoxOutput_PMV
            // 
            groupBoxOutput_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxOutput_PMV.Controls.Add(dataGridViewNums_PMV);
            groupBoxOutput_PMV.Location = new Point(13, 115);
            groupBoxOutput_PMV.Name = "groupBoxOutput_PMV";
            groupBoxOutput_PMV.Size = new Size(194, 323);
            groupBoxOutput_PMV.TabIndex = 1;
            groupBoxOutput_PMV.TabStop = false;
            groupBoxOutput_PMV.Text = "Вывод данных:";
            // 
            // dataGridViewNums_PMV
            // 
            dataGridViewNums_PMV.AllowUserToAddRows = false;
            dataGridViewNums_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewNums_PMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_PMV.Location = new Point(5, 22);
            dataGridViewNums_PMV.Name = "dataGridViewNums_PMV";
            dataGridViewNums_PMV.ReadOnly = true;
            dataGridViewNums_PMV.RowHeadersVisible = false;
            dataGridViewNums_PMV.Size = new Size(183, 295);
            dataGridViewNums_PMV.TabIndex = 0;
            // 
            // chartDiag_PMV
            // 
            chartDiag_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartDiag_PMV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_PMV.Legends.Add(legend1);
            chartDiag_PMV.Location = new Point(213, 115);
            chartDiag_PMV.Name = "chartDiag_PMV";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_PMV.Series.Add(series1);
            chartDiag_PMV.Size = new Size(378, 323);
            chartDiag_PMV.TabIndex = 2;
            // 
            // buttonDone_PMV
            // 
            buttonDone_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_PMV.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.Location = new Point(449, 24);
            buttonDone_PMV.Name = "buttonDone_PMV";
            buttonDone_PMV.Size = new Size(115, 76);
            buttonDone_PMV.TabIndex = 3;
            buttonDone_PMV.Text = "Выполнить";
            buttonDone_PMV.UseVisualStyleBackColor = false;
            buttonDone_PMV.Click += buttonDone_PMV_Click;
            // 
            // buttonHelp_PMV
            // 
            buttonHelp_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMV.Location = new Point(686, 24);
            buttonHelp_PMV.Name = "buttonHelp_PMV";
            buttonHelp_PMV.Size = new Size(104, 76);
            buttonHelp_PMV.TabIndex = 4;
            buttonHelp_PMV.Text = "Справка";
            buttonHelp_PMV.UseVisualStyleBackColor = true;
            buttonHelp_PMV.Click += buttonHelp_PMV_Click;
            // 
            // buttonOpenFile_PMV
            // 
            buttonOpenFile_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_PMV.BackColor = SystemColors.ActiveCaption;
            buttonOpenFile_PMV.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_PMV.Location = new Point(570, 24);
            buttonOpenFile_PMV.Name = "buttonOpenFile_PMV";
            buttonOpenFile_PMV.Size = new Size(110, 76);
            buttonOpenFile_PMV.TabIndex = 5;
            buttonOpenFile_PMV.Text = "Открыть файл";
            buttonOpenFile_PMV.UseVisualStyleBackColor = false;
            buttonOpenFile_PMV.Click += buttonOpenFile_PMV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(buttonOpenFile_PMV);
            Controls.Add(buttonHelp_PMV);
            Controls.Add(buttonDone_PMV);
            Controls.Add(chartDiag_PMV);
            Controls.Add(groupBoxOutput_PMV);
            Controls.Add(groupBoxTask_PMV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 10 | Платонов М.В.";
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxOutput_PMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_PMV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_PMV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PMV;
        private Label labelTask_PMV;
        private GroupBox groupBoxOutput_PMV;
        private DataGridView dataGridViewNums_PMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PMV;
        private Button buttonDone_PMV;
        private Button buttonHelp_PMV;
        private Button buttonOpenFile_PMV;
    }
}
