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
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(80, 70);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(335, 25);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "下次启动时是否要自动导入配置文件？";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ConfirmButton.DownBack = null;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(155, 165);
            this.ConfirmButton.MouseBack = null;
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.NormlBack = null;
            this.ConfirmButton.Size = new System.Drawing.Size(140, 43);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoRadioButton);
            this.panel1.Controls.Add(this.YesRadioButton);
            this.panel1.Location = new System.Drawing.Point(57, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 64);
            this.panel1.TabIndex = 5;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.NoRadioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.NoRadioButton.DefaultRadioButtonWidth = 18;
            this.NoRadioButton.DownBack = null;
            this.NoRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoRadioButton.Location = new System.Drawing.Point(218, 18);
            this.NoRadioButton.MouseBack = null;
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.NormlBack = null;
            this.NoRadioButton.SelectedDownBack = null;
            this.NoRadioButton.SelectedMouseBack = null;
            this.NoRadioButton.SelectedNormlBack = null;
            this.NoRadioButton.Size = new System.Drawing.Size(52, 29);
            this.NoRadioButton.TabIndex = 4;
            this.NoRadioButton.Text = "否";
            this.NoRadioButton.UseVisualStyleBackColor = false;
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.YesRadioButton.Checked = true;
            this.YesRadioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.YesRadioButton.DefaultRadioButtonWidth = 18;
            this.YesRadioButton.DownBack = null;
            this.YesRadioButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.YesRadioButton.Location = new System.Drawing.Point(113, 18);
            this.YesRadioButton.MouseBack = null;
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.NormlBack = null;
            this.YesRadioButton.SelectedDownBack = null;
            this.YesRadioButton.SelectedMouseBack = null;
            this.YesRadioButton.SelectedNormlBack = null;
            this.YesRadioButton.Size = new System.Drawing.Size(52, 29);
            this.YesRadioButton.TabIndex = 3;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "是";
            this.YesRadioButton.UseVisualStyleBackColor = false;
            // 
            // RememberMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.skinLabel1);
            this.Name = "RememberMe";
            this.Text = "RememberMe";
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