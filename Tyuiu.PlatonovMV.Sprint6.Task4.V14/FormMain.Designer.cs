namespace Tyuiu.PlatonovMV.Sprint6.Task4.V14
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
            groupBoxInputData_PMV = new GroupBox();
            textBoxStop_PMV = new TextBox();
            labelStop_PMV = new Label();
            textBoxStart_PMV = new TextBox();
            labelStart_PMV = new Label();
            buttonDone_PMV = new Button();
            buttonSave_PMV = new Button();
            buttonHelp_PMV = new Button();
            labelOutput_PMV = new Label();
            textBoxResult_PMV = new TextBox();
            chartFunction_PMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxInputData_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PMV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Location = new Point(12, 0);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(401, 84);
            groupBoxTask_PMV.TabIndex = 0;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.AutoSize = true;
            labelTask_PMV.Location = new Point(6, 18);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(389, 45);
            labelTask_PMV.TabIndex = 0;
            labelTask_PMV.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести в TextBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V14.txt по нажатию кнопки.";
            // 
            // groupBoxInputData_PMV
            // 
            groupBoxInputData_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInputData_PMV.Controls.Add(textBoxStop_PMV);
            groupBoxInputData_PMV.Controls.Add(labelStop_PMV);
            groupBoxInputData_PMV.Controls.Add(textBoxStart_PMV);
            groupBoxInputData_PMV.Controls.Add(labelStart_PMV);
            groupBoxInputData_PMV.Location = new Point(419, 0);
            groupBoxInputData_PMV.Name = "groupBoxInputData_PMV";
            groupBoxInputData_PMV.Size = new Size(178, 84);
            groupBoxInputData_PMV.TabIndex = 1;
            groupBoxInputData_PMV.TabStop = false;
            groupBoxInputData_PMV.Text = "Ввод данных";
            groupBoxInputData_PMV.Enter += groupBox1_Enter;
            // 
            // textBoxStop_PMV
            // 
            textBoxStop_PMV.Location = new Point(84, 39);
            textBoxStop_PMV.Name = "textBoxStop_PMV";
            textBoxStop_PMV.Size = new Size(75, 23);
            textBoxStop_PMV.TabIndex = 3;
            textBoxStop_PMV.Text = "5";
            textBoxStop_PMV.KeyPress += textBoxStop_PMV_KeyPress;
            // 
            // labelStop_PMV
            // 
            labelStop_PMV.AutoSize = true;
            labelStop_PMV.Location = new Point(84, 18);
            labelStop_PMV.Name = "labelStop_PMV";
            labelStop_PMV.Size = new Size(75, 15);
            labelStop_PMV.TabIndex = 2;
            labelStop_PMV.Text = "Конец шага:";
            // 
            // textBoxStart_PMV
            // 
            textBoxStart_PMV.Location = new Point(0, 39);
            textBoxStart_PMV.Name = "textBoxStart_PMV";
            textBoxStart_PMV.Size = new Size(72, 23);
            textBoxStart_PMV.TabIndex = 1;
            textBoxStart_PMV.Text = "-5";
            textBoxStart_PMV.KeyPress += textBoxStart_PMV_KeyPress;
            // 
            // labelStart_PMV
            // 
            labelStart_PMV.AutoSize = true;
            labelStart_PMV.Location = new Point(0, 18);
            labelStart_PMV.Name = "labelStart_PMV";
            labelStart_PMV.Size = new Size(72, 15);
            labelStart_PMV.TabIndex = 0;
            labelStart_PMV.Text = "Старт шага:";
            // 
            // buttonDone_PMV
            // 
            buttonDone_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_PMV.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.Location = new Point(603, 10);
            buttonDone_PMV.Name = "buttonDone_PMV";
            buttonDone_PMV.Size = new Size(84, 30);
            buttonDone_PMV.TabIndex = 2;
            buttonDone_PMV.Text = "Выполнить";
            buttonDone_PMV.UseVisualStyleBackColor = false;
            buttonDone_PMV.Click += buttonDone_PMV_Click;
            // 
            // buttonSave_PMV
            // 
            buttonSave_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_PMV.BackColor = Color.FromArgb(192, 255, 255);
            buttonSave_PMV.FlatStyle = FlatStyle.Flat;
            buttonSave_PMV.Location = new Point(603, 46);
            buttonSave_PMV.Name = "buttonSave_PMV";
            buttonSave_PMV.Size = new Size(84, 30);
            buttonSave_PMV.TabIndex = 3;
            buttonSave_PMV.Text = "Сохранить";
            buttonSave_PMV.UseVisualStyleBackColor = false;
            buttonSave_PMV.Click += buttonSave_PMV_Click;
            // 
            // buttonHelp_PMV
            // 
            buttonHelp_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMV.Location = new Point(693, 10);
            buttonHelp_PMV.Name = "buttonHelp_PMV";
            buttonHelp_PMV.Size = new Size(84, 30);
            buttonHelp_PMV.TabIndex = 4;
            buttonHelp_PMV.Text = "Справка";
            buttonHelp_PMV.UseVisualStyleBackColor = true;
            buttonHelp_PMV.Click += buttonHelp_PMV_Click;
            // 
            // labelOutput_PMV
            // 
            labelOutput_PMV.AutoSize = true;
            labelOutput_PMV.Location = new Point(12, 87);
            labelOutput_PMV.Name = "labelOutput_PMV";
            labelOutput_PMV.Size = new Size(45, 15);
            labelOutput_PMV.TabIndex = 5;
            labelOutput_PMV.Text = "Вывод:";
            // 
            // textBoxResult_PMV
            // 
            textBoxResult_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxResult_PMV.Location = new Point(12, 105);
            textBoxResult_PMV.Multiline = true;
            textBoxResult_PMV.Name = "textBoxResult_PMV";
            textBoxResult_PMV.ReadOnly = true;
            textBoxResult_PMV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PMV.Size = new Size(158, 341);
            textBoxResult_PMV.TabIndex = 6;
            // 
            // chartFunction_PMV
            // 
            chartFunction_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunction_PMV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_PMV.Legends.Add(legend1);
            chartFunction_PMV.Location = new Point(176, 105);
            chartFunction_PMV.Name = "chartFunction_PMV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_PMV.Series.Add(series1);
            chartFunction_PMV.Size = new Size(612, 341);
            chartFunction_PMV.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartFunction_PMV);
            Controls.Add(textBoxResult_PMV);
            Controls.Add(labelOutput_PMV);
            Controls.Add(buttonHelp_PMV);
            Controls.Add(buttonSave_PMV);
            Controls.Add(buttonDone_PMV);
            Controls.Add(groupBoxInputData_PMV);
            Controls.Add(groupBoxTask_PMV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 14 | Платонов М.В.";
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxInputData_PMV.ResumeLayout(false);
            groupBoxInputData_PMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PMV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_PMV;
        private Label labelTask_PMV;
        private GroupBox groupBoxInputData_PMV;
        private Label labelStart_PMV;
        private TextBox textBoxStop_PMV;
        private Label labelStop_PMV;
        private TextBox textBoxStart_PMV;
        private Button buttonDone_PMV;
        private Button buttonSave_PMV;
        private Button buttonHelp_PMV;
        private Label labelOutput_PMV;
        private TextBox textBoxResult_PMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PMV;
    }
}
