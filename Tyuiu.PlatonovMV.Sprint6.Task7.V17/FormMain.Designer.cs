namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop_PMV;
        private System.Windows.Forms.Button buttonOpen_PMV;
        private System.Windows.Forms.Button buttonRun_PMV;
        private System.Windows.Forms.Button buttonSave_PMV;
        private System.Windows.Forms.Button buttonAbout_PMV;

        private System.Windows.Forms.GroupBox groupBoxTask_PMV;
        private System.Windows.Forms.Label labelTask_PMV;
        private System.Windows.Forms.TextBox textBoxPath_PMV;

        private System.Windows.Forms.SplitContainer splitContainer_PMV;
        private System.Windows.Forms.GroupBox groupBoxIn_PMV;
        private System.Windows.Forms.GroupBox groupBoxOut_PMV;
        private System.Windows.Forms.DataGridView dataGridViewIn_PMV;
        private System.Windows.Forms.DataGridView dataGridViewOut_PMV;

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PMV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_PMV;
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
            panelTop_PMV = new Panel();
            buttonOpen_PMV = new Button();
            buttonRun_PMV = new Button();
            buttonSave_PMV = new Button();
            buttonAbout_PMV = new Button();
            groupBoxTask_PMV = new GroupBox();
            labelTask_PMV = new Label();
            textBoxPath_PMV = new TextBox();
            splitContainer_PMV = new SplitContainer();
            groupBoxIn_PMV = new GroupBox();
            dataGridViewIn_PMV = new DataGridView();
            groupBoxOut_PMV = new GroupBox();
            dataGridViewOut_PMV = new DataGridView();
            openFileDialogTask_PMV = new OpenFileDialog();
            saveFileDialogTask_PMV = new SaveFileDialog();
            toolTip_PMV = new ToolTip(components);
            panelTop_PMV.SuspendLayout();
            groupBoxTask_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_PMV).BeginInit();
            splitContainer_PMV.Panel1.SuspendLayout();
            splitContainer_PMV.Panel2.SuspendLayout();
            splitContainer_PMV.SuspendLayout();
            groupBoxIn_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PMV).BeginInit();
            groupBoxOut_PMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PMV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_PMV
            // 
            panelTop_PMV.Controls.Add(buttonOpen_PMV);
            panelTop_PMV.Controls.Add(buttonRun_PMV);
            panelTop_PMV.Controls.Add(buttonSave_PMV);
            panelTop_PMV.Controls.Add(buttonAbout_PMV);
            panelTop_PMV.Dock = DockStyle.Top;
            panelTop_PMV.Location = new Point(0, 0);
            panelTop_PMV.Name = "panelTop_PMV";
            panelTop_PMV.Size = new Size(1100, 60);
            panelTop_PMV.TabIndex = 0;
            // 
            // buttonOpen_PMV
            // 
            buttonOpen_PMV.Image = (Image)resources.GetObject("buttonOpen_PMV.Image");
            buttonOpen_PMV.Location = new Point(10, 6);
            buttonOpen_PMV.Name = "buttonOpen_PMV";
            buttonOpen_PMV.Size = new Size(50, 50);
            buttonOpen_PMV.TabIndex = 0;
            toolTip_PMV.SetToolTip(buttonOpen_PMV, "Открыть файл для обработки данных в формате CSV");
            buttonOpen_PMV.UseVisualStyleBackColor = true;
            buttonOpen_PMV.Click += buttonOpen_PMV_Click;
            // 
            // buttonRun_PMV
            // 
            buttonRun_PMV.Image = (Image)resources.GetObject("buttonRun_PMV.Image");
            buttonRun_PMV.Location = new Point(66, 6);
            buttonRun_PMV.Name = "buttonRun_PMV";
            buttonRun_PMV.Size = new Size(50, 50);
            buttonRun_PMV.TabIndex = 1;
            toolTip_PMV.SetToolTip(buttonRun_PMV, "Выполнить обработку данных");
            buttonRun_PMV.UseVisualStyleBackColor = true;
            buttonRun_PMV.Click += buttonRun_PMV_Click;
            // 
            // buttonSave_PMV
            // 
            buttonSave_PMV.Image = (Image)resources.GetObject("buttonSave_PMV.Image");
            buttonSave_PMV.Location = new Point(122, 6);
            buttonSave_PMV.Name = "buttonSave_PMV";
            buttonSave_PMV.Size = new Size(50, 50);
            buttonSave_PMV.TabIndex = 2;
            toolTip_PMV.SetToolTip(buttonSave_PMV, "Сохранить обработанные данные в формате CSV");
            buttonSave_PMV.UseVisualStyleBackColor = true;
            buttonSave_PMV.Click += buttonSave_PMV_Click;
            // 
            // buttonAbout_PMV
            // 
            buttonAbout_PMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_PMV.Image = (Image)resources.GetObject("buttonAbout_PMV.Image");
            buttonAbout_PMV.Location = new Point(1040, 6);
            buttonAbout_PMV.Name = "buttonAbout_PMV";
            buttonAbout_PMV.Size = new Size(50, 50);
            buttonAbout_PMV.TabIndex = 3;
            toolTip_PMV.SetToolTip(buttonAbout_PMV, "Информация о программе");
            buttonAbout_PMV.UseVisualStyleBackColor = true;
            buttonAbout_PMV.Click += buttonAbout_PMV_Click;
            // 
            // groupBoxTask_PMV
            // 
            groupBoxTask_PMV.Controls.Add(labelTask_PMV);
            groupBoxTask_PMV.Controls.Add(textBoxPath_PMV);
            groupBoxTask_PMV.Dock = DockStyle.Top;
            groupBoxTask_PMV.Location = new Point(0, 60);
            groupBoxTask_PMV.Name = "groupBoxTask_PMV";
            groupBoxTask_PMV.Size = new Size(1100, 120);
            groupBoxTask_PMV.TabIndex = 1;
            groupBoxTask_PMV.TabStop = false;
            groupBoxTask_PMV.Text = "Условие";
            // 
            // labelTask_PMV
            // 
            labelTask_PMV.Dock = DockStyle.Fill;
            labelTask_PMV.Location = new Point(3, 19);
            labelTask_PMV.Name = "labelTask_PMV";
            labelTask_PMV.Size = new Size(1094, 75);
            labelTask_PMV.TabIndex = 0;
            labelTask_PMV.Text = resources.GetString("labelTask_PMV.Text");
            labelTask_PMV.Click += labelTask_PMV_Click;
            // 
            // textBoxPath_PMV
            // 
            textBoxPath_PMV.Dock = DockStyle.Bottom;
            textBoxPath_PMV.Location = new Point(3, 94);
            textBoxPath_PMV.Name = "textBoxPath_PMV";
            textBoxPath_PMV.Size = new Size(1094, 23);
            textBoxPath_PMV.TabIndex = 1;
            // 
            // splitContainer_PMV
            // 
            splitContainer_PMV.Dock = DockStyle.Fill;
            splitContainer_PMV.Location = new Point(0, 180);
            splitContainer_PMV.Name = "splitContainer_PMV";
            // 
            // splitContainer_PMV.Panel1
            // 
            splitContainer_PMV.Panel1.Controls.Add(groupBoxIn_PMV);
            // 
            // splitContainer_PMV.Panel2
            // 
            splitContainer_PMV.Panel2.Controls.Add(groupBoxOut_PMV);
            splitContainer_PMV.Size = new Size(1100, 520);
            splitContainer_PMV.SplitterDistance = 550;
            splitContainer_PMV.TabIndex = 2;
            // 
            // groupBoxIn_PMV
            // 
            groupBoxIn_PMV.Controls.Add(dataGridViewIn_PMV);
            groupBoxIn_PMV.Dock = DockStyle.Fill;
            groupBoxIn_PMV.Location = new Point(0, 0);
            groupBoxIn_PMV.Name = "groupBoxIn_PMV";
            groupBoxIn_PMV.Size = new Size(550, 520);
            groupBoxIn_PMV.TabIndex = 0;
            groupBoxIn_PMV.TabStop = false;
            groupBoxIn_PMV.Text = "Ввод";
            // 
            // dataGridViewIn_PMV
            // 
            dataGridViewIn_PMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_PMV.Dock = DockStyle.Fill;
            dataGridViewIn_PMV.Location = new Point(3, 19);
            dataGridViewIn_PMV.Name = "dataGridViewIn_PMV";
            dataGridViewIn_PMV.Size = new Size(544, 498);
            dataGridViewIn_PMV.TabIndex = 0;
            // 
            // groupBoxOut_PMV
            // 
            groupBoxOut_PMV.Controls.Add(dataGridViewOut_PMV);
            groupBoxOut_PMV.Dock = DockStyle.Fill;
            groupBoxOut_PMV.Location = new Point(0, 0);
            groupBoxOut_PMV.Name = "groupBoxOut_PMV";
            groupBoxOut_PMV.Size = new Size(546, 520);
            groupBoxOut_PMV.TabIndex = 0;
            groupBoxOut_PMV.TabStop = false;
            groupBoxOut_PMV.Text = "Вывод";
            // 
            // dataGridViewOut_PMV
            // 
            dataGridViewOut_PMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_PMV.Dock = DockStyle.Fill;
            dataGridViewOut_PMV.Location = new Point(3, 19);
            dataGridViewOut_PMV.Name = "dataGridViewOut_PMV";
            dataGridViewOut_PMV.Size = new Size(540, 498);
            dataGridViewOut_PMV.TabIndex = 0;
            // 
            // toolTip_PMV
            // 
            toolTip_PMV.IsBalloon = true;
            toolTip_PMV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(splitContainer_PMV);
            Controls.Add(groupBoxTask_PMV);
            Controls.Add(panelTop_PMV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Платонов М.В.";
            panelTop_PMV.ResumeLayout(false);
            groupBoxTask_PMV.ResumeLayout(false);
            groupBoxTask_PMV.PerformLayout();
            splitContainer_PMV.Panel1.ResumeLayout(false);
            splitContainer_PMV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_PMV).EndInit();
            splitContainer_PMV.ResumeLayout(false);
            groupBoxIn_PMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PMV).EndInit();
            groupBoxOut_PMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PMV).EndInit();
            ResumeLayout(false);

        }
    }
}