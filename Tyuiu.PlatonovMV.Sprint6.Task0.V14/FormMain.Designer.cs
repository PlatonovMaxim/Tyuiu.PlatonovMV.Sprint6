namespace Tyuiu.PlatonovMV.Sprint6.Task0.V14
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
            labelVarX_PMV = new Label();
            textBoxVarX_PMV = new TextBox();
            labelResult_PMV = new Label();
            textBoxResult_PMV = new TextBox();
            buttonDone_PMV = new Button();
            buttonHelp_PMV = new Button();
            pictureBoxFormula_PMV = new PictureBox();
            groupBoxTask_PMV = new GroupBox();
            labelTask_PMV = new Label();
            groupBoxInputData_PMV = new GroupBox();
            groupBoxOutputData_PMV = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PMV).BeginInit();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxInputData_PMV.SuspendLayout();
            groupBoxOutputData_PMV.SuspendLayout();
            SuspendLayout();
            // 
            // labelVarX_PMV
            // 
            labelVarX_PMV.AutoSize = true;
            labelVarX_PMV.Location = new Point(6, 26);
            labelVarX_PMV.Name = "labelVarX_PMV";
            labelVarX_PMV.Size = new Size(88, 15);
            labelVarX_PMV.TabIndex = 0;
            labelVarX_PMV.Text = "Переменная x:";
            labelVarX_PMV.Click += labelVarX_PMV_Click;
            // 
            // textBoxVarX_PMV
            // 
            textBoxVarX_PMV.Location = new Point(6, 44);
            textBoxVarX_PMV.Name = "textBoxVarX_PMV";
            textBoxVarX_PMV.Size = new Size(88, 23);
            textBoxVarX_PMV.TabIndex = 1;
            textBoxVarX_PMV.TextAlign = HorizontalAlignment.Center;
            textBoxVarX_PMV.TextChanged += textBoxVarX_PMV_TextChanged;
            textBoxVarX_PMV.KeyPress += textBoxVarX_PMV_KeyPress;
            // 
            // labelResult_PMV
            // 
            labelResult_PMV.AutoSize = true;
            labelResult_PMV.Location = new Point(6, 26);
            labelResult_PMV.Name = "labelResult_PMV";
            labelResult_PMV.Size = new Size(63, 15);
            labelResult_PMV.TabIndex = 2;
            labelResult_PMV.Text = "Результат:";
            // 
            // textBoxResult_PMV
            // 
            textBoxResult_PMV.Location = new Point(6, 44);
            textBoxResult_PMV.Name = "textBoxResult_PMV";
            textBoxResult_PMV.ReadOnly = true;
            textBoxResult_PMV.Size = new Size(199, 23);
            textBoxResult_PMV.TabIndex = 3;
            textBoxResult_PMV.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonDone_PMV
            // 
            buttonDone_PMV.BackColor = SystemColors.Control;
            buttonDone_PMV.FlatStyle = FlatStyle.Flat;
            buttonDone_PMV.Location = new Point(641, 381);
            buttonDone_PMV.Name = "buttonDone_PMV";
            buttonDone_PMV.Size = new Size(147, 56);
            buttonDone_PMV.TabIndex = 4;
            buttonDone_PMV.Text = "Выполнить";
            buttonDone_PMV.UseVisualStyleBackColor = false;
            buttonDone_PMV.Click += buttonDone_PMV_Click;
            // 
            // buttonHelp_PMV
            // 
            buttonHelp_PMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMV.Location = new Point(577, 381);
            buttonHelp_PMV.Name = "buttonHelp_PMV";
            buttonHelp_PMV.Size = new Size(58, 56);
            buttonHelp_PMV.TabIndex = 5;
            buttonHelp_PMV.Text = "?";
            buttonHelp_PMV.UseVisualStyleBackColor = true;
            buttonHelp_PMV.Click += buttonHelp_PMV_Click;
            // 
            // pictureBoxFormula_PMV
            // 
            pictureBoxFormula_PMV.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_PMV.ErrorImage = (Image)resources.GetObject("pictureBoxFormula_PMV.ErrorImage");
            pictureBoxFormula_PMV.Image = (Image)resources.GetObject("pictureBoxFormula_PMV.Image");
            pictureBoxFormula_PMV.Location = new Point(629, 22);
            pictureBoxFormula_PMV.Name = "pictureBoxFormula_PMV";
            pictureBoxFormula_PMV.Size = new Size(141, 94);
            pictureBoxFormula_PMV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_PMV.TabIndex = 6;
            pictureBoxFormula_PMV.TabStop = false;
            pictureBoxFormula_PMV.Click += pictureBoxFormula_PMV_Click;
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Controls.Add(pictureBoxFormula_PMV);
            groupBoxTask_PMV.Location = new Point(12, 12);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(776, 280);
            groupBoxTask_PMV.TabIndex = 7;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.AutoSize = true;
            labelTask_PMV.BackColor = SystemColors.Control;
            labelTask_PMV.Location = new Point(6, 22);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(205, 15);
            labelTask_PMV.TabIndex = 7;
            labelTask_PMV.Text = "Вычислить выражение по формуле";
            labelTask_PMV.Click += labelTask_PMV_Click;
            // 
            // groupBoxInputData_PMV
            // 
            groupBoxInputData_PMV.Controls.Add(labelVarX_PMV);
            groupBoxInputData_PMV.Controls.Add(textBoxVarX_PMV);
            groupBoxInputData_PMV.Location = new Point(12, 298);
            groupBoxInputData_PMV.Name = "groupBoxInputData_PMV";
            groupBoxInputData_PMV.Size = new Size(546, 139);
            groupBoxInputData_PMV.TabIndex = 8;
            groupBoxInputData_PMV.TabStop = false;
            groupBoxInputData_PMV.Text = "Ввод данных";
            // 
            // groupBoxOutputData_PMV
            // 
            groupBoxOutputData_PMV.Controls.Add(labelResult_PMV);
            groupBoxOutputData_PMV.Controls.Add(textBoxResult_PMV);
            groupBoxOutputData_PMV.Location = new Point(577, 298);
            groupBoxOutputData_PMV.Name = "groupBoxOutputData_PMV";
            groupBoxOutputData_PMV.Size = new Size(211, 77);
            groupBoxOutputData_PMV.TabIndex = 8;
            groupBoxOutputData_PMV.TabStop = false;
            groupBoxOutputData_PMV.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutputData_PMV);
            Controls.Add(groupBoxInputData_PMV);
            Controls.Add(groupBoxTask_PMV);
            Controls.Add(buttonHelp_PMV);
            Controls.Add(buttonDone_PMV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 14 | Платонов М.В.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PMV).EndInit();
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxInputData_PMV.ResumeLayout(false);
            groupBoxInputData_PMV.PerformLayout();
            groupBoxOutputData_PMV.ResumeLayout(false);
            groupBoxOutputData_PMV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelVarX_PMV;
        private TextBox textBoxVarX_PMV;
        private Label labelResult_PMV;
        private TextBox textBoxResult_PMV;
        private Button buttonDone_PMV;
        private Button buttonHelp_PMV;
        private PictureBox pictureBoxFormula_PMV;
        private GroupBox groupBoxTask_PMV;
        private Label labelTask_PMV;
        private GroupBox groupBoxInputData_PMV;
        private GroupBox groupBoxOutputData_PMV;
    }
}
