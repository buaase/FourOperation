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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "题目中运算符的个数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "题目或运算中出现小数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "题目的数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "题目中数值的范围";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "题目中出现括号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "题目中出现乘除法";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "题目中或运算中出现分数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "题目或运算中出现负数";
            // 
            // OpCountUpAndDown
            // 
            this.OpCountUpAndDown.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpCountUpAndDown.Location = new System.Drawing.Point(298, 35);
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
            this.OpCountUpAndDown.Size = new System.Drawing.Size(91, 27);
            this.OpCountUpAndDown.TabIndex = 7;
            this.OpCountUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExeCountUpAndDown
            // 
            this.ExeCountUpAndDown.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExeCountUpAndDown.Location = new System.Drawing.Point(298, 75);
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
            this.ExeCountUpAndDown.Size = new System.Drawing.Size(91, 27);
            this.ExeCountUpAndDown.TabIndex = 8;
            this.ExeCountUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinRangeUpAndDown
            // 
            this.MinRangeUpAndDown.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinRangeUpAndDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinRangeUpAndDown.Location = new System.Drawing.Point(242, 115);
            this.MinRangeUpAndDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MinRangeUpAndDown.Name = "MinRangeUpAndDown";
            this.MinRangeUpAndDown.Size = new System.Drawing.Size(91, 27);
            this.MinRangeUpAndDown.TabIndex = 9;
            this.MinRangeUpAndDown.Click += new System.EventHandler(this.leftRange_ValueChanged);
            // 
            // MaxRangeUpAndDown
            // 
            this.MaxRangeUpAndDown.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxRangeUpAndDown.Location = new System.Drawing.Point(339, 115);
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
            this.MaxRangeUpAndDown.Size = new System.Drawing.Size(91, 27);
            this.MaxRangeUpAndDown.TabIndex = 10;
            this.MaxRangeUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HasBrackCheck
            // 
            this.HasBrackCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasBrackCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasBrackCheck.DefaultCheckButtonWidth = 20;
            this.HasBrackCheck.DownBack = null;
            this.HasBrackCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasBrackCheck.Location = new System.Drawing.Point(704, 35);
            this.HasBrackCheck.MouseBack = null;
            this.HasBrackCheck.Name = "HasBrackCheck";
            this.HasBrackCheck.NormlBack = null;
            this.HasBrackCheck.SelectedDownBack = null;
            this.HasBrackCheck.SelectedMouseBack = null;
            this.HasBrackCheck.SelectedNormlBack = null;
            this.HasBrackCheck.Size = new System.Drawing.Size(37, 27);
            this.HasBrackCheck.TabIndex = 11;
            this.HasBrackCheck.UseVisualStyleBackColor = false;
            // 
            // HasMultDivCheck
            // 
            this.HasMultDivCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasMultDivCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasMultDivCheck.DefaultCheckButtonWidth = 20;
            this.HasMultDivCheck.DownBack = null;
            this.HasMultDivCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasMultDivCheck.Location = new System.Drawing.Point(704, 72);
            this.HasMultDivCheck.MouseBack = null;
            this.HasMultDivCheck.Name = "HasMultDivCheck";
            this.HasMultDivCheck.NormlBack = null;
            this.HasMultDivCheck.SelectedDownBack = null;
            this.HasMultDivCheck.SelectedMouseBack = null;
            this.HasMultDivCheck.SelectedNormlBack = null;
            this.HasMultDivCheck.Size = new System.Drawing.Size(37, 27);
            this.HasMultDivCheck.TabIndex = 12;
            this.HasMultDivCheck.UseVisualStyleBackColor = false;
            // 
            // HasFracCheck
            // 
            this.HasFracCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasFracCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasFracCheck.DefaultCheckButtonWidth = 20;
            this.HasFracCheck.DownBack = null;
            this.HasFracCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasFracCheck.Location = new System.Drawing.Point(704, 112);
            this.HasFracCheck.MouseBack = null;
            this.HasFracCheck.Name = "HasFracCheck";
            this.HasFracCheck.NormlBack = null;
            this.HasFracCheck.SelectedDownBack = null;
            this.HasFracCheck.SelectedMouseBack = null;
            this.HasFracCheck.SelectedNormlBack = null;
            this.HasFracCheck.Size = new System.Drawing.Size(37, 27);
            this.HasFracCheck.TabIndex = 13;
            this.HasFracCheck.UseVisualStyleBackColor = false;
            // 
            // HasNegCheck
            // 
            this.HasNegCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasNegCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasNegCheck.DefaultCheckButtonWidth = 20;
            this.HasNegCheck.DownBack = null;
            this.HasNegCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasNegCheck.Location = new System.Drawing.Point(704, 153);
            this.HasNegCheck.MouseBack = null;
            this.HasNegCheck.Name = "HasNegCheck";
            this.HasNegCheck.NormlBack = null;
            this.HasNegCheck.SelectedDownBack = null;
            this.HasNegCheck.SelectedMouseBack = null;
            this.HasNegCheck.SelectedNormlBack = null;
            this.HasNegCheck.Size = new System.Drawing.Size(37, 27);
            this.HasNegCheck.TabIndex = 14;
            this.HasNegCheck.UseVisualStyleBackColor = false;
            // 
            // HasDecimalCheck
            // 
            this.HasDecimalCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasDecimalCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasDecimalCheck.DefaultCheckButtonWidth = 20;
            this.HasDecimalCheck.DownBack = null;
            this.HasDecimalCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasDecimalCheck.Location = new System.Drawing.Point(322, 156);
            this.HasDecimalCheck.MouseBack = null;
            this.HasDecimalCheck.Name = "HasDecimalCheck";
            this.HasDecimalCheck.NormlBack = null;
            this.HasDecimalCheck.SelectedDownBack = null;
            this.HasDecimalCheck.SelectedMouseBack = null;
            this.HasDecimalCheck.SelectedNormlBack = null;
            this.HasDecimalCheck.Size = new System.Drawing.Size(37, 27);
            this.HasDecimalCheck.TabIndex = 15;
            this.HasDecimalCheck.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinButton1.Location = new System.Drawing.Point(322, 201);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(155, 54);
            this.skinButton1.TabIndex = 16;
            this.skinButton1.Text = "保存";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(801, 271);
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
            this.Text = "配置窗口";
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