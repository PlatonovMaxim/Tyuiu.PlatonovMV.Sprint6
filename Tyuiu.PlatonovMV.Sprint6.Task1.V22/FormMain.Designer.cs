namespace Tyuiu.PlatonovMV.Sprint6.Task1.V22
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
            groupBoxTask_PMV = new GroupBox();
            labelTask_PMV = new Label();
            labelTask2_PMV = new Label();
            groupBoxOutputData_PMV = new GroupBox();
            labelResult_PMV = new Label();
            textBoxResult_PMV = new TextBox();
            groupBoxInputData_PMV = new GroupBox();
            textBoxStartStep_PMV = new TextBox();
            labelStartStep_PMV = new Label();
            labelStopStep_PMV = new Label();
            textBoxStopStep_PMV = new TextBox();
            buttonHelp_PMV = new Button();
            buttonDone_PMV = new Button();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxOutputData_PMV.SuspendLayout();
            groupBoxInputData_PMV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Controls.Add(labelTask2_PMV);
            groupBoxTask_PMV.Location = new Point(12, 12);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(498, 323);
            groupBoxTask_PMV.TabIndex = 0;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.AutoSize = true;
            labelTask_PMV.Location = new Point(6, 19);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(318, 15);
            labelTask_PMV.TabIndex = 1;
            labelTask_PMV.Text = "Протабулировать функцию F(x) на заданном диапазоне.";
            // 
            // labelTask2_PMV
            // 
            labelTask2_PMV.AutoSize = true;
            labelTask2_PMV.Location = new Point(6, 34);
            labelTask2_PMV.Name = "labelTask2_PMV";
            labelTask2_PMV.Size = new Size(199, 15);
            labelTask2_PMV.TabIndex = 2;
            labelTask2_PMV.Text = "Результат вывести в виде таблицы.";
            // 
            // groupBoxOutputData_PMV
            // 
            groupBoxOutputData_PMV.Controls.Add(labelResult_PMV);
            groupBoxOutputData_PMV.Controls.Add(textBoxResult_PMV);
            groupBoxOutputData_PMV.Location = new Point(516, 12);
            groupBoxOutputData_PMV.Name = "groupBoxOutputData_PMV";
            groupBoxOutputData_PMV.Size = new Size(272, 323);
            groupBoxOutputData_PMV.TabIndex = 3;
            groupBoxOutputData_PMV.TabStop = false;
            groupBoxOutputData_PMV.Text = "Вывод данных";
            // 
            // labelResult_PMV
            // 
            labelResult_PMV.AutoSize = true;
            labelResult_PMV.Location = new Point(6, 19);
            labelResult_PMV.Name = "labelResult_PMV";
            labelResult_PMV.Size = new Size(63, 15);
            labelResult_PMV.TabIndex = 4;
            labelResult_PMV.Text = "Результат:";
            // 
            // textBoxResult_PMV
            // 
            textBoxResult_PMV.Font = new Font("Consolas", 10F);
            textBoxResult_PMV.Location = new Point(6, 37);
            textBoxResult_PMV.Multiline = true;
            textBoxResult_PMV.Name = "textBoxResult_PMV";
            textBoxResult_PMV.ReadOnly = true;
            textBoxResult_PMV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PMV.Size = new Size(260, 280);
            textBoxResult_PMV.TabIndex = 5;
            // 
            // groupBoxInputData_PMV
            // 
            groupBoxInputData_PMV.Controls.Add(textBoxStartStep_PMV);
            groupBoxInputData_PMV.Controls.Add(labelStartStep_PMV);
            groupBoxInputData_PMV.Controls.Add(labelStopStep_PMV);
            groupBoxInputData_PMV.Controls.Add(textBoxStopStep_PMV);
            groupBoxInputData_PMV.Location = new Point(12, 341);
            groupBoxInputData_PMV.Name = "groupBoxInputData_PMV";
            groupBoxInputData_PMV.Size = new Size(498, 100);
            groupBoxInputData_PMV.TabIndex = 4;
            groupBoxInputData_PMV.TabStop = false;
            groupBoxInputData_PMV.Text = "Ввод данных";
            // 
            // textBoxStartStep_PMV
            // 
            textBoxStartStep_PMV.Location = new Point(6, 37);
            textBoxStartStep_PMV.Name = "textBoxStartStep_PMV";
            textBoxStartStep_PMV.Size = new Size(72, 23);
            textBoxStartStep_PMV.TabIndex = 6;
            textBoxStartStep_PMV.TextAlign = HorizontalAlignment.Center;
            textBoxStartStep_PMV.KeyPress += textBoxStartStep_PMV_KeyPress;
            // 
            // labelStartStep_PMV
            // 
            labelStartStep_PMV.AutoSize = true;
            labelStartStep_PMV.Location = new Point(6, 19);
            labelStartStep_PMV.Name = "labelStartStep_PMV";
            labelStartStep_PMV.Size = new Size(72, 15);
            labelStartStep_PMV.TabIndex = 5;
            labelStartStep_PMV.Text = "Старт шага:";
            labelStartStep_PMV.Click += labelStartStep_PMV_Click;
            // 
            // labelStopStep_PMV
            // 
            labelStopStep_PMV.AutoSize = true;
            labelStopStep_PMV.Location = new Point(130, 19);
            labelStopStep_PMV.Name = "labelStopStep_PMV";
            labelStopStep_PMV.Size = new Size(75, 15);
            labelStopStep_PMV.TabIndex = 5;
            labelStopStep_PMV.Text = "Конец шага:";
            labelStopStep_PMV.Click += labelStopStep_PMV_Click;
            // 
            // textBoxStopStep_PMV
            // 
            textBoxStopStep_PMV.Location = new Point(130, 37);
            textBoxStopStep_PMV.Name = "textBoxStopStep_PMV";
            textBoxStopStep_PMV.Size = new Size(75, 23);
            textBoxStopStep_PMV.TabIndex = 6;
            textBoxStopStep_PMV.TextAlign = HorizontalAlignment.Center;
            textBoxStopStep_PMV.KeyPress += textBoxStopStep_PMV_KeyPress;
            // 
            // buttonHelp_PMV
            // 
            buttonHelp_PMV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_PMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMV.Location = new Point(516, 357);
            buttonHelp_PMV.Name = "buttonHelp_PMV";
            buttonHelp_PMV.Size = new Size(99, 84);
            buttonHelp_PMV.TabIndex = 7;
            buttonHelp_PMV.Text = "Справка";
            buttonHelp_PMV.UseVisualStyleBackColor = false;
            buttonHelp_PMV.Click += buttonHelp_PMV_Click;
            // 
            // buttonDone_PMV
            // 
            buttonDone_PMV.BackColor = Color.YellowGreen;
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.Location = new Point(621, 357);
            buttonDone_PMV.Name = "buttonDone_PMV";
            buttonDone_PMV.Size = new Size(167, 84);
            buttonDone_PMV.TabIndex = 8;
            buttonDone_PMV.Text = "Выполнить";
            buttonDone_PMV.UseVisualStyleBackColor = false;
            buttonDone_PMV.Click += buttonDone_PMV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_PMV);
            Controls.Add(buttonHelp_PMV);
            Controls.Add(groupBoxInputData_PMV);
            Controls.Add(groupBoxOutputData_PMV);
            Controls.Add(groupBoxTask_PMV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 22 | Платонов М.В.";
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxOutputData_PMV.ResumeLayout(false);
            groupBoxOutputData_PMV.PerformLayout();
            groupBoxInputData_PMV.ResumeLayout(false);
            groupBoxInputData_PMV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PMV;
        private Label labelTask_PMV;
        private Label labelTask2_PMV;
        private GroupBox groupBoxOutputData_PMV;
        private Label labelResult_PMV;
        private TextBox textBoxResult_PMV;
        private GroupBox groupBoxInputData_PMV;
        private TextBox textBoxStartStep_PMV;
        private Label labelStartStep_PMV;
        private Label labelStopStep_PMV;
        private TextBox textBoxStopStep_PMV;
        private Button buttonHelp_PMV;
        private Button buttonDone_PMV;
    }
}
