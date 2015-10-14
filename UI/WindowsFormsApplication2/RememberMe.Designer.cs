namespace WindowsFormsApplication2
{
    partial class RememberMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RememberMe));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.ConfirmButton = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoRadioButton = new CCWin.SkinControl.SkinRadioButton();
            this.YesRadioButton = new CCWin.SkinControl.SkinRadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            resources.ApplyResources(this.skinLabel1, "skinLabel1");
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Name = "skinLabel1";
            // 
            // ConfirmButton
            // 
            resources.ApplyResources(this.ConfirmButton, "ConfirmButton");
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ConfirmButton.DownBack = null;
            this.ConfirmButton.MouseBack = null;
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.NormlBack = null;
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.NoRadioButton);
            this.panel1.Controls.Add(this.YesRadioButton);
            this.panel1.Name = "panel1";
            // 
            // NoRadioButton
            // 
            resources.ApplyResources(this.NoRadioButton, "NoRadioButton");
            this.NoRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.NoRadioButton.BaseColor = System.Drawing.Color.CadetBlue;
            this.NoRadioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.NoRadioButton.DefaultRadioButtonWidth = 18;
            this.NoRadioButton.DownBack = null;
            this.NoRadioButton.MouseBack = null;
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.NormlBack = null;
            this.NoRadioButton.SelectedDownBack = null;
            this.NoRadioButton.SelectedMouseBack = null;
            this.NoRadioButton.SelectedNormlBack = null;
            this.NoRadioButton.UseVisualStyleBackColor = false;
            // 
            // YesRadioButton
            // 
            resources.ApplyResources(this.YesRadioButton, "YesRadioButton");
            this.YesRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.YesRadioButton.BaseColor = System.Drawing.Color.CadetBlue;
            this.YesRadioButton.Checked = true;
            this.YesRadioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.YesRadioButton.DefaultRadioButtonWidth = 18;
            this.YesRadioButton.DownBack = null;
            this.YesRadioButton.MouseBack = null;
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.NormlBack = null;
            this.YesRadioButton.SelectedDownBack = null;
            this.YesRadioButton.SelectedMouseBack = null;
            this.YesRadioButton.SelectedNormlBack = null;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.UseVisualStyleBackColor = false;
            // 
            // RememberMe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.skinLabel1);
            this.Name = "RememberMe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton ConfirmButton;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinRadioButton NoRadioButton;
        private CCWin.SkinControl.SkinRadioButton YesRadioButton;
    }
}