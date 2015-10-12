

using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.tabPageCheck = new System.Windows.Forms.TabPage();
            this.DisGradeBox = new CCWin.SkinControl.SkinTextBox();
            this.ExeText = new System.Windows.Forms.TextBox();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.ExeButton = new CCWin.SkinControl.SkinButton();
            this.AnswerButton = new CCWin.SkinControl.SkinButton();
            this.tabPageGen = new System.Windows.Forms.TabPage();
            this.GenPage = new CCWin.SkinControl.SkinPanel();
            this.PageSet = new System.Windows.Forms.TabControl();
            this.tabPageCalc = new System.Windows.Forms.TabPage();
            this.lastCalcBox = new CCWin.SkinControl.SkinLabel();
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.calcTextBox = new CCWin.SkinControl.SkinTextBox();
            this.calcButtonDelete = new CCWin.SkinControl.SkinButton();
            this.calcButtonRBrack = new CCWin.SkinControl.SkinButton();
            this.calcButtonLBrack = new CCWin.SkinControl.SkinButton();
            this.calcButtonResult = new CCWin.SkinControl.SkinButton();
            this.calcButtonClean = new CCWin.SkinControl.SkinButton();
            this.calcButtonSub = new CCWin.SkinControl.SkinButton();
            this.calcButtonAdd = new CCWin.SkinControl.SkinButton();
            this.calcButtonMult = new CCWin.SkinControl.SkinButton();
            this.calcButtonDiv = new CCWin.SkinControl.SkinButton();
            this.calcButtonQuestion = new CCWin.SkinControl.SkinButton();
            this.calcButtonQuote = new CCWin.SkinControl.SkinButton();
            this.calcButton0 = new CCWin.SkinControl.SkinButton();
            this.calcButton3 = new CCWin.SkinControl.SkinButton();
            this.calcButton2 = new CCWin.SkinControl.SkinButton();
            this.calcButton1 = new CCWin.SkinControl.SkinButton();
            this.calcButton6 = new CCWin.SkinControl.SkinButton();
            this.calcButton5 = new CCWin.SkinControl.SkinButton();
            this.calcButton4 = new CCWin.SkinControl.SkinButton();
            this.calcButton9 = new CCWin.SkinControl.SkinButton();
            this.calcButton8 = new CCWin.SkinControl.SkinButton();
            this.calcButton7 = new CCWin.SkinControl.SkinButton();
            this.GradeFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExeAnsTextBox = new CCWin.SkinControl.SkinTextBox();
            this.GenProgressIndicator = new CCWin.SkinControl.SkinProgressIndicator();
            this.GenButton = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改生成Gradetxt文件路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改生成Exercisetxt文件路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改生成Answertxt文件路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入配置设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.한국어ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tabPageCheck.SuspendLayout();
            this.tabPageGen.SuspendLayout();
            this.GenPage.SuspendLayout();
            this.PageSet.SuspendLayout();
            this.tabPageCalc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ExeAnsTextBox.SuspendLayout();
            this.skinMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            this.skinToolTip1.ShowAlways = true;
            this.skinToolTip1.ToolTipTitle = "格式说明：";
            // 
            // tabPageCheck
            // 
            this.tabPageCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCheck.Controls.Add(this.DisGradeBox);
            this.tabPageCheck.Controls.Add(this.ExeText);
            this.tabPageCheck.Controls.Add(this.AnswerText);
            this.tabPageCheck.Controls.Add(this.skinButton1);
            this.tabPageCheck.Controls.Add(this.ExeButton);
            this.tabPageCheck.Controls.Add(this.AnswerButton);
            this.tabPageCheck.Location = new System.Drawing.Point(4, 32);
            this.tabPageCheck.Name = "tabPageCheck";
            this.tabPageCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheck.Size = new System.Drawing.Size(884, 404);
            this.tabPageCheck.TabIndex = 1;
            this.tabPageCheck.Text = "检查答案";
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // DisGradeBox
            // 
            this.DisGradeBox.BackColor = System.Drawing.Color.Transparent;
            this.DisGradeBox.DownBack = null;
            this.DisGradeBox.Icon = null;
            this.DisGradeBox.IconIsButton = false;
            this.DisGradeBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.DisGradeBox.IsPasswordChat = '\0';
            this.DisGradeBox.IsSystemPasswordChar = false;
            this.DisGradeBox.Lines = new string[0];
            this.DisGradeBox.Location = new System.Drawing.Point(43, 167);
            this.DisGradeBox.Margin = new System.Windows.Forms.Padding(0);
            this.DisGradeBox.MaxLength = 32767;
            this.DisGradeBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.DisGradeBox.MouseBack = null;
            this.DisGradeBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.DisGradeBox.Multiline = true;
            this.DisGradeBox.Name = "DisGradeBox";
            this.DisGradeBox.NormlBack = null;
            this.DisGradeBox.Padding = new System.Windows.Forms.Padding(5);
            this.DisGradeBox.ReadOnly = false;
            this.DisGradeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DisGradeBox.Size = new System.Drawing.Size(812, 214);
            // 
            // 
            // 
            this.DisGradeBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisGradeBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisGradeBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.DisGradeBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.DisGradeBox.SkinTxt.Multiline = true;
            this.DisGradeBox.SkinTxt.Name = "BaseText";
            this.DisGradeBox.SkinTxt.Size = new System.Drawing.Size(802, 204);
            this.DisGradeBox.SkinTxt.TabIndex = 0;
            this.DisGradeBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DisGradeBox.SkinTxt.WaterText = "";
            this.DisGradeBox.TabIndex = 9;
            this.DisGradeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DisGradeBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DisGradeBox.WaterText = "";
            this.DisGradeBox.WordWrap = true;
            // 
            // ExeText
            // 
            this.ExeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ExeText.Location = new System.Drawing.Point(179, 88);
            this.ExeText.Multiline = true;
            this.ExeText.Name = "ExeText";
            this.ExeText.ReadOnly = true;
            this.ExeText.Size = new System.Drawing.Size(227, 37);
            this.ExeText.TabIndex = 3;
            this.ExeText.WordWrap = false;
            // 
            // AnswerText
            // 
            this.AnswerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.AnswerText.Location = new System.Drawing.Point(179, 32);
            this.AnswerText.Multiline = true;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.ReadOnly = true;
            this.AnswerText.Size = new System.Drawing.Size(227, 37);
            this.AnswerText.TabIndex = 1;
            this.AnswerText.WordWrap = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.OrangeRed;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinButton1.Location = new System.Drawing.Point(743, 32);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(112, 93);
            this.skinButton1.TabIndex = 8;
            this.skinButton1.Text = "开始检查";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click_1);
            // 
            // ExeButton
            // 
            this.ExeButton.BackColor = System.Drawing.Color.Transparent;
            this.ExeButton.BaseColor = System.Drawing.Color.OrangeRed;
            this.ExeButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.ExeButton.DownBack = null;
            this.ExeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExeButton.Location = new System.Drawing.Point(43, 88);
            this.ExeButton.MouseBack = null;
            this.ExeButton.Name = "ExeButton";
            this.ExeButton.NormlBack = null;
            this.ExeButton.Size = new System.Drawing.Size(130, 37);
            this.ExeButton.TabIndex = 7;
            this.ExeButton.Text = "导入测验题目";
            this.ExeButton.UseVisualStyleBackColor = false;
            this.ExeButton.Click += new System.EventHandler(this.ExeButton_Click);
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.BaseColor = System.Drawing.Color.OrangeRed;
            this.AnswerButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AnswerButton.DownBack = null;
            this.AnswerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerButton.Location = new System.Drawing.Point(43, 32);
            this.AnswerButton.MouseBack = null;
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.NormlBack = null;
            this.AnswerButton.Size = new System.Drawing.Size(130, 37);
            this.AnswerButton.TabIndex = 6;
            this.AnswerButton.Text = "导入答案文件";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // tabPageGen
            // 
            this.tabPageGen.Controls.Add(this.GenPage);
            this.tabPageGen.Location = new System.Drawing.Point(4, 32);
            this.tabPageGen.Name = "tabPageGen";
            this.tabPageGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGen.Size = new System.Drawing.Size(884, 404);
            this.tabPageGen.TabIndex = 0;
            this.tabPageGen.Text = "生成表达式";
            this.tabPageGen.UseVisualStyleBackColor = true;
            // 
            // GenPage
            // 
            this.GenPage.BackColor = System.Drawing.Color.Transparent;
            this.GenPage.Controls.Add(this.panel1);
            this.GenPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.GenPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenPage.DownBack = null;
            this.GenPage.Location = new System.Drawing.Point(3, 3);
            this.GenPage.MouseBack = null;
            this.GenPage.Name = "GenPage";
            this.GenPage.NormlBack = null;
            this.GenPage.Size = new System.Drawing.Size(878, 398);
            this.GenPage.TabIndex = 0;
            // 
            // PageSet
            // 
            this.PageSet.Controls.Add(this.tabPageGen);
            this.PageSet.Controls.Add(this.tabPageCheck);
            this.PageSet.Controls.Add(this.tabPageCalc);
            this.PageSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PageSet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PageSet.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageSet.Location = new System.Drawing.Point(4, 56);
            this.PageSet.Margin = new System.Windows.Forms.Padding(0);
            this.PageSet.Name = "PageSet";
            this.PageSet.SelectedIndex = 0;
            this.PageSet.Size = new System.Drawing.Size(892, 440);
            this.PageSet.TabIndex = 0;
            // 
            // tabPageCalc
            // 
            this.tabPageCalc.Controls.Add(this.lastCalcBox);
            this.tabPageCalc.Controls.Add(this.rtfRichTextBox1);
            this.tabPageCalc.Controls.Add(this.calcTextBox);
            this.tabPageCalc.Controls.Add(this.calcButtonDelete);
            this.tabPageCalc.Controls.Add(this.calcButtonRBrack);
            this.tabPageCalc.Controls.Add(this.calcButtonLBrack);
            this.tabPageCalc.Controls.Add(this.calcButtonResult);
            this.tabPageCalc.Controls.Add(this.calcButtonClean);
            this.tabPageCalc.Controls.Add(this.calcButtonSub);
            this.tabPageCalc.Controls.Add(this.calcButtonAdd);
            this.tabPageCalc.Controls.Add(this.calcButtonMult);
            this.tabPageCalc.Controls.Add(this.calcButtonDiv);
            this.tabPageCalc.Controls.Add(this.calcButtonQuestion);
            this.tabPageCalc.Controls.Add(this.calcButtonQuote);
            this.tabPageCalc.Controls.Add(this.calcButton0);
            this.tabPageCalc.Controls.Add(this.calcButton3);
            this.tabPageCalc.Controls.Add(this.calcButton2);
            this.tabPageCalc.Controls.Add(this.calcButton1);
            this.tabPageCalc.Controls.Add(this.calcButton6);
            this.tabPageCalc.Controls.Add(this.calcButton5);
            this.tabPageCalc.Controls.Add(this.calcButton4);
            this.tabPageCalc.Controls.Add(this.calcButton9);
            this.tabPageCalc.Controls.Add(this.calcButton8);
            this.tabPageCalc.Controls.Add(this.calcButton7);
            this.tabPageCalc.Location = new System.Drawing.Point(4, 32);
            this.tabPageCalc.Name = "tabPageCalc";
            this.tabPageCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalc.Size = new System.Drawing.Size(884, 404);
            this.tabPageCalc.TabIndex = 2;
            this.tabPageCalc.Text = "计算器";
            this.tabPageCalc.UseVisualStyleBackColor = true;
            // 
            // lastCalcBox
            // 
            this.lastCalcBox.BackColor = System.Drawing.Color.Transparent;
            this.lastCalcBox.BorderColor = System.Drawing.Color.White;
            this.lastCalcBox.BorderSize = 0;
            this.lastCalcBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lastCalcBox.Location = new System.Drawing.Point(124, 29);
            this.lastCalcBox.Name = "lastCalcBox";
            this.lastCalcBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastCalcBox.Size = new System.Drawing.Size(392, 27);
            this.lastCalcBox.TabIndex = 2;
            this.lastCalcBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRichTextBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(562, 36);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.ReadOnly = true;
            this.rtfRichTextBox1.Size = new System.Drawing.Size(233, 341);
            this.rtfRichTextBox1.TabIndex = 22;
            this.rtfRichTextBox1.Text = "计算器支持键盘快捷键输入，以下为快捷键映射说明：\nShift + \'8\' = \'×\'\nShift + \'/\' = \'÷\'\nShift + \'9\' = \'(\'\nSh" +
    "ift + \'0\' = \')\'\nShift + \'=\' = \'+\'\nShift + \'\"\' = \' \' \'\nEnter = \'=\'\n其余均为键盘默认单键控制";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // calcTextBox
            // 
            this.calcTextBox.BackColor = System.Drawing.Color.Transparent;
            this.calcTextBox.DownBack = null;
            this.calcTextBox.Icon = null;
            this.calcTextBox.IconIsButton = false;
            this.calcTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.calcTextBox.IsPasswordChat = '\0';
            this.calcTextBox.IsSystemPasswordChar = false;
            this.calcTextBox.Lines = new string[0];
            this.calcTextBox.Location = new System.Drawing.Point(130, 63);
            this.calcTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.calcTextBox.MaxLength = 32767;
            this.calcTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.calcTextBox.MouseBack = null;
            this.calcTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.calcTextBox.Multiline = true;
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.NormlBack = null;
            this.calcTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calcTextBox.Size = new System.Drawing.Size(386, 39);
            // 
            // 
            // 
            this.calcTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.calcTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.calcTextBox.SkinTxt.Multiline = true;
            this.calcTextBox.SkinTxt.Name = "BaseText";
            this.calcTextBox.SkinTxt.ReadOnly = true;
            this.calcTextBox.SkinTxt.Size = new System.Drawing.Size(376, 29);
            this.calcTextBox.SkinTxt.TabIndex = 0;
            this.calcTextBox.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calcTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.calcTextBox.SkinTxt.WaterText = "";
            this.calcTextBox.SkinTxt.WordWrap = false;
            this.calcTextBox.TabIndex = 21;
            this.calcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calcTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.calcTextBox.WaterText = "";
            this.calcTextBox.WordWrap = false;
            // 
            // calcButtonDelete
            // 
            this.calcButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonDelete.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonDelete.DownBack = null;
            this.calcButtonDelete.Location = new System.Drawing.Point(388, 185);
            this.calcButtonDelete.MouseBack = null;
            this.calcButtonDelete.Name = "calcButtonDelete";
            this.calcButtonDelete.NormlBack = null;
            this.calcButtonDelete.Size = new System.Drawing.Size(55, 55);
            this.calcButtonDelete.TabIndex = 20;
            this.calcButtonDelete.Text = "←";
            this.calcButtonDelete.UseVisualStyleBackColor = false;
            this.calcButtonDelete.Click += new System.EventHandler(this.calcButtonDelete_Click);
            // 
            // calcButtonRBrack
            // 
            this.calcButtonRBrack.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonRBrack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonRBrack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonRBrack.DownBack = null;
            this.calcButtonRBrack.Location = new System.Drawing.Point(388, 317);
            this.calcButtonRBrack.MouseBack = null;
            this.calcButtonRBrack.Name = "calcButtonRBrack";
            this.calcButtonRBrack.NormlBack = null;
            this.calcButtonRBrack.Size = new System.Drawing.Size(55, 55);
            this.calcButtonRBrack.TabIndex = 19;
            this.calcButtonRBrack.Text = ")";
            this.calcButtonRBrack.UseVisualStyleBackColor = false;
            this.calcButtonRBrack.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonLBrack
            // 
            this.calcButtonLBrack.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonLBrack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonLBrack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonLBrack.DownBack = null;
            this.calcButtonLBrack.Location = new System.Drawing.Point(388, 251);
            this.calcButtonLBrack.MouseBack = null;
            this.calcButtonLBrack.Name = "calcButtonLBrack";
            this.calcButtonLBrack.NormlBack = null;
            this.calcButtonLBrack.Size = new System.Drawing.Size(55, 55);
            this.calcButtonLBrack.TabIndex = 18;
            this.calcButtonLBrack.Text = "(";
            this.calcButtonLBrack.UseVisualStyleBackColor = false;
            this.calcButtonLBrack.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonResult
            // 
            this.calcButtonResult.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonResult.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonResult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonResult.DownBack = null;
            this.calcButtonResult.Location = new System.Drawing.Point(456, 185);
            this.calcButtonResult.MouseBack = null;
            this.calcButtonResult.Name = "calcButtonResult";
            this.calcButtonResult.NormlBack = null;
            this.calcButtonResult.Size = new System.Drawing.Size(60, 192);
            this.calcButtonResult.TabIndex = 17;
            this.calcButtonResult.Text = "=";
            this.calcButtonResult.UseVisualStyleBackColor = false;
            this.calcButtonResult.Click += new System.EventHandler(this.calcButtonResult_Click);
            // 
            // calcButtonClean
            // 
            this.calcButtonClean.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonClean.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonClean.DownBack = null;
            this.calcButtonClean.Location = new System.Drawing.Point(388, 119);
            this.calcButtonClean.MouseBack = null;
            this.calcButtonClean.Name = "calcButtonClean";
            this.calcButtonClean.NormlBack = null;
            this.calcButtonClean.Size = new System.Drawing.Size(128, 55);
            this.calcButtonClean.TabIndex = 16;
            this.calcButtonClean.Text = "C";
            this.calcButtonClean.UseVisualStyleBackColor = false;
            this.calcButtonClean.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonSub
            // 
            this.calcButtonSub.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonSub.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonSub.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonSub.DownBack = null;
            this.calcButtonSub.Location = new System.Drawing.Point(324, 317);
            this.calcButtonSub.MouseBack = null;
            this.calcButtonSub.Name = "calcButtonSub";
            this.calcButtonSub.NormlBack = null;
            this.calcButtonSub.Size = new System.Drawing.Size(55, 55);
            this.calcButtonSub.TabIndex = 15;
            this.calcButtonSub.Text = "-";
            this.calcButtonSub.UseVisualStyleBackColor = false;
            this.calcButtonSub.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonAdd
            // 
            this.calcButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonAdd.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonAdd.DownBack = null;
            this.calcButtonAdd.Location = new System.Drawing.Point(324, 251);
            this.calcButtonAdd.MouseBack = null;
            this.calcButtonAdd.Name = "calcButtonAdd";
            this.calcButtonAdd.NormlBack = null;
            this.calcButtonAdd.Size = new System.Drawing.Size(55, 55);
            this.calcButtonAdd.TabIndex = 14;
            this.calcButtonAdd.Text = "+";
            this.calcButtonAdd.UseVisualStyleBackColor = false;
            this.calcButtonAdd.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonMult
            // 
            this.calcButtonMult.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonMult.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonMult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonMult.DownBack = null;
            this.calcButtonMult.Location = new System.Drawing.Point(324, 185);
            this.calcButtonMult.MouseBack = null;
            this.calcButtonMult.Name = "calcButtonMult";
            this.calcButtonMult.NormlBack = null;
            this.calcButtonMult.Size = new System.Drawing.Size(55, 55);
            this.calcButtonMult.TabIndex = 13;
            this.calcButtonMult.Text = "×";
            this.calcButtonMult.UseVisualStyleBackColor = false;
            this.calcButtonMult.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonDiv
            // 
            this.calcButtonDiv.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonDiv.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonDiv.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonDiv.DownBack = null;
            this.calcButtonDiv.Location = new System.Drawing.Point(324, 119);
            this.calcButtonDiv.MouseBack = null;
            this.calcButtonDiv.Name = "calcButtonDiv";
            this.calcButtonDiv.NormlBack = null;
            this.calcButtonDiv.Size = new System.Drawing.Size(55, 55);
            this.calcButtonDiv.TabIndex = 12;
            this.calcButtonDiv.Text = "÷";
            this.calcButtonDiv.UseVisualStyleBackColor = false;
            this.calcButtonDiv.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonQuestion
            // 
            this.calcButtonQuestion.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonQuestion.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonQuestion.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonQuestion.DownBack = null;
            this.calcButtonQuestion.Location = new System.Drawing.Point(258, 317);
            this.calcButtonQuestion.MouseBack = null;
            this.calcButtonQuestion.Name = "calcButtonQuestion";
            this.calcButtonQuestion.NormlBack = null;
            this.calcButtonQuestion.Size = new System.Drawing.Size(55, 55);
            this.calcButtonQuestion.TabIndex = 11;
            this.calcButtonQuestion.Text = "/";
            this.calcButtonQuestion.UseVisualStyleBackColor = false;
            this.calcButtonQuestion.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonQuote
            // 
            this.calcButtonQuote.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonQuote.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonQuote.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonQuote.DownBack = null;
            this.calcButtonQuote.Location = new System.Drawing.Point(194, 317);
            this.calcButtonQuote.MouseBack = null;
            this.calcButtonQuote.Name = "calcButtonQuote";
            this.calcButtonQuote.NormlBack = null;
            this.calcButtonQuote.Size = new System.Drawing.Size(55, 55);
            this.calcButtonQuote.TabIndex = 10;
            this.calcButtonQuote.Text = "\'";
            this.calcButtonQuote.UseVisualStyleBackColor = false;
            this.calcButtonQuote.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton0
            // 
            this.calcButton0.BackColor = System.Drawing.Color.Transparent;
            this.calcButton0.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton0.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton0.DownBack = null;
            this.calcButton0.Location = new System.Drawing.Point(130, 317);
            this.calcButton0.MouseBack = null;
            this.calcButton0.Name = "calcButton0";
            this.calcButton0.NormlBack = null;
            this.calcButton0.Size = new System.Drawing.Size(55, 55);
            this.calcButton0.TabIndex = 9;
            this.calcButton0.Text = "0";
            this.calcButton0.UseVisualStyleBackColor = false;
            this.calcButton0.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton3
            // 
            this.calcButton3.BackColor = System.Drawing.Color.Transparent;
            this.calcButton3.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton3.DownBack = null;
            this.calcButton3.Location = new System.Drawing.Point(258, 251);
            this.calcButton3.MouseBack = null;
            this.calcButton3.Name = "calcButton3";
            this.calcButton3.NormlBack = null;
            this.calcButton3.Size = new System.Drawing.Size(55, 55);
            this.calcButton3.TabIndex = 8;
            this.calcButton3.Text = "3";
            this.calcButton3.UseVisualStyleBackColor = false;
            this.calcButton3.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton2
            // 
            this.calcButton2.BackColor = System.Drawing.Color.Transparent;
            this.calcButton2.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton2.DownBack = null;
            this.calcButton2.Location = new System.Drawing.Point(194, 251);
            this.calcButton2.MouseBack = null;
            this.calcButton2.Name = "calcButton2";
            this.calcButton2.NormlBack = null;
            this.calcButton2.Size = new System.Drawing.Size(55, 55);
            this.calcButton2.TabIndex = 7;
            this.calcButton2.Text = "2";
            this.calcButton2.UseVisualStyleBackColor = false;
            this.calcButton2.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton1
            // 
            this.calcButton1.BackColor = System.Drawing.Color.Transparent;
            this.calcButton1.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton1.DownBack = null;
            this.calcButton1.Location = new System.Drawing.Point(130, 251);
            this.calcButton1.MouseBack = null;
            this.calcButton1.Name = "calcButton1";
            this.calcButton1.NormlBack = null;
            this.calcButton1.Size = new System.Drawing.Size(55, 55);
            this.calcButton1.TabIndex = 6;
            this.calcButton1.Text = "1";
            this.calcButton1.UseVisualStyleBackColor = false;
            this.calcButton1.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton6
            // 
            this.calcButton6.BackColor = System.Drawing.Color.Transparent;
            this.calcButton6.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton6.DownBack = null;
            this.calcButton6.Location = new System.Drawing.Point(258, 185);
            this.calcButton6.MouseBack = null;
            this.calcButton6.Name = "calcButton6";
            this.calcButton6.NormlBack = null;
            this.calcButton6.Size = new System.Drawing.Size(55, 55);
            this.calcButton6.TabIndex = 5;
            this.calcButton6.Text = "6";
            this.calcButton6.UseVisualStyleBackColor = false;
            this.calcButton6.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton5
            // 
            this.calcButton5.BackColor = System.Drawing.Color.Transparent;
            this.calcButton5.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton5.DownBack = null;
            this.calcButton5.Location = new System.Drawing.Point(194, 185);
            this.calcButton5.MouseBack = null;
            this.calcButton5.Name = "calcButton5";
            this.calcButton5.NormlBack = null;
            this.calcButton5.Size = new System.Drawing.Size(55, 55);
            this.calcButton5.TabIndex = 4;
            this.calcButton5.Text = "5";
            this.calcButton5.UseVisualStyleBackColor = false;
            this.calcButton5.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton4
            // 
            this.calcButton4.BackColor = System.Drawing.Color.Transparent;
            this.calcButton4.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton4.DownBack = null;
            this.calcButton4.Location = new System.Drawing.Point(130, 185);
            this.calcButton4.MouseBack = null;
            this.calcButton4.Name = "calcButton4";
            this.calcButton4.NormlBack = null;
            this.calcButton4.Size = new System.Drawing.Size(55, 55);
            this.calcButton4.TabIndex = 3;
            this.calcButton4.Text = "4";
            this.calcButton4.UseVisualStyleBackColor = false;
            this.calcButton4.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton9
            // 
            this.calcButton9.BackColor = System.Drawing.Color.Transparent;
            this.calcButton9.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton9.DownBack = null;
            this.calcButton9.Location = new System.Drawing.Point(258, 119);
            this.calcButton9.MouseBack = null;
            this.calcButton9.Name = "calcButton9";
            this.calcButton9.NormlBack = null;
            this.calcButton9.Size = new System.Drawing.Size(55, 55);
            this.calcButton9.TabIndex = 2;
            this.calcButton9.Text = "9";
            this.calcButton9.UseVisualStyleBackColor = false;
            this.calcButton9.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton8
            // 
            this.calcButton8.BackColor = System.Drawing.Color.Transparent;
            this.calcButton8.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton8.DownBack = null;
            this.calcButton8.Location = new System.Drawing.Point(194, 119);
            this.calcButton8.MouseBack = null;
            this.calcButton8.Name = "calcButton8";
            this.calcButton8.NormlBack = null;
            this.calcButton8.Size = new System.Drawing.Size(55, 55);
            this.calcButton8.TabIndex = 1;
            this.calcButton8.Text = "8";
            this.calcButton8.UseVisualStyleBackColor = false;
            this.calcButton8.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton7
            // 
            this.calcButton7.BackColor = System.Drawing.Color.Transparent;
            this.calcButton7.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton7.DownBack = null;
            this.calcButton7.Location = new System.Drawing.Point(130, 119);
            this.calcButton7.MouseBack = null;
            this.calcButton7.Name = "calcButton7";
            this.calcButton7.NormlBack = null;
            this.calcButton7.Size = new System.Drawing.Size(55, 55);
            this.calcButton7.TabIndex = 0;
            this.calcButton7.Text = "7";
            this.calcButton7.UseVisualStyleBackColor = false;
            this.calcButton7.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.skinButton2);
            this.panel1.Controls.Add(this.GenButton);
            this.panel1.Controls.Add(this.ExeAnsTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 398);
            this.panel1.TabIndex = 16;
            // 
            // ExeAnsTextBox
            // 
            this.ExeAnsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ExeAnsTextBox.Controls.Add(this.GenProgressIndicator);
            this.ExeAnsTextBox.DownBack = null;
            this.ExeAnsTextBox.Icon = null;
            this.ExeAnsTextBox.IconIsButton = false;
            this.ExeAnsTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ExeAnsTextBox.IsPasswordChat = '\0';
            this.ExeAnsTextBox.IsSystemPasswordChar = false;
            this.ExeAnsTextBox.Lines = new string[0];
            this.ExeAnsTextBox.Location = new System.Drawing.Point(0, 0);
            this.ExeAnsTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ExeAnsTextBox.MaxLength = 32767;
            this.ExeAnsTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.ExeAnsTextBox.MouseBack = null;
            this.ExeAnsTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ExeAnsTextBox.Multiline = true;
            this.ExeAnsTextBox.Name = "ExeAnsTextBox";
            this.ExeAnsTextBox.NormlBack = null;
            this.ExeAnsTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.ExeAnsTextBox.ReadOnly = true;
            this.ExeAnsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExeAnsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExeAnsTextBox.Size = new System.Drawing.Size(878, 225);
            // 
            // 
            // 
            this.ExeAnsTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExeAnsTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExeAnsTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.ExeAnsTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ExeAnsTextBox.SkinTxt.Multiline = true;
            this.ExeAnsTextBox.SkinTxt.Name = "BaseText";
            this.ExeAnsTextBox.SkinTxt.ReadOnly = true;
            this.ExeAnsTextBox.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExeAnsTextBox.SkinTxt.Size = new System.Drawing.Size(868, 215);
            this.ExeAnsTextBox.SkinTxt.TabIndex = 0;
            this.ExeAnsTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ExeAnsTextBox.SkinTxt.WaterText = "";
            this.ExeAnsTextBox.TabIndex = 35;
            this.ExeAnsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExeAnsTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ExeAnsTextBox.WaterText = "";
            this.ExeAnsTextBox.WordWrap = true;
            // 
            // GenProgressIndicator
            // 
            this.GenProgressIndicator.BackColor = System.Drawing.Color.Transparent;
            this.GenProgressIndicator.CircleColor = System.Drawing.Color.LightSkyBlue;
            this.GenProgressIndicator.Location = new System.Drawing.Point(346, 214);
            this.GenProgressIndicator.Name = "GenProgressIndicator";
            this.GenProgressIndicator.Percentage = 0F;
            this.GenProgressIndicator.Size = new System.Drawing.Size(210, 210);
            this.GenProgressIndicator.TabIndex = 15;
            this.GenProgressIndicator.Text = "skinProgressIndicator1";
            this.GenProgressIndicator.Visible = false;
            // 
            // GenButton
            // 
            this.GenButton.BackColor = System.Drawing.Color.Transparent;
            this.GenButton.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.GenButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.GenButton.DownBack = null;
            this.GenButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenButton.ForeColor = System.Drawing.Color.Teal;
            this.GenButton.Location = new System.Drawing.Point(167, 287);
            this.GenButton.MouseBack = null;
            this.GenButton.Name = "GenButton";
            this.GenButton.NormlBack = null;
            this.GenButton.Size = new System.Drawing.Size(173, 62);
            this.GenButton.TabIndex = 36;
            this.GenButton.Text = "开始生成";
            this.GenButton.UseVisualStyleBackColor = false;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.skinButton2.DownBack = null;
            this.skinButton2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.ForeColor = System.Drawing.Color.Teal;
            this.skinButton2.Location = new System.Drawing.Point(455, 287);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(173, 62);
            this.skinButton2.TabIndex = 37;
            this.skinButton2.Text = "停止生成";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.语言ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(892, 28);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 1;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改路径ToolStripMenuItem,
            this.导入配置设置ToolStripMenuItem,
            this.设置配置ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 更改路径ToolStripMenuItem
            // 
            this.更改路径ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改生成Gradetxt文件路径ToolStripMenuItem,
            this.更改生成Exercisetxt文件路径ToolStripMenuItem,
            this.更改生成Answertxt文件路径ToolStripMenuItem});
            this.更改路径ToolStripMenuItem.Name = "更改路径ToolStripMenuItem";
            this.更改路径ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.更改路径ToolStripMenuItem.Text = "更改路径";
            // 
            // 更改生成Gradetxt文件路径ToolStripMenuItem
            // 
            this.更改生成Gradetxt文件路径ToolStripMenuItem.Name = "更改生成Gradetxt文件路径ToolStripMenuItem";
            this.更改生成Gradetxt文件路径ToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.更改生成Gradetxt文件路径ToolStripMenuItem.Text = "更改生成Grade.txt文件路径";
            this.更改生成Gradetxt文件路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Gradetxt生成路径ToolStripMenuItem_Click);
            // 
            // 更改生成Exercisetxt文件路径ToolStripMenuItem
            // 
            this.更改生成Exercisetxt文件路径ToolStripMenuItem.Name = "更改生成Exercisetxt文件路径ToolStripMenuItem";
            this.更改生成Exercisetxt文件路径ToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.更改生成Exercisetxt文件路径ToolStripMenuItem.Text = "更改生成Exercise.txt文件路径";
            this.更改生成Exercisetxt文件路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Exercisetxt生成路径ToolStripMenuItem_Click);
            // 
            // 更改生成Answertxt文件路径ToolStripMenuItem
            // 
            this.更改生成Answertxt文件路径ToolStripMenuItem.Name = "更改生成Answertxt文件路径ToolStripMenuItem";
            this.更改生成Answertxt文件路径ToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.更改生成Answertxt文件路径ToolStripMenuItem.Text = "更改生成Answer.txt文件路径";
            this.更改生成Answertxt文件路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Answertxt生成路径ToolStripMenuItem_Click);
            // 
            // 导入配置设置ToolStripMenuItem
            // 
            this.导入配置设置ToolStripMenuItem.Name = "导入配置设置ToolStripMenuItem";
            this.导入配置设置ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.导入配置设置ToolStripMenuItem.Text = "自动导入配置";
            this.导入配置设置ToolStripMenuItem.Click += new System.EventHandler(this.导入配置设置ToolStripMenuItem_Click);
            // 
            // 设置配置ToolStripMenuItem
            // 
            this.设置配置ToolStripMenuItem.Name = "设置配置ToolStripMenuItem";
            this.设置配置ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.设置配置ToolStripMenuItem.Text = "设置配置";
            this.设置配置ToolStripMenuItem.Click += new System.EventHandler(this.设置配置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.한국어ToolStripMenuItem});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.语言ToolStripMenuItem.Text = "语言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.中文ToolStripMenuItem.Text = "中文";
            // 
            // 한국어ToolStripMenuItem
            // 
            this.한국어ToolStripMenuItem.Name = "한국어ToolStripMenuItem";
            this.한국어ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.한국어ToolStripMenuItem.Text = "한국어";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.skinLabel2);
            this.panel2.Controls.Add(this.skinButton4);
            this.panel2.Controls.Add(this.skinButton3);
            this.panel2.Controls.Add(this.skinPictureBox1);
            this.panel2.Controls.Add(this.skinTextBox1);
            this.panel2.Controls.Add(this.skinLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 398);
            this.panel2.TabIndex = 38;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(203, 112);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(108, 25);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "skinLabel1";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "skinTextBox1"};
            this.skinTextBox1.Location = new System.Drawing.Point(380, 108);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(176, 35);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(166, 25);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "skinTextBox1";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 2;
            this.skinTextBox1.Text = "skinTextBox1";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Location = new System.Drawing.Point(237, 179);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(155, 85);
            this.skinPictureBox1.TabIndex = 4;
            this.skinPictureBox1.TabStop = false;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(588, 108);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(85, 35);
            this.skinButton3.TabIndex = 6;
            this.skinButton3.Text = "Answer";
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(346, 299);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(141, 38);
            this.skinButton4.TabIndex = 7;
            this.skinButton4.Text = "Next";
            this.skinButton4.UseVisualStyleBackColor = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(460, 200);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(108, 25);
            this.skinLabel2.TabIndex = 9;
            this.skinLabel2.Text = "skinLabel2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.skinMenuStrip1);
            this.Controls.Add(this.PageSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Text = "四则运算测验器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabPageCheck.ResumeLayout(false);
            this.tabPageCheck.PerformLayout();
            this.tabPageGen.ResumeLayout(false);
            this.GenPage.ResumeLayout(false);
            this.PageSet.ResumeLayout(false);
            this.tabPageCalc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ExeAnsTextBox.ResumeLayout(false);
            this.ExeAnsTextBox.PerformLayout();
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCheck;
        public System.Windows.Forms.TextBox ExeText;
        public System.Windows.Forms.TextBox AnswerText;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton ExeButton;
        private CCWin.SkinControl.SkinButton AnswerButton;
        private System.Windows.Forms.TabPage tabPageGen;
        private CCWin.SkinControl.SkinPanel GenPage;
        private System.Windows.Forms.TabControl PageSet;
        private System.Windows.Forms.TabPage tabPageCalc;
        private CCWin.SkinControl.SkinButton calcButtonResult;
        private CCWin.SkinControl.SkinButton calcButtonClean;
        private CCWin.SkinControl.SkinButton calcButtonSub;
        private CCWin.SkinControl.SkinButton calcButtonAdd;
        private CCWin.SkinControl.SkinButton calcButtonMult;
        private CCWin.SkinControl.SkinButton calcButtonDiv;
        private CCWin.SkinControl.SkinButton calcButtonQuestion;
        private CCWin.SkinControl.SkinButton calcButtonQuote;
        private CCWin.SkinControl.SkinButton calcButton0;
        private CCWin.SkinControl.SkinButton calcButton3;
        private CCWin.SkinControl.SkinButton calcButton2;
        private CCWin.SkinControl.SkinButton calcButton1;
        private CCWin.SkinControl.SkinButton calcButton6;
        private CCWin.SkinControl.SkinButton calcButton5;
        private CCWin.SkinControl.SkinButton calcButton4;
        private CCWin.SkinControl.SkinButton calcButton9;
        private CCWin.SkinControl.SkinButton calcButton8;
        private CCWin.SkinControl.SkinButton calcButton7;
        private CCWin.SkinControl.SkinButton calcButtonDelete;
        private CCWin.SkinControl.SkinButton calcButtonRBrack;
        private CCWin.SkinControl.SkinButton calcButtonLBrack;
        private CCWin.SkinControl.SkinTextBox calcTextBox;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
        private CCWin.SkinControl.SkinTextBox DisGradeBox;
        private ToolStripMenuItem 开始ToolStripMenuItem;
        private FolderBrowserDialog GradeFolderDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private CCWin.SkinControl.SkinLabel lastCalcBox;
        private ToolStripMenuItem 更改路径ToolStripMenuItem;
        private ToolStripMenuItem 更改生成Gradetxt文件路径ToolStripMenuItem;
        private ToolStripMenuItem 更改生成Exercisetxt文件路径ToolStripMenuItem;
        private ToolStripMenuItem 更改生成Answertxt文件路径ToolStripMenuItem;
        private ToolStripMenuItem 导入配置设置ToolStripMenuItem;
        private ToolStripMenuItem 设置配置ToolStripMenuItem;
        private ToolStripMenuItem 语言ToolStripMenuItem;
        private ToolStripMenuItem 中文ToolStripMenuItem;
        private ToolStripMenuItem 한국어ToolStripMenuItem;
        private Panel panel1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton GenButton;
        private CCWin.SkinControl.SkinTextBox ExeAnsTextBox;
        private CCWin.SkinControl.SkinProgressIndicator GenProgressIndicator;
        private Panel panel2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
   
}

