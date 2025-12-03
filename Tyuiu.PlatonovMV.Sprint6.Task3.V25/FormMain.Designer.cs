namespace Tyuiu.PlatonovMV.Sprint6.Task3.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_PMV = new GroupBox();
            textboxTask_PMV = new TextBox();
            groupBoxOutputData_PMV = new GroupBox();
            textBoxResult_PMV = new TextBox();
            labelResult_PMV = new Label();
            dataGridViewMatrix_PMV = new DataGridView();
            buttonDone_PMV = new Button();
            buttonHelp_PMV = new Button();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxOutputData_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_PMV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Controls.Add(textboxTask_PMV);
            groupBoxTask_PMV.Location = new Point(12, 12);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(308, 426);
            groupBoxTask_PMV.TabIndex = 0;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // textboxTask_PMV
            // 
            textboxTask_PMV.BorderStyle = BorderStyle.None;
            textboxTask_PMV.Location = new Point(6, 21);
            textboxTask_PMV.Multiline = true;
            textboxTask_PMV.Name = "textboxTask_PMV";
            textboxTask_PMV.ReadOnly = true;
            textboxTask_PMV.Size = new Size(296, 399);
            textboxTask_PMV.TabIndex = 0;
            textboxTask_PMV.Text = resources.GetString("textboxTask_PMV.Text");
            // 
            // groupBoxOutputData_PMV
            // 
            groupBoxOutputData_PMV.Controls.Add(textBoxResult_PMV);
            groupBoxOutputData_PMV.Controls.Add(labelResult_PMV);
            groupBoxOutputData_PMV.Location = new Point(588, 12);
            groupBoxOutputData_PMV.Name = "groupBoxOutputData_PMV";
            groupBoxOutputData_PMV.Size = new Size(200, 181);
            groupBoxOutputData_PMV.TabIndex = 1;
            groupBoxOutputData_PMV.TabStop = false;
            groupBoxOutputData_PMV.Text = "Вывод данных";
            // 
            // textBoxResult_PMV
            // 
            textBoxResult_PMV.Location = new Point(6, 37);
            textBoxResult_PMV.Multiline = true;
            textBoxResult_PMV.Name = "textBoxResult_PMV";
            textBoxResult_PMV.ReadOnly = true;
            textBoxResult_PMV.ScrollBars = ScrollBars.Horizontal;
            textBoxResult_PMV.Size = new Size(185, 138);
            textBoxResult_PMV.TabIndex = 1;
            // 
            // labelResult_PMV
            // 
            labelResult_PMV.AutoSize = true;
            labelResult_PMV.Location = new Point(6, 19);
            labelResult_PMV.Name = "labelResult_PMV";
            labelResult_PMV.Size = new Size(63, 15);
            labelResult_PMV.TabIndex = 0;
            labelResult_PMV.Text = "Результат:";
            // 
            // dataGridViewMatrix_PMV
            // 
            dataGridViewMatrix_PMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_PMV.Location = new Point(326, 12);
            dataGridViewMatrix_PMV.Name = "dataGridViewMatrix_PMV";
            dataGridViewMatrix_PMV.ReadOnly = true;
            dataGridViewMatrix_PMV.RowHeadersVisible = false;
            dataGridViewMatrix_PMV.Size = new Size(256, 426);
            dataGridViewMatrix_PMV.TabIndex = 2;
            dataGridViewMatrix_PMV.CellContentClick += dataGridViewMatrix_PMV_CellContentClick;
            // 
            // buttonDone_PMV
            // 
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.Location = new Point(670, 394);
            buttonDone_PMV.Name = "buttonDone_PMV";
            buttonDone_PMV.Size = new Size(118, 44);
            buttonDone_PMV.TabIndex = 3;
            buttonDone_PMV.Text = "Выполнить";
            buttonDone_PMV.UseVisualStyleBackColor = true;
            buttonDone_PMV.Click += buttonDone_PMV_Click;
            // 
            // buttonHelp_PMV
            // 
            buttonHelp_PMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMV.Location = new Point(621, 394);
            buttonHelp_PMV.Name = "buttonHelp_PMV";
            buttonHelp_PMV.Size = new Size(43, 44);
            buttonHelp_PMV.TabIndex = 4;
            buttonHelp_PMV.Text = "?";
            buttonHelp_PMV.UseVisualStyleBackColor = true;
            buttonHelp_PMV.Click += buttonHelp_PMV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_PMV);
            Controls.Add(buttonDone_PMV);
            Controls.Add(dataGridViewMatrix_PMV);
            Controls.Add(groupBoxOutputData_PMV);
            Controls.Add(groupBoxTask_PMV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 25 | Платонов М.В.";
            Load += FormMain_Load;
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxOutputData_PMV.ResumeLayout(false);
            groupBoxOutputData_PMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_PMV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PMV;
        private TextBox textboxTask_PMV;
        private GroupBox groupBoxOutputData_PMV;
        private TextBox textBoxResult_PMV;
        private Label labelResult_PMV;
        private DataGridView dataGridViewMatrix_PMV;
        private Button buttonDone_PMV;
        private Button buttonHelp_PMV;
    }
}
