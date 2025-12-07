namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxTask_PMV;
        private System.Windows.Forms.Label labelTask_PMV;

        private System.Windows.Forms.GroupBox groupBoxIn_PMV;
        private System.Windows.Forms.Label labelPath_PMV;
        private System.Windows.Forms.TextBox textBoxPath_PMV;
        private System.Windows.Forms.TextBox textBoxIn_PMV;
        private System.Windows.Forms.TextBox textBoxOut_PMV;

        private System.Windows.Forms.Button buttonOpen_PMV;
        private System.Windows.Forms.Button buttonDo_PMV;
        private System.Windows.Forms.Button buttonAbout_PMV;

        private System.Windows.Forms.ToolTip toolTip_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_PMV = new GroupBox();
            labelTask_PMV = new Label();
            groupBoxIn_PMV = new GroupBox();
            textBoxIn_PMV = new TextBox();
            labelPath_PMV = new Label();
            textBoxPath_PMV = new TextBox();
            textBoxOut_PMV = new TextBox();
            buttonOpen_PMV = new Button();
            buttonDo_PMV = new Button();
            buttonAbout_PMV = new Button();
            toolTip_PMV = new ToolTip(components);
            groupBoxOut_PMV = new GroupBox();
            groupBoxTask_PMV.SuspendLayout();
            groupBoxIn_PMV.SuspendLayout();
            groupBoxOut_PMV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Location = new Point(12, 84);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(768, 79);
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
            labelTask_PMV.Size = new Size(448, 30);
            labelTask_PMV.TabIndex = 0;
            labelTask_PMV.Text = "Дан файл InPutFileTask6V10.txt. Загрузить файл в textBoxIn через OpenFileDialog.\r\nВывести слова, содержащие 'w', в результирующую строку textBoxOut.";
            // 
            // groupBoxIn_PMV
            // 
            groupBoxIn_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxIn_PMV.Controls.Add(textBoxIn_PMV);
            groupBoxIn_PMV.Controls.Add(labelPath_PMV);
            groupBoxIn_PMV.Controls.Add(textBoxPath_PMV);
            groupBoxIn_PMV.Location = new Point(12, 169);
            groupBoxIn_PMV.Name = "groupBoxIn_PMV";
            groupBoxIn_PMV.Size = new Size(403, 230);
            groupBoxIn_PMV.TabIndex = 1;
            groupBoxIn_PMV.TabStop = false;
            groupBoxIn_PMV.Text = "Ввод:";
            // 
            // textBoxIn_PMV
            // 
            textBoxIn_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIn_PMV.Location = new Point(6, 48);
            textBoxIn_PMV.Multiline = true;
            textBoxIn_PMV.Name = "textBoxIn_PMV";
            textBoxIn_PMV.ReadOnly = true;
            textBoxIn_PMV.Size = new Size(391, 176);
            textBoxIn_PMV.TabIndex = 1;
            // 
            // labelPath_PMV
            // 
            labelPath_PMV.AutoSize = true;
            labelPath_PMV.Location = new Point(6, 22);
            labelPath_PMV.Name = "labelPath_PMV";
            labelPath_PMV.Size = new Size(83, 15);
            labelPath_PMV.TabIndex = 2;
            labelPath_PMV.Text = "Путь к файлу:";
            // 
            // textBoxPath_PMV
            // 
            textBoxPath_PMV.Location = new Point(86, 19);
            textBoxPath_PMV.Name = "textBoxPath_PMV";
            textBoxPath_PMV.Size = new Size(311, 23);
            textBoxPath_PMV.TabIndex = 0;
            // 
            // textBoxOut_PMV
            // 
            textBoxOut_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_PMV.Location = new Point(6, 19);
            textBoxOut_PMV.Multiline = true;
            textBoxOut_PMV.Name = "textBoxOut_PMV";
            textBoxOut_PMV.Size = new Size(347, 205);
            textBoxOut_PMV.TabIndex = 2;
            // 
            // buttonOpen_PMV
            // 
            buttonOpen_PMV.Image = (Image)resources.GetObject("buttonOpen_PMV.Image");
            buttonOpen_PMV.Location = new Point(12, 12);
            buttonOpen_PMV.Name = "buttonOpen_PMV";
            buttonOpen_PMV.Size = new Size(80, 60);
            buttonOpen_PMV.TabIndex = 3;
            buttonOpen_PMV.UseVisualStyleBackColor = true;
            buttonOpen_PMV.Click += buttonOpen_PMV_Click;
            // 
            // buttonDo_PMV
            // 
            buttonDo_PMV.Image = (Image)resources.GetObject("buttonDo_PMV.Image");
            buttonDo_PMV.Location = new Point(98, 12);
            buttonDo_PMV.Name = "buttonDo_PMV";
            buttonDo_PMV.Size = new Size(80, 60);
            buttonDo_PMV.TabIndex = 4;
            buttonDo_PMV.UseVisualStyleBackColor = true;
            buttonDo_PMV.Click += buttonDo_PMV_Click;
            // 
            // buttonAbout_PMV
            // 
            buttonAbout_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAbout_PMV.Image = (Image)resources.GetObject("buttonAbout_PMV.Image");
            buttonAbout_PMV.Location = new Point(700, 12);
            buttonAbout_PMV.Name = "buttonAbout_PMV";
            buttonAbout_PMV.Size = new Size(80, 60);
            buttonAbout_PMV.TabIndex = 5;
            buttonAbout_PMV.UseVisualStyleBackColor = true;
            buttonAbout_PMV.Click += buttonAbout_PMV_Click;
            // 
            // toolTip_PMV
            // 
            toolTip_PMV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // groupBoxOut_PMV
            // 
            groupBoxOut_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOut_PMV.Controls.Add(textBoxOut_PMV);
            groupBoxOut_PMV.Location = new Point(421, 169);
            groupBoxOut_PMV.Name = "groupBoxOut_PMV";
            groupBoxOut_PMV.Size = new Size(359, 230);
            groupBoxOut_PMV.TabIndex = 7;
            groupBoxOut_PMV.TabStop = false;
            groupBoxOut_PMV.Text = "Вывод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 411);
            Controls.Add(groupBoxOut_PMV);
            Controls.Add(buttonAbout_PMV);
            Controls.Add(buttonDo_PMV);
            Controls.Add(buttonOpen_PMV);
            Controls.Add(groupBoxIn_PMV);
            Controls.Add(groupBoxTask_PMV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 10 | Платонов М.В.";
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            groupBoxIn_PMV.ResumeLayout(false);
            groupBoxIn_PMV.PerformLayout();
            groupBoxOut_PMV.ResumeLayout(false);
            groupBoxOut_PMV.PerformLayout();
            ResumeLayout(false);
        }
        private GroupBox groupBoxOut_PMV;
    }
}