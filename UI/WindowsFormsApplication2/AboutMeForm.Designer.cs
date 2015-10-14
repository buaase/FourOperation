namespace WindowsFormsApplication2
{
    partial class AboutMeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMeForm));
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfRichTextBox1
            // 
            resources.ApplyResources(rtfRichTextBox1, "rtfRichTextBox1");
            rtfRichTextBox1.EnableAutoDragDrop = true;
            rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            rtfRichTextBox1.Name = "rtfRichTextBox1";
            rtfRichTextBox1.ReadOnly = true;
            rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinPictureBox1
            // 
            resources.ApplyResources(this.skinPictureBox1, "skinPictureBox1");
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Aboutme;
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.TabStop = false;
            // 
            // AboutMeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(rtfRichTextBox1);
            this.Name = "AboutMeForm";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
    }
}