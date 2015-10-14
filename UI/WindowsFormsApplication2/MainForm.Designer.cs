

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
            this.PanelGen = new System.Windows.Forms.Panel();
            this.PanelRandom = new System.Windows.Forms.Panel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
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
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GradeFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GenProgressIndicator = new CCWin.SkinControl.SkinProgressIndicator();
            this.ExeAnsTextBox = new CCWin.SkinControl.SkinTextBox();
            this.GenButton = new CCWin.SkinControl.SkinButton();
            this.abortButton = new CCWin.SkinControl.SkinButton();
            this.tabPageCheck.SuspendLayout();
            this.tabPageGen.SuspendLayout();
            this.GenPage.SuspendLayout();
            this.PanelGen.SuspendLayout();
            this.PanelRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.PageSet.SuspendLayout();
            this.tabPageCalc.SuspendLayout();
            this.skinMenuStrip1.SuspendLayout();
            this.ExeAnsTextBox.SuspendLayout();
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
            resources.ApplyResources(this.tabPageCheck, "tabPageCheck");
            this.tabPageCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCheck.Controls.Add(this.DisGradeBox);
            this.tabPageCheck.Controls.Add(this.ExeText);
            this.tabPageCheck.Controls.Add(this.AnswerText);
            this.tabPageCheck.Controls.Add(this.skinButton1);
            this.tabPageCheck.Controls.Add(this.ExeButton);
            this.tabPageCheck.Controls.Add(this.AnswerButton);
            this.tabPageCheck.Name = "tabPageCheck";
            this.skinToolTip1.SetToolTip(this.tabPageCheck, resources.GetString("tabPageCheck.ToolTip"));
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // DisGradeBox
            // 
            resources.ApplyResources(this.DisGradeBox, "DisGradeBox");
            this.DisGradeBox.BackColor = System.Drawing.Color.Transparent;
            this.DisGradeBox.DownBack = null;
            this.DisGradeBox.Icon = null;
            this.DisGradeBox.IconIsButton = false;
            this.DisGradeBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.DisGradeBox.IsPasswordChat = '\0';
            this.DisGradeBox.IsSystemPasswordChar = false;
            this.DisGradeBox.Lines = new string[0];
            this.DisGradeBox.MaxLength = 32767;
            this.DisGradeBox.MouseBack = null;
            this.DisGradeBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.DisGradeBox.Multiline = true;
            this.DisGradeBox.Name = "DisGradeBox";
            this.DisGradeBox.NormlBack = null;
            this.DisGradeBox.ReadOnly = false;
            this.DisGradeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // 
            // 
            this.DisGradeBox.SkinTxt.AccessibleDescription = resources.GetString("DisGradeBox.SkinTxt.AccessibleDescription");
            this.DisGradeBox.SkinTxt.AccessibleName = resources.GetString("DisGradeBox.SkinTxt.AccessibleName");
            this.DisGradeBox.SkinTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DisGradeBox.SkinTxt.Anchor")));
            this.DisGradeBox.SkinTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisGradeBox.SkinTxt.BackgroundImage")));
            this.DisGradeBox.SkinTxt.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("DisGradeBox.SkinTxt.BackgroundImageLayout")));
            this.DisGradeBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisGradeBox.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("DisGradeBox.SkinTxt.Dock")));
            this.DisGradeBox.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("DisGradeBox.SkinTxt.Font")));
            this.DisGradeBox.SkinTxt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DisGradeBox.SkinTxt.ImeMode")));
            this.DisGradeBox.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("DisGradeBox.SkinTxt.Location")));
            this.DisGradeBox.SkinTxt.MaximumSize = ((System.Drawing.Size)(resources.GetObject("DisGradeBox.SkinTxt.MaximumSize")));
            this.DisGradeBox.SkinTxt.MaxLength = ((int)(resources.GetObject("DisGradeBox.SkinTxt.MaxLength")));
            this.DisGradeBox.SkinTxt.Multiline = ((bool)(resources.GetObject("DisGradeBox.SkinTxt.Multiline")));
            this.DisGradeBox.SkinTxt.Name = "BaseText";
            this.DisGradeBox.SkinTxt.PasswordChar = ((char)(resources.GetObject("DisGradeBox.SkinTxt.PasswordChar")));
            this.DisGradeBox.SkinTxt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("DisGradeBox.SkinTxt.RightToLeft")));
            this.DisGradeBox.SkinTxt.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("DisGradeBox.SkinTxt.ScrollBars")));
            this.DisGradeBox.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("DisGradeBox.SkinTxt.Size")));
            this.DisGradeBox.SkinTxt.TabIndex = ((int)(resources.GetObject("DisGradeBox.SkinTxt.TabIndex")));
            this.DisGradeBox.SkinTxt.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("DisGradeBox.SkinTxt.TextAlign")));
            this.DisGradeBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DisGradeBox.SkinTxt.WaterText = "";
            this.DisGradeBox.SkinTxt.WordWrap = ((bool)(resources.GetObject("DisGradeBox.SkinTxt.WordWrap")));
            this.DisGradeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinToolTip1.SetToolTip(this.DisGradeBox, resources.GetString("DisGradeBox.ToolTip"));
            this.DisGradeBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DisGradeBox.WaterText = "";
            this.DisGradeBox.WordWrap = true;
            // 
            // ExeText
            // 
            resources.ApplyResources(this.ExeText, "ExeText");
            this.ExeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ExeText.Name = "ExeText";
            this.ExeText.ReadOnly = true;
            this.skinToolTip1.SetToolTip(this.ExeText, resources.GetString("ExeText.ToolTip"));
            // 
            // AnswerText
            // 
            resources.ApplyResources(this.AnswerText, "AnswerText");
            this.AnswerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.ReadOnly = true;
            this.skinToolTip1.SetToolTip(this.AnswerText, resources.GetString("AnswerText.ToolTip"));
            // 
            // skinButton1
            // 
            resources.ApplyResources(this.skinButton1, "skinButton1");
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.OrangeRed;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.skinButton1, resources.GetString("skinButton1.ToolTip"));
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click_1);
            // 
            // ExeButton
            // 
            resources.ApplyResources(this.ExeButton, "ExeButton");
            this.ExeButton.BackColor = System.Drawing.Color.Transparent;
            this.ExeButton.BaseColor = System.Drawing.Color.OrangeRed;
            this.ExeButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.ExeButton.DownBack = null;
            this.ExeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExeButton.MouseBack = null;
            this.ExeButton.Name = "ExeButton";
            this.ExeButton.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.ExeButton, resources.GetString("ExeButton.ToolTip"));
            this.ExeButton.UseVisualStyleBackColor = false;
            this.ExeButton.Click += new System.EventHandler(this.ExeButton_Click);
            // 
            // AnswerButton
            // 
            resources.ApplyResources(this.AnswerButton, "AnswerButton");
            this.AnswerButton.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.BaseColor = System.Drawing.Color.OrangeRed;
            this.AnswerButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AnswerButton.DownBack = null;
            this.AnswerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerButton.MouseBack = null;
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.AnswerButton, resources.GetString("AnswerButton.ToolTip"));
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // tabPageGen
            // 
            resources.ApplyResources(this.tabPageGen, "tabPageGen");
            this.tabPageGen.Controls.Add(this.GenPage);
            this.tabPageGen.Name = "tabPageGen";
            this.skinToolTip1.SetToolTip(this.tabPageGen, resources.GetString("tabPageGen.ToolTip"));
            this.tabPageGen.UseVisualStyleBackColor = true;
            // 
            // GenPage
            // 
            resources.ApplyResources(this.GenPage, "GenPage");
            this.GenPage.BackColor = System.Drawing.Color.Transparent;
            this.GenPage.Controls.Add(this.PanelGen);
            this.GenPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.GenPage.DownBack = null;
            this.GenPage.MouseBack = null;
            this.GenPage.Name = "GenPage";
            this.GenPage.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.GenPage, resources.GetString("GenPage.ToolTip"));
            // 
            // PanelGen
            // 
            resources.ApplyResources(this.PanelGen, "PanelGen");
            this.PanelGen.Controls.Add(this.ExeAnsTextBox);
            this.PanelGen.Controls.Add(this.GenButton);
            this.PanelGen.Controls.Add(this.abortButton);
            this.PanelGen.Controls.Add(this.PanelRandom);
            this.PanelGen.Name = "PanelGen";
            this.skinToolTip1.SetToolTip(this.PanelGen, resources.GetString("PanelGen.ToolTip"));
            // 
            // PanelRandom
            // 
            resources.ApplyResources(this.PanelRandom, "PanelRandom");
            this.PanelRandom.Controls.Add(this.skinLabel2);
            this.PanelRandom.Controls.Add(this.skinButton4);
            this.PanelRandom.Controls.Add(this.skinButton3);
            this.PanelRandom.Controls.Add(this.skinPictureBox1);
            this.PanelRandom.Controls.Add(this.skinTextBox1);
            this.PanelRandom.Controls.Add(this.skinLabel1);
            this.PanelRandom.Name = "PanelRandom";
            this.skinToolTip1.SetToolTip(this.PanelRandom, resources.GetString("PanelRandom.ToolTip"));
            // 
            // skinLabel2
            // 
            resources.ApplyResources(this.skinLabel2, "skinLabel2");
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Name = "skinLabel2";
            this.skinToolTip1.SetToolTip(this.skinLabel2, resources.GetString("skinLabel2.ToolTip"));
            // 
            // skinButton4
            // 
            resources.ApplyResources(this.skinButton4, "skinButton4");
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.skinButton4, resources.GetString("skinButton4.ToolTip"));
            this.skinButton4.UseVisualStyleBackColor = false;
            // 
            // skinButton3
            // 
            resources.ApplyResources(this.skinButton3, "skinButton3");
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.skinButton3, resources.GetString("skinButton3.ToolTip"));
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // skinPictureBox1
            // 
            resources.ApplyResources(this.skinPictureBox1, "skinPictureBox1");
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.success;
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.TabStop = false;
            this.skinToolTip1.SetToolTip(this.skinPictureBox1, resources.GetString("skinPictureBox1.ToolTip"));
            // 
            // skinTextBox1
            // 
            resources.ApplyResources(this.skinTextBox1, "skinTextBox1");
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "skinTextBox1"};
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.AccessibleDescription = resources.GetString("skinTextBox1.SkinTxt.AccessibleDescription");
            this.skinTextBox1.SkinTxt.AccessibleName = resources.GetString("skinTextBox1.SkinTxt.AccessibleName");
            this.skinTextBox1.SkinTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("skinTextBox1.SkinTxt.Anchor")));
            this.skinTextBox1.SkinTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTextBox1.SkinTxt.BackgroundImage")));
            this.skinTextBox1.SkinTxt.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("skinTextBox1.SkinTxt.BackgroundImageLayout")));
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("skinTextBox1.SkinTxt.Dock")));
            this.skinTextBox1.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("skinTextBox1.SkinTxt.Font")));
            this.skinTextBox1.SkinTxt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("skinTextBox1.SkinTxt.ImeMode")));
            this.skinTextBox1.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("skinTextBox1.SkinTxt.Location")));
            this.skinTextBox1.SkinTxt.MaximumSize = ((System.Drawing.Size)(resources.GetObject("skinTextBox1.SkinTxt.MaximumSize")));
            this.skinTextBox1.SkinTxt.MaxLength = ((int)(resources.GetObject("skinTextBox1.SkinTxt.MaxLength")));
            this.skinTextBox1.SkinTxt.Multiline = ((bool)(resources.GetObject("skinTextBox1.SkinTxt.Multiline")));
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.PasswordChar = ((char)(resources.GetObject("skinTextBox1.SkinTxt.PasswordChar")));
            this.skinTextBox1.SkinTxt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("skinTextBox1.SkinTxt.RightToLeft")));
            this.skinTextBox1.SkinTxt.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("skinTextBox1.SkinTxt.ScrollBars")));
            this.skinTextBox1.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("skinTextBox1.SkinTxt.Size")));
            this.skinTextBox1.SkinTxt.TabIndex = ((int)(resources.GetObject("skinTextBox1.SkinTxt.TabIndex")));
            this.skinTextBox1.SkinTxt.Text = resources.GetString("skinTextBox1.SkinTxt.Text");
            this.skinTextBox1.SkinTxt.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("skinTextBox1.SkinTxt.TextAlign")));
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.SkinTxt.WordWrap = ((bool)(resources.GetObject("skinTextBox1.SkinTxt.WordWrap")));
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinToolTip1.SetToolTip(this.skinTextBox1, resources.GetString("skinTextBox1.ToolTip"));
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinLabel1
            // 
            resources.ApplyResources(this.skinLabel1, "skinLabel1");
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Name = "skinLabel1";
            this.skinToolTip1.SetToolTip(this.skinLabel1, resources.GetString("skinLabel1.ToolTip"));
            // 
            // PageSet
            // 
            resources.ApplyResources(this.PageSet, "PageSet");
            this.PageSet.Controls.Add(this.tabPageGen);
            this.PageSet.Controls.Add(this.tabPageCheck);
            this.PageSet.Controls.Add(this.tabPageCalc);
            this.PageSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PageSet.Name = "PageSet";
            this.PageSet.SelectedIndex = 0;
            this.skinToolTip1.SetToolTip(this.PageSet, resources.GetString("PageSet.ToolTip"));
            // 
            // tabPageCalc
            // 
            resources.ApplyResources(this.tabPageCalc, "tabPageCalc");
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
            this.tabPageCalc.Name = "tabPageCalc";
            this.skinToolTip1.SetToolTip(this.tabPageCalc, resources.GetString("tabPageCalc.ToolTip"));
            this.tabPageCalc.UseVisualStyleBackColor = true;
            // 
            // lastCalcBox
            // 
            resources.ApplyResources(this.lastCalcBox, "lastCalcBox");
            this.lastCalcBox.BackColor = System.Drawing.Color.Transparent;
            this.lastCalcBox.BorderColor = System.Drawing.Color.White;
            this.lastCalcBox.BorderSize = 0;
            this.lastCalcBox.Name = "lastCalcBox";
            this.skinToolTip1.SetToolTip(this.lastCalcBox, resources.GetString("lastCalcBox.ToolTip"));
            // 
            // rtfRichTextBox1
            // 
            resources.ApplyResources(this.rtfRichTextBox1, "rtfRichTextBox1");
            this.rtfRichTextBox1.BackColor = System.Drawing.Color.White;
            this.rtfRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRichTextBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.ReadOnly = true;
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.skinToolTip1.SetToolTip(this.rtfRichTextBox1, resources.GetString("rtfRichTextBox1.ToolTip"));
            // 
            // calcTextBox
            // 
            resources.ApplyResources(this.calcTextBox, "calcTextBox");
            this.calcTextBox.BackColor = System.Drawing.Color.Transparent;
            this.calcTextBox.DownBack = null;
            this.calcTextBox.Icon = null;
            this.calcTextBox.IconIsButton = false;
            this.calcTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.calcTextBox.IsPasswordChat = '\0';
            this.calcTextBox.IsSystemPasswordChar = false;
            this.calcTextBox.Lines = new string[0];
            this.calcTextBox.MaxLength = 32767;
            this.calcTextBox.MouseBack = null;
            this.calcTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.calcTextBox.Multiline = true;
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.NormlBack = null;
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // 
            // 
            this.calcTextBox.SkinTxt.AccessibleDescription = resources.GetString("calcTextBox.SkinTxt.AccessibleDescription");
            this.calcTextBox.SkinTxt.AccessibleName = resources.GetString("calcTextBox.SkinTxt.AccessibleName");
            this.calcTextBox.SkinTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("calcTextBox.SkinTxt.Anchor")));
            this.calcTextBox.SkinTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calcTextBox.SkinTxt.BackgroundImage")));
            this.calcTextBox.SkinTxt.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("calcTextBox.SkinTxt.BackgroundImageLayout")));
            this.calcTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcTextBox.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("calcTextBox.SkinTxt.Dock")));
            this.calcTextBox.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("calcTextBox.SkinTxt.Font")));
            this.calcTextBox.SkinTxt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("calcTextBox.SkinTxt.ImeMode")));
            this.calcTextBox.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("calcTextBox.SkinTxt.Location")));
            this.calcTextBox.SkinTxt.MaximumSize = ((System.Drawing.Size)(resources.GetObject("calcTextBox.SkinTxt.MaximumSize")));
            this.calcTextBox.SkinTxt.MaxLength = ((int)(resources.GetObject("calcTextBox.SkinTxt.MaxLength")));
            this.calcTextBox.SkinTxt.Multiline = ((bool)(resources.GetObject("calcTextBox.SkinTxt.Multiline")));
            this.calcTextBox.SkinTxt.Name = "BaseText";
            this.calcTextBox.SkinTxt.PasswordChar = ((char)(resources.GetObject("calcTextBox.SkinTxt.PasswordChar")));
            this.calcTextBox.SkinTxt.ReadOnly = true;
            this.calcTextBox.SkinTxt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("calcTextBox.SkinTxt.RightToLeft")));
            this.calcTextBox.SkinTxt.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("calcTextBox.SkinTxt.ScrollBars")));
            this.calcTextBox.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("calcTextBox.SkinTxt.Size")));
            this.calcTextBox.SkinTxt.TabIndex = ((int)(resources.GetObject("calcTextBox.SkinTxt.TabIndex")));
            this.calcTextBox.SkinTxt.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("calcTextBox.SkinTxt.TextAlign")));
            this.calcTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.calcTextBox.SkinTxt.WaterText = "";
            this.calcTextBox.SkinTxt.WordWrap = ((bool)(resources.GetObject("calcTextBox.SkinTxt.WordWrap")));
            this.calcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.skinToolTip1.SetToolTip(this.calcTextBox, resources.GetString("calcTextBox.ToolTip"));
            this.calcTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.calcTextBox.WaterText = "";
            this.calcTextBox.WordWrap = false;
            // 
            // calcButtonDelete
            // 
            resources.ApplyResources(this.calcButtonDelete, "calcButtonDelete");
            this.calcButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonDelete.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonDelete.DownBack = null;
            this.calcButtonDelete.MouseBack = null;
            this.calcButtonDelete.Name = "calcButtonDelete";
            this.calcButtonDelete.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonDelete, resources.GetString("calcButtonDelete.ToolTip"));
            this.calcButtonDelete.UseVisualStyleBackColor = false;
            this.calcButtonDelete.Click += new System.EventHandler(this.calcButtonDelete_Click);
            // 
            // calcButtonRBrack
            // 
            resources.ApplyResources(this.calcButtonRBrack, "calcButtonRBrack");
            this.calcButtonRBrack.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonRBrack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonRBrack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonRBrack.DownBack = null;
            this.calcButtonRBrack.MouseBack = null;
            this.calcButtonRBrack.Name = "calcButtonRBrack";
            this.calcButtonRBrack.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonRBrack, resources.GetString("calcButtonRBrack.ToolTip"));
            this.calcButtonRBrack.UseVisualStyleBackColor = false;
            this.calcButtonRBrack.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonLBrack
            // 
            resources.ApplyResources(this.calcButtonLBrack, "calcButtonLBrack");
            this.calcButtonLBrack.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonLBrack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonLBrack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonLBrack.DownBack = null;
            this.calcButtonLBrack.MouseBack = null;
            this.calcButtonLBrack.Name = "calcButtonLBrack";
            this.calcButtonLBrack.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonLBrack, resources.GetString("calcButtonLBrack.ToolTip"));
            this.calcButtonLBrack.UseVisualStyleBackColor = false;
            this.calcButtonLBrack.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonResult
            // 
            resources.ApplyResources(this.calcButtonResult, "calcButtonResult");
            this.calcButtonResult.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonResult.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonResult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonResult.DownBack = null;
            this.calcButtonResult.MouseBack = null;
            this.calcButtonResult.Name = "calcButtonResult";
            this.calcButtonResult.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonResult, resources.GetString("calcButtonResult.ToolTip"));
            this.calcButtonResult.UseVisualStyleBackColor = false;
            this.calcButtonResult.Click += new System.EventHandler(this.calcButtonResult_Click);
            // 
            // calcButtonClean
            // 
            resources.ApplyResources(this.calcButtonClean, "calcButtonClean");
            this.calcButtonClean.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonClean.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonClean.DownBack = null;
            this.calcButtonClean.MouseBack = null;
            this.calcButtonClean.Name = "calcButtonClean";
            this.calcButtonClean.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonClean, resources.GetString("calcButtonClean.ToolTip"));
            this.calcButtonClean.UseVisualStyleBackColor = false;
            this.calcButtonClean.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonSub
            // 
            resources.ApplyResources(this.calcButtonSub, "calcButtonSub");
            this.calcButtonSub.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonSub.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonSub.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonSub.DownBack = null;
            this.calcButtonSub.MouseBack = null;
            this.calcButtonSub.Name = "calcButtonSub";
            this.calcButtonSub.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonSub, resources.GetString("calcButtonSub.ToolTip"));
            this.calcButtonSub.UseVisualStyleBackColor = false;
            this.calcButtonSub.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonAdd
            // 
            resources.ApplyResources(this.calcButtonAdd, "calcButtonAdd");
            this.calcButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonAdd.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonAdd.DownBack = null;
            this.calcButtonAdd.MouseBack = null;
            this.calcButtonAdd.Name = "calcButtonAdd";
            this.calcButtonAdd.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonAdd, resources.GetString("calcButtonAdd.ToolTip"));
            this.calcButtonAdd.UseVisualStyleBackColor = false;
            this.calcButtonAdd.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonMult
            // 
            resources.ApplyResources(this.calcButtonMult, "calcButtonMult");
            this.calcButtonMult.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonMult.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonMult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonMult.DownBack = null;
            this.calcButtonMult.MouseBack = null;
            this.calcButtonMult.Name = "calcButtonMult";
            this.calcButtonMult.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonMult, resources.GetString("calcButtonMult.ToolTip"));
            this.calcButtonMult.UseVisualStyleBackColor = false;
            this.calcButtonMult.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonDiv
            // 
            resources.ApplyResources(this.calcButtonDiv, "calcButtonDiv");
            this.calcButtonDiv.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonDiv.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonDiv.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonDiv.DownBack = null;
            this.calcButtonDiv.MouseBack = null;
            this.calcButtonDiv.Name = "calcButtonDiv";
            this.calcButtonDiv.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonDiv, resources.GetString("calcButtonDiv.ToolTip"));
            this.calcButtonDiv.UseVisualStyleBackColor = false;
            this.calcButtonDiv.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonQuestion
            // 
            resources.ApplyResources(this.calcButtonQuestion, "calcButtonQuestion");
            this.calcButtonQuestion.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonQuestion.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonQuestion.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonQuestion.DownBack = null;
            this.calcButtonQuestion.MouseBack = null;
            this.calcButtonQuestion.Name = "calcButtonQuestion";
            this.calcButtonQuestion.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonQuestion, resources.GetString("calcButtonQuestion.ToolTip"));
            this.calcButtonQuestion.UseVisualStyleBackColor = false;
            this.calcButtonQuestion.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButtonQuote
            // 
            resources.ApplyResources(this.calcButtonQuote, "calcButtonQuote");
            this.calcButtonQuote.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonQuote.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonQuote.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonQuote.DownBack = null;
            this.calcButtonQuote.MouseBack = null;
            this.calcButtonQuote.Name = "calcButtonQuote";
            this.calcButtonQuote.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButtonQuote, resources.GetString("calcButtonQuote.ToolTip"));
            this.calcButtonQuote.UseVisualStyleBackColor = false;
            this.calcButtonQuote.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton0
            // 
            resources.ApplyResources(this.calcButton0, "calcButton0");
            this.calcButton0.BackColor = System.Drawing.Color.Transparent;
            this.calcButton0.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton0.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton0.DownBack = null;
            this.calcButton0.MouseBack = null;
            this.calcButton0.Name = "calcButton0";
            this.calcButton0.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton0, resources.GetString("calcButton0.ToolTip"));
            this.calcButton0.UseVisualStyleBackColor = false;
            this.calcButton0.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton3
            // 
            resources.ApplyResources(this.calcButton3, "calcButton3");
            this.calcButton3.BackColor = System.Drawing.Color.Transparent;
            this.calcButton3.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton3.DownBack = null;
            this.calcButton3.MouseBack = null;
            this.calcButton3.Name = "calcButton3";
            this.calcButton3.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton3, resources.GetString("calcButton3.ToolTip"));
            this.calcButton3.UseVisualStyleBackColor = false;
            this.calcButton3.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton2
            // 
            resources.ApplyResources(this.calcButton2, "calcButton2");
            this.calcButton2.BackColor = System.Drawing.Color.Transparent;
            this.calcButton2.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton2.DownBack = null;
            this.calcButton2.MouseBack = null;
            this.calcButton2.Name = "calcButton2";
            this.calcButton2.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton2, resources.GetString("calcButton2.ToolTip"));
            this.calcButton2.UseVisualStyleBackColor = false;
            this.calcButton2.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton1
            // 
            resources.ApplyResources(this.calcButton1, "calcButton1");
            this.calcButton1.BackColor = System.Drawing.Color.Transparent;
            this.calcButton1.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton1.DownBack = null;
            this.calcButton1.MouseBack = null;
            this.calcButton1.Name = "calcButton1";
            this.calcButton1.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton1, resources.GetString("calcButton1.ToolTip"));
            this.calcButton1.UseVisualStyleBackColor = false;
            this.calcButton1.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton6
            // 
            resources.ApplyResources(this.calcButton6, "calcButton6");
            this.calcButton6.BackColor = System.Drawing.Color.Transparent;
            this.calcButton6.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton6.DownBack = null;
            this.calcButton6.MouseBack = null;
            this.calcButton6.Name = "calcButton6";
            this.calcButton6.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton6, resources.GetString("calcButton6.ToolTip"));
            this.calcButton6.UseVisualStyleBackColor = false;
            this.calcButton6.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton5
            // 
            resources.ApplyResources(this.calcButton5, "calcButton5");
            this.calcButton5.BackColor = System.Drawing.Color.Transparent;
            this.calcButton5.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton5.DownBack = null;
            this.calcButton5.MouseBack = null;
            this.calcButton5.Name = "calcButton5";
            this.calcButton5.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton5, resources.GetString("calcButton5.ToolTip"));
            this.calcButton5.UseVisualStyleBackColor = false;
            this.calcButton5.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton4
            // 
            resources.ApplyResources(this.calcButton4, "calcButton4");
            this.calcButton4.BackColor = System.Drawing.Color.Transparent;
            this.calcButton4.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton4.DownBack = null;
            this.calcButton4.MouseBack = null;
            this.calcButton4.Name = "calcButton4";
            this.calcButton4.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton4, resources.GetString("calcButton4.ToolTip"));
            this.calcButton4.UseVisualStyleBackColor = false;
            this.calcButton4.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton9
            // 
            resources.ApplyResources(this.calcButton9, "calcButton9");
            this.calcButton9.BackColor = System.Drawing.Color.Transparent;
            this.calcButton9.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton9.DownBack = null;
            this.calcButton9.MouseBack = null;
            this.calcButton9.Name = "calcButton9";
            this.calcButton9.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton9, resources.GetString("calcButton9.ToolTip"));
            this.calcButton9.UseVisualStyleBackColor = false;
            this.calcButton9.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton8
            // 
            resources.ApplyResources(this.calcButton8, "calcButton8");
            this.calcButton8.BackColor = System.Drawing.Color.Transparent;
            this.calcButton8.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton8.DownBack = null;
            this.calcButton8.MouseBack = null;
            this.calcButton8.Name = "calcButton8";
            this.calcButton8.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton8, resources.GetString("calcButton8.ToolTip"));
            this.calcButton8.UseVisualStyleBackColor = false;
            this.calcButton8.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // calcButton7
            // 
            resources.ApplyResources(this.calcButton7, "calcButton7");
            this.calcButton7.BackColor = System.Drawing.Color.Transparent;
            this.calcButton7.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton7.DownBack = null;
            this.calcButton7.MouseBack = null;
            this.calcButton7.Name = "calcButton7";
            this.calcButton7.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.calcButton7, resources.GetString("calcButton7.ToolTip"));
            this.calcButton7.UseVisualStyleBackColor = false;
            this.calcButton7.Click += new System.EventHandler(this.ButtonBindings);
            // 
            // skinMenuStrip1
            // 
            resources.ApplyResources(this.skinMenuStrip1, "skinMenuStrip1");
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
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolTip1.SetToolTip(this.skinMenuStrip1, resources.GetString("skinMenuStrip1.ToolTip"));
            // 
            // 开始ToolStripMenuItem
            // 
            resources.ApplyResources(this.开始ToolStripMenuItem, "开始ToolStripMenuItem");
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改路径ToolStripMenuItem,
            this.导入配置设置ToolStripMenuItem,
            this.设置配置ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            // 
            // 更改路径ToolStripMenuItem
            // 
            resources.ApplyResources(this.更改路径ToolStripMenuItem, "更改路径ToolStripMenuItem");
            this.更改路径ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改生成Gradetxt文件路径ToolStripMenuItem,
            this.更改生成Exercisetxt文件路径ToolStripMenuItem,
            this.更改生成Answertxt文件路径ToolStripMenuItem});
            this.更改路径ToolStripMenuItem.Name = "更改路径ToolStripMenuItem";
            // 
            // 更改生成Gradetxt文件路径ToolStripMenuItem
            // 
            resources.ApplyResources(this.更改生成Gradetxt文件路径ToolStripMenuItem, "更改生成Gradetxt文件路径ToolStripMenuItem");
            this.更改生成Gradetxt文件路径ToolStripMenuItem.Name = "更改生成Gradetxt文件路径ToolStripMenuItem";
            this.更改生成Gradetxt文件路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Gradetxt生成路径ToolStripMenuItem_Click);
            // 
            // 更改生成Exercisetxt文件路径ToolStripMenuItem
            // 
            resources.ApplyResources(this.更改生成Exercisetxt文件路径ToolStripMenuItem, "更改生成Exercisetxt文件路径ToolStripMenuItem");
            this.更改生成Exercisetxt文件路径ToolStripMenuItem.Name = "更改生成Exercisetxt文件路径ToolStripMenuItem";
            this.更改生成Exercisetxt文件路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Exercisetxt生成路径ToolStripMenuItem_Click);
            // 
            // 更改生成Answertxt文件路径ToolStripMenuItem
            // 
            resources.ApplyResources(this.更改生成Answertxt文件路径ToolStripMenuItem, "更改生成Answertxt文件路径ToolStripMenuItem");
            this.更改生成Answertxt文件路径ToolStripMenuItem.Name = "更改生成Answertxt文件路径ToolStripMenuItem";
            this.更改生成Answertxt文件路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Answertxt生成路径ToolStripMenuItem_Click);
            // 
            // 导入配置设置ToolStripMenuItem
            // 
            resources.ApplyResources(this.导入配置设置ToolStripMenuItem, "导入配置设置ToolStripMenuItem");
            this.导入配置设置ToolStripMenuItem.Name = "导入配置设置ToolStripMenuItem";
            this.导入配置设置ToolStripMenuItem.Click += new System.EventHandler(this.导入配置设置ToolStripMenuItem_Click);
            // 
            // 设置配置ToolStripMenuItem
            // 
            resources.ApplyResources(this.设置配置ToolStripMenuItem, "设置配置ToolStripMenuItem");
            this.设置配置ToolStripMenuItem.Name = "设置配置ToolStripMenuItem";
            this.设置配置ToolStripMenuItem.Click += new System.EventHandler(this.设置配置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 语言ToolStripMenuItem
            // 
            resources.ApplyResources(this.语言ToolStripMenuItem, "语言ToolStripMenuItem");
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            // 
            // 中文ToolStripMenuItem
            // 
            resources.ApplyResources(this.中文ToolStripMenuItem, "中文ToolStripMenuItem");
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // GradeFolderDialog
            // 
            resources.ApplyResources(this.GradeFolderDialog, "GradeFolderDialog");
            // 
            // GenProgressIndicator
            // 
            resources.ApplyResources(this.GenProgressIndicator, "GenProgressIndicator");
            this.GenProgressIndicator.BackColor = System.Drawing.Color.Transparent;
            this.GenProgressIndicator.CircleColor = System.Drawing.Color.LightSkyBlue;
            this.GenProgressIndicator.Name = "GenProgressIndicator";
            this.GenProgressIndicator.Percentage = 0F;
            this.skinToolTip1.SetToolTip(this.GenProgressIndicator, resources.GetString("GenProgressIndicator.ToolTip"));
            // 
            // ExeAnsTextBox
            // 
            resources.ApplyResources(this.ExeAnsTextBox, "ExeAnsTextBox");
            this.ExeAnsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ExeAnsTextBox.Controls.Add(this.GenProgressIndicator);
            this.ExeAnsTextBox.DownBack = null;
            this.ExeAnsTextBox.Icon = null;
            this.ExeAnsTextBox.IconIsButton = false;
            this.ExeAnsTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ExeAnsTextBox.IsPasswordChat = '\0';
            this.ExeAnsTextBox.IsSystemPasswordChar = false;
            this.ExeAnsTextBox.Lines = new string[0];
            this.ExeAnsTextBox.MaxLength = 32767;
            this.ExeAnsTextBox.MouseBack = null;
            this.ExeAnsTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ExeAnsTextBox.Multiline = true;
            this.ExeAnsTextBox.Name = "ExeAnsTextBox";
            this.ExeAnsTextBox.NormlBack = null;
            this.ExeAnsTextBox.ReadOnly = true;
            this.ExeAnsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // 
            // 
            this.ExeAnsTextBox.SkinTxt.AccessibleDescription = resources.GetString("ExeAnsTextBox.SkinTxt.AccessibleDescription");
            this.ExeAnsTextBox.SkinTxt.AccessibleName = resources.GetString("ExeAnsTextBox.SkinTxt.AccessibleName");
            this.ExeAnsTextBox.SkinTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ExeAnsTextBox.SkinTxt.Anchor")));
            this.ExeAnsTextBox.SkinTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExeAnsTextBox.SkinTxt.BackgroundImage")));
            this.ExeAnsTextBox.SkinTxt.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("ExeAnsTextBox.SkinTxt.BackgroundImageLayout")));
            this.ExeAnsTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExeAnsTextBox.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ExeAnsTextBox.SkinTxt.Dock")));
            this.ExeAnsTextBox.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("ExeAnsTextBox.SkinTxt.Font")));
            this.ExeAnsTextBox.SkinTxt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ExeAnsTextBox.SkinTxt.ImeMode")));
            this.ExeAnsTextBox.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("ExeAnsTextBox.SkinTxt.Location")));
            this.ExeAnsTextBox.SkinTxt.MaximumSize = ((System.Drawing.Size)(resources.GetObject("ExeAnsTextBox.SkinTxt.MaximumSize")));
            this.ExeAnsTextBox.SkinTxt.MaxLength = ((int)(resources.GetObject("ExeAnsTextBox.SkinTxt.MaxLength")));
            this.ExeAnsTextBox.SkinTxt.Multiline = ((bool)(resources.GetObject("ExeAnsTextBox.SkinTxt.Multiline")));
            this.ExeAnsTextBox.SkinTxt.Name = "BaseText";
            this.ExeAnsTextBox.SkinTxt.PasswordChar = ((char)(resources.GetObject("ExeAnsTextBox.SkinTxt.PasswordChar")));
            this.ExeAnsTextBox.SkinTxt.ReadOnly = true;
            this.ExeAnsTextBox.SkinTxt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ExeAnsTextBox.SkinTxt.RightToLeft")));
            this.ExeAnsTextBox.SkinTxt.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("ExeAnsTextBox.SkinTxt.ScrollBars")));
            this.ExeAnsTextBox.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("ExeAnsTextBox.SkinTxt.Size")));
            this.ExeAnsTextBox.SkinTxt.TabIndex = ((int)(resources.GetObject("ExeAnsTextBox.SkinTxt.TabIndex")));
            this.ExeAnsTextBox.SkinTxt.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("ExeAnsTextBox.SkinTxt.TextAlign")));
            this.ExeAnsTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ExeAnsTextBox.SkinTxt.WaterText = "";
            this.ExeAnsTextBox.SkinTxt.WordWrap = ((bool)(resources.GetObject("ExeAnsTextBox.SkinTxt.WordWrap")));
            this.ExeAnsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinToolTip1.SetToolTip(this.ExeAnsTextBox, resources.GetString("ExeAnsTextBox.ToolTip"));
            this.ExeAnsTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ExeAnsTextBox.WaterText = "";
            this.ExeAnsTextBox.WordWrap = true;
            // 
            // GenButton
            // 
            resources.ApplyResources(this.GenButton, "GenButton");
            this.GenButton.BackColor = System.Drawing.Color.Transparent;
            this.GenButton.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.GenButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.GenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenButton.DownBack = null;
            this.GenButton.ForeColor = System.Drawing.Color.Teal;
            this.GenButton.MouseBack = null;
            this.GenButton.Name = "GenButton";
            this.GenButton.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.GenButton, resources.GetString("GenButton.ToolTip"));
            this.GenButton.UseVisualStyleBackColor = false;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // abortButton
            // 
            resources.ApplyResources(this.abortButton, "abortButton");
            this.abortButton.BackColor = System.Drawing.Color.Transparent;
            this.abortButton.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.abortButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.abortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abortButton.DownBack = null;
            this.abortButton.ForeColor = System.Drawing.Color.Teal;
            this.abortButton.MouseBack = null;
            this.abortButton.Name = "abortButton";
            this.abortButton.NormlBack = null;
            this.skinToolTip1.SetToolTip(this.abortButton, resources.GetString("abortButton.ToolTip"));
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.skinMenuStrip1);
            this.Controls.Add(this.PageSet);
            this.KeyPreview = true;
            this.MainMenuStrip = this.skinMenuStrip1;
            this.Name = "MainForm";
            this.skinToolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabPageCheck.ResumeLayout(false);
            this.tabPageCheck.PerformLayout();
            this.tabPageGen.ResumeLayout(false);
            this.GenPage.ResumeLayout(false);
            this.PanelGen.ResumeLayout(false);
            this.PanelRandom.ResumeLayout(false);
            this.PanelRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.PageSet.ResumeLayout(false);
            this.tabPageCalc.ResumeLayout(false);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ExeAnsTextBox.ResumeLayout(false);
            this.ExeAnsTextBox.PerformLayout();
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
        private Panel PanelGen;
        private Panel PanelRandom;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private ToolStripMenuItem englishToolStripMenuItem;
        private CCWin.SkinControl.SkinTextBox ExeAnsTextBox;
        private CCWin.SkinControl.SkinProgressIndicator GenProgressIndicator;
        private CCWin.SkinControl.SkinButton GenButton;
        private CCWin.SkinControl.SkinButton abortButton;
    }
   
}

