namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBoxPhoto_PMV;
        private System.Windows.Forms.Label labelInfo_PMV;
        private System.Windows.Forms.Button buttonOk_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxPhoto_PMV = new PictureBox();
            labelInfo_PMV = new Label();
            buttonOk_PMV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_PMV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto_PMV
            // 
            pictureBoxPhoto_PMV.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPhoto_PMV.Image = (Image)resources.GetObject("pictureBoxPhoto_PMV.Image");
            pictureBoxPhoto_PMV.Location = new Point(12, 12);
            pictureBoxPhoto_PMV.Name = "pictureBoxPhoto_PMV";
            pictureBoxPhoto_PMV.Size = new Size(120, 120);
            pictureBoxPhoto_PMV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_PMV.TabIndex = 0;
            pictureBoxPhoto_PMV.TabStop = false;
            // 
            // labelInfo_PMV
            // 
            labelInfo_PMV.Location = new Point(140, 12);
            labelInfo_PMV.Name = "labelInfo_PMV";
            labelInfo_PMV.Size = new Size(338, 120);
            labelInfo_PMV.TabIndex = 1;
            labelInfo_PMV.Text = resources.GetString("labelInfo_PMV.Text");
            labelInfo_PMV.Click += labelInfo_PMV_Click;
            // 
            // buttonOk_PMV
            // 
            buttonOk_PMV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk_PMV.DialogResult = DialogResult.OK;
            buttonOk_PMV.Location = new Point(388, 145);
            buttonOk_PMV.Name = "buttonOk_PMV";
            buttonOk_PMV.Size = new Size(90, 28);
            buttonOk_PMV.TabIndex = 2;
            buttonOk_PMV.Text = "OK";
            buttonOk_PMV.UseVisualStyleBackColor = true;
            buttonOk_PMV.Click += buttonOk_PMV_Click;
            // 
            // FormAbout
            // 
            AcceptButton = buttonOk_PMV;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 185);
            Controls.Add(buttonOk_PMV);
            Controls.Add(labelInfo_PMV);
            Controls.Add(pictureBoxPhoto_PMV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_PMV).EndInit();
            ResumeLayout(false);
        }
    }
}