namespace Tyuiu.PlatonovMV.Sprint6.Task2.V20
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
            groupBoxInputData_PMV = new GroupBox();
            labelTask2_PMV = new Label();
            labelTask_PMV = new Label();
            groupBoxOutputData_PMV = new GroupBox();
            chartFunction_PMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_PMV = new DataGridView();
            colX = new DataGridViewTextBoxColumn();
            colFx = new DataGridViewTextBoxColumn();
            labelResult_PMV = new Label();
            labelStartStep_PMV = new Label();
            textBoxStartStep_PMV = new TextBox();
            label1 = new Label();
            textBoxStopStep_PMV = new TextBox();
            buttonHelp_PMV = new Button();
            buttonDone_PMV = new Button();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxOutputData_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PMV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_PMV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Controls.Add(groupBoxInputData_PMV);
            groupBoxTask_PMV.Controls.Add(labelTask2_PMV);
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Location = new Point(12, 12);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(381, 327);
            groupBoxTask_PMV.TabIndex = 0;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // groupBoxInputData_PMV
            // 
            groupBoxInputData_PMV.Location = new Point(35, 185);
            groupBoxInputData_PMV.Name = "groupBoxInputData_PMV";
            groupBoxInputData_PMV.Size = new Size(245, 108);
            groupBoxInputData_PMV.TabIndex = 2;
            groupBoxInputData_PMV.TabStop = false;
            groupBoxInputData_PMV.Text = "Ввод данных";
            // 
            // labelTask2_PMV
            // 
            labelTask2_PMV.AutoSize = true;
            labelTask2_PMV.Location = new Point(12, 37);
            labelTask2_PMV.Name = "labelTask2_PMV";
            labelTask2_PMV.Size = new Size(359, 15);
            labelTask2_PMV.TabIndex = 1;
            labelTask2_PMV.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.AutoSize = true;
            labelTask_PMV.Location = new Point(12, 22);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(318, 15);
            labelTask_PMV.TabIndex = 0;
            labelTask_PMV.Text = "Протабулировать функцию F(x) на заданном диапазоне.";
            // 
            // groupBoxOutputData_PMV
            // 
            groupBoxOutputData_PMV.Controls.Add(chartFunction_PMV);
            groupBoxOutputData_PMV.Controls.Add(dataGridViewFunction_PMV);
            groupBoxOutputData_PMV.Controls.Add(labelResult_PMV);
            groupBoxOutputData_PMV.Location = new Point(421, 24);
            groupBoxOutputData_PMV.Name = "groupBoxOutputData_PMV";
            groupBoxOutputData_PMV.Size = new Size(367, 354);
            groupBoxOutputData_PMV.TabIndex = 1;
            groupBoxOutputData_PMV.TabStop = false;
            groupBoxOutputData_PMV.Text = "Вывод данных";
            // 
            // chartFunction_PMV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_PMV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_PMV.Legends.Add(legend1);
            chartFunction_PMV.Location = new Point(128, 28);
            chartFunction_PMV.Name = "chartFunction_PMV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_PMV.Series.Add(series1);
            chartFunction_PMV.Size = new Size(239, 300);
            chartFunction_PMV.TabIndex = 0;
            chartFunction_PMV.Text = "chart1";
            chartFunction_PMV.Click += chart1_Click;
            // 
            // dataGridViewFunction_PMV
            // 
            dataGridViewFunction_PMV.AllowUserToAddRows = false;
            dataGridViewFunction_PMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_PMV.Columns.AddRange(new DataGridViewColumn[] { colX, colFx });
            dataGridViewFunction_PMV.Location = new Point(6, 46);
            dataGridViewFunction_PMV.Name = "dataGridViewFunction_PMV";
            dataGridViewFunction_PMV.ReadOnly = true;
            dataGridViewFunction_PMV.RowHeadersVisible = false;
            dataGridViewFunction_PMV.Size = new Size(103, 150);
            dataGridViewFunction_PMV.TabIndex = 1;
            // 
            // colX
            // 
            colX.HeaderText = "X";
            colX.Name = "colX";
            colX.ReadOnly = true;
            colX.Width = 50;
            // 
            // colFx
            // 
            colFx.HeaderText = "F(x)";
            colFx.Name = "colFx";
            colFx.ReadOnly = true;
            colFx.Width = 50;
            // 
            // labelResult_PMV
            // 
            labelResult_PMV.AutoSize = true;
            labelResult_PMV.Location = new Point(17, 28);
            labelResult_PMV.Name = "labelResult_PMV";
            labelResult_PMV.Size = new Size(63, 15);
            labelResult_PMV.TabIndex = 0;
            labelResult_PMV.Text = "Результат:";
            // 
            // labelStartStep_PMV
            // 
            labelStartStep_PMV.AutoSize = true;
            labelStartStep_PMV.Location = new Point(144, 385);
            labelStartStep_PMV.Name = "labelStartStep_PMV";
            labelStartStep_PMV.Size = new Size(72, 15);
            labelStartStep_PMV.TabIndex = 2;
            labelStartStep_PMV.Text = "Старт шага:";
            // 
            // textBoxStartStep_PMV
            // 
            textBoxStartStep_PMV.Location = new Point(144, 403);
            textBoxStartStep_PMV.Name = "textBoxStartStep_PMV";
            textBoxStartStep_PMV.Size = new Size(100, 23);
            textBoxStartStep_PMV.TabIndex = 3;
            textBoxStartStep_PMV.TextAlign = HorizontalAlignment.Center;
            textBoxStartStep_PMV.KeyPress += textBoxStartStep_PMV_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 383);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Конец шага:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxStopStep_PMV
            // 
            textBoxStopStep_PMV.Location = new Point(466, 401);
            textBoxStopStep_PMV.Name = "textBoxStopStep_PMV";
            textBoxStopStep_PMV.Size = new Size(100, 23);
            textBoxStopStep_PMV.TabIndex = 5;
            textBoxStopStep_PMV.TextAlign = HorizontalAlignment.Center;
            textBoxStopStep_PMV.KeyPress += textBoxStopStep_PMV_KeyPress;
            // 
            // buttonHelp_PMV
            // 
            buttonHelp_PMV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_PMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMV.Location = new Point(617, 401);
            buttonHelp_PMV.Name = "buttonHelp_PMV";
            buttonHelp_PMV.Size = new Size(75, 23);
            buttonHelp_PMV.TabIndex = 6;
            buttonHelp_PMV.Text = "Справка";
            buttonHelp_PMV.UseVisualStyleBackColor = false;
            buttonHelp_PMV.Click += buttonHelp_PMV_Click;
            // 
            // buttonDone_PMV
            // 
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.Location = new Point(698, 401);
            buttonDone_PMV.Name = "buttonDone_PMV";
            buttonDone_PMV.Size = new Size(90, 23);
            buttonDone_PMV.TabIndex = 7;
            buttonDone_PMV.Text = "Выполнить";
            buttonDone_PMV.UseVisualStyleBackColor = true;
            buttonDone_PMV.Click += buttonDone_PMV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_PMV);
            Controls.Add(buttonHelp_PMV);
            Controls.Add(textBoxStopStep_PMV);
            Controls.Add(label1);
            Controls.Add(textBoxStartStep_PMV);
            Controls.Add(labelStartStep_PMV);
            Controls.Add(groupBoxOutputData_PMV);
            Controls.Add(groupBoxTask_PMV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 20 | Платонов М.В.";
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxOutputData_PMV.ResumeLayout(false);
            groupBoxOutputData_PMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PMV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_PMV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_PMV;
        private Label labelTask2_PMV;
        private Label labelTask_PMV;
        private GroupBox groupBoxOutputData_PMV;
        private Label labelResult_PMV;
        private DataGridView dataGridViewFunction_PMV;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colFx;
        private GroupBox groupBoxInputData_PMV;
        private Label labelStartStep_PMV;
        private TextBox textBoxStartStep_PMV;
        private Label label1;
        private TextBox textBoxStopStep_PMV;
        private Button buttonHelp_PMV;
        private Button buttonDone_PMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PMV;
    }
}
