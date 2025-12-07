namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelInfo_PMV;
        private System.Windows.Forms.PictureBox pictureBoxLogo_PMV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_PMV = new Label();
            pictureBoxLogo_PMV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_PMV).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_PMV
            // 
            labelInfo_PMV.AutoSize = true;
            labelInfo_PMV.Location = new Point(82, 12);
            labelInfo_PMV.Name = "labelInfo_PMV";
            labelInfo_PMV.Size = new Size(0, 15);
            labelInfo_PMV.TabIndex = 1;
            // 
            // pictureBoxLogo_PMV
            // 
            pictureBoxLogo_PMV.Image = (Image)resources.GetObject("pictureBoxLogo_PMV.Image");
            pictureBoxLogo_PMV.Location = new Point(12, 12);
            pictureBoxLogo_PMV.Name = "pictureBoxLogo_PMV";
            pictureBoxLogo_PMV.Size = new Size(64, 64);
            pictureBoxLogo_PMV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo_PMV.TabIndex = 0;
            pictureBoxLogo_PMV.TabStop = false;
            // 
            // FormAbout
            // 
            ClientSize = new Size(380, 130);
            Controls.Add(pictureBoxLogo_PMV);
            Controls.Add(labelInfo_PMV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_PMV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}