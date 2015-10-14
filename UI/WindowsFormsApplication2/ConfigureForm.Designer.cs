namespace WindowsFormsApplication2
{
    partial class ConfigureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OpCountUpAndDown = new CCWin.SkinControl.SkinNumericUpDown();
            this.ExeCountUpAndDown = new CCWin.SkinControl.SkinNumericUpDown();
            this.MinRangeUpAndDown = new CCWin.SkinControl.SkinNumericUpDown();
            this.MaxRangeUpAndDown = new CCWin.SkinControl.SkinNumericUpDown();
            this.HasBrackCheck = new CCWin.SkinControl.SkinCheckBox();
            this.HasMultDivCheck = new CCWin.SkinControl.SkinCheckBox();
            this.HasFracCheck = new CCWin.SkinControl.SkinCheckBox();
            this.HasNegCheck = new CCWin.SkinControl.SkinCheckBox();
            this.HasDecimalCheck = new CCWin.SkinControl.SkinCheckBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.OpCountUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExeCountUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRangeUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRangeUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // OpCountUpAndDown
            // 
            resources.ApplyResources(this.OpCountUpAndDown, "OpCountUpAndDown");
            this.OpCountUpAndDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.OpCountUpAndDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OpCountUpAndDown.Name = "OpCountUpAndDown";
            this.OpCountUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExeCountUpAndDown
            // 
            resources.ApplyResources(this.ExeCountUpAndDown, "ExeCountUpAndDown");
            this.ExeCountUpAndDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ExeCountUpAndDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExeCountUpAndDown.Name = "ExeCountUpAndDown";
            this.ExeCountUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinRangeUpAndDown
            // 
            resources.ApplyResources(this.MinRangeUpAndDown, "MinRangeUpAndDown");
            this.MinRangeUpAndDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MinRangeUpAndDown.Name = "MinRangeUpAndDown";
            this.MinRangeUpAndDown.Click += new System.EventHandler(this.leftRange_ValueChanged);
            // 
            // MaxRangeUpAndDown
            // 
            resources.ApplyResources(this.MaxRangeUpAndDown, "MaxRangeUpAndDown");
            this.MaxRangeUpAndDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxRangeUpAndDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxRangeUpAndDown.Name = "MaxRangeUpAndDown";
            this.MaxRangeUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HasBrackCheck
            // 
            resources.ApplyResources(this.HasBrackCheck, "HasBrackCheck");
            this.HasBrackCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasBrackCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasBrackCheck.DefaultCheckButtonWidth = 20;
            this.HasBrackCheck.DownBack = null;
            this.HasBrackCheck.MouseBack = null;
            this.HasBrackCheck.Name = "HasBrackCheck";
            this.HasBrackCheck.NormlBack = null;
            this.HasBrackCheck.SelectedDownBack = null;
            this.HasBrackCheck.SelectedMouseBack = null;
            this.HasBrackCheck.SelectedNormlBack = null;
            this.HasBrackCheck.UseVisualStyleBackColor = false;
            // 
            // HasMultDivCheck
            // 
            resources.ApplyResources(this.HasMultDivCheck, "HasMultDivCheck");
            this.HasMultDivCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasMultDivCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasMultDivCheck.DefaultCheckButtonWidth = 20;
            this.HasMultDivCheck.DownBack = null;
            this.HasMultDivCheck.MouseBack = null;
            this.HasMultDivCheck.Name = "HasMultDivCheck";
            this.HasMultDivCheck.NormlBack = null;
            this.HasMultDivCheck.SelectedDownBack = null;
            this.HasMultDivCheck.SelectedMouseBack = null;
            this.HasMultDivCheck.SelectedNormlBack = null;
            this.HasMultDivCheck.UseVisualStyleBackColor = false;
            // 
            // HasFracCheck
            // 
            resources.ApplyResources(this.HasFracCheck, "HasFracCheck");
            this.HasFracCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasFracCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasFracCheck.DefaultCheckButtonWidth = 20;
            this.HasFracCheck.DownBack = null;
            this.HasFracCheck.MouseBack = null;
            this.HasFracCheck.Name = "HasFracCheck";
            this.HasFracCheck.NormlBack = null;
            this.HasFracCheck.SelectedDownBack = null;
            this.HasFracCheck.SelectedMouseBack = null;
            this.HasFracCheck.SelectedNormlBack = null;
            this.HasFracCheck.UseVisualStyleBackColor = false;
            // 
            // HasNegCheck
            // 
            resources.ApplyResources(this.HasNegCheck, "HasNegCheck");
            this.HasNegCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasNegCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasNegCheck.DefaultCheckButtonWidth = 20;
            this.HasNegCheck.DownBack = null;
            this.HasNegCheck.MouseBack = null;
            this.HasNegCheck.Name = "HasNegCheck";
            this.HasNegCheck.NormlBack = null;
            this.HasNegCheck.SelectedDownBack = null;
            this.HasNegCheck.SelectedMouseBack = null;
            this.HasNegCheck.SelectedNormlBack = null;
            this.HasNegCheck.UseVisualStyleBackColor = false;
            // 
            // HasDecimalCheck
            // 
            resources.ApplyResources(this.HasDecimalCheck, "HasDecimalCheck");
            this.HasDecimalCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasDecimalCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasDecimalCheck.DefaultCheckButtonWidth = 20;
            this.HasDecimalCheck.DownBack = null;
            this.HasDecimalCheck.MouseBack = null;
            this.HasDecimalCheck.Name = "HasDecimalCheck";
            this.HasDecimalCheck.NormlBack = null;
            this.HasDecimalCheck.SelectedDownBack = null;
            this.HasDecimalCheck.SelectedMouseBack = null;
            this.HasDecimalCheck.SelectedNormlBack = null;
            this.HasDecimalCheck.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            resources.ApplyResources(this.skinButton1, "skinButton1");
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // ConfigureForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.HasDecimalCheck);
            this.Controls.Add(this.HasNegCheck);
            this.Controls.Add(this.HasFracCheck);
            this.Controls.Add(this.HasMultDivCheck);
            this.Controls.Add(this.HasBrackCheck);
            this.Controls.Add(this.MaxRangeUpAndDown);
            this.Controls.Add(this.MinRangeUpAndDown);
            this.Controls.Add(this.ExeCountUpAndDown);
            this.Controls.Add(this.OpCountUpAndDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigureForm";
            ((System.ComponentModel.ISupportInitialize)(this.OpCountUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExeCountUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRangeUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRangeUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CCWin.SkinControl.SkinNumericUpDown OpCountUpAndDown;
        private CCWin.SkinControl.SkinNumericUpDown ExeCountUpAndDown;
        private CCWin.SkinControl.SkinNumericUpDown MinRangeUpAndDown;
        private CCWin.SkinControl.SkinNumericUpDown MaxRangeUpAndDown;
        private CCWin.SkinControl.SkinCheckBox HasBrackCheck;
        private CCWin.SkinControl.SkinCheckBox HasMultDivCheck;
        private CCWin.SkinControl.SkinCheckBox HasFracCheck;
        private CCWin.SkinControl.SkinCheckBox HasNegCheck;
        private CCWin.SkinControl.SkinCheckBox HasDecimalCheck;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}