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
            groupBoxTask_PMV = new GroupBox();
            labelTask_PMV = new Label();
            groupBoxInputData_PMV = new GroupBox();
            groupBoxTask_PMV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Location = new Point(12, 12);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(401, 84);
            groupBoxTask_PMV.TabIndex = 0;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.AutoSize = true;
            labelTask_PMV.Location = new Point(6, 19);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(389, 45);
            labelTask_PMV.TabIndex = 0;
            labelTask_PMV.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести в TextBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V14.txt по нажатию кнопки.";
            // 
            // groupBoxInputData_PMV
            // 
            groupBoxInputData_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInputData_PMV.Location = new Point(419, 12);
            groupBoxInputData_PMV.Name = "groupBoxInputData_PMV";
            groupBoxInputData_PMV.Size = new Size(133, 84);
            groupBoxInputData_PMV.TabIndex = 1;
            groupBoxInputData_PMV.TabStop = false;
            groupBoxInputData_PMV.Text = "Ввод данных";
            groupBoxInputData_PMV.Enter += groupBox1_Enter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInputData_PMV);
            Controls.Add(groupBoxTask_PMV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 14 | Платонов М.В.";
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PMV;
        private Label labelTask_PMV;
        private GroupBox groupBoxInputData_PMV;
    }
}
