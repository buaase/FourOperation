using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using CCWin;
using WindowsFormsApplication2.Calc;
using System.Xml;
using Core;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class MainForm : CCSkinMain
    {
        Thread td;
        //默认的检查结果文件路径

        public delegate void InvokeCall();

        public MainForm()
        {
            //如果两个文件同时存在，代表已经使用过一次。
            if(File.Exists("remember.xml") &&　File.Exists("configure.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("remember.xml");
                XmlElement rootElem = doc.DocumentElement;
                if(rootElem.InnerText=="No")
                    InitialXmlFile();
            }
            //如果两个文件缺少一个，不管是缺少remember还是configure，都属于第一次使用。
            else
            {
                InitialXmlFile();
                if (File.Exists("remember.xml"))
                    File.Delete("remember.xml");
            }
            InitializeComponent();
        }

        //根据parentNode和name,value创建子结点
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }

        //打开题目文件，并且判断文件后缀是否为txt文件，如果不是txt文件，则抛出异常。
        private void ExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog Dialog = new OpenFileDialog();
                DialogResult result = Dialog.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Yes))
                {
                    path = Dialog.FileName;
                    if (!path.EndsWith(".txt"))
                        throw new FileNotFoundException("文件后缀不正确，请重新打开！");
                    ExeText.Text = path;
                }
            }
            catch (Exception e1)
            {
                ErrorForm error = new ErrorForm(e1.Message);
                error.ShowDialog();//show Dialog指定只能关闭本模块后才可以关闭其他
            }
        }

        //打开答案文件，并且判断文件后缀是否为txt文件，如果不是txt文件，则抛出异常。
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog Dialog = new OpenFileDialog();
                DialogResult result = Dialog.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Yes))
                {
                    path = Dialog.FileName;
                    if (!path.EndsWith(".txt"))
                        throw new FileNotFoundException("文件后缀不正确，请重新打开！");
                    AnswerText.Text = path;
                }
            }
            catch (Exception e1)
            {
                ErrorForm error = new ErrorForm(e1.Message);
                error.ShowDialog();//show Dialog指定只能关闭本模块后才可以关闭其他
            }

        }

        public void Generate()
        {
            try
            {
                Configure con = new Configure(CoreMode.ExerciseMode);
                con.Calc();
            }
            catch (MyException.TooManyException e1)
            {
                ErrorForm form = new ErrorForm(e1.Message);
                form.ShowDialog();
            }
            finally
            {
                InvokeCall a = new InvokeCall(UpdateProgressBar);
                BeginInvoke(a);

            }
        }

        public void UpdateProgressBar()
        {
            GenProgressIndicator.Hide();
            ExeAnsTextBox.Text += "已经生成了" + ReadXml("//Count//FactCount") + "道题目与答案到指定的文件中." + Environment.NewLine;
            ExeAnsTextBox.Show();
        }

        #region(生成器核心调用处)
        private void skinButton1_Click(object sender, EventArgs e)
        {
            GenProgressIndicator.Show();
            GenProgressIndicator.Start();
            ExeAnsTextBox.Visible = false;
            //——————————————————-//
            // This is should be a generator ...      //
            //________________________________________//
            td = new Thread(Generate);
            td.Start();
        }
        #endregion

        //当 单击 菜单栏-> 关于 时弹出的关于作者的窗口
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMeForm aboutme = new AboutMeForm();
            aboutme.Show();
        }


        //这个模块用于小型计算器的快捷键映射与button_click事件的处理
        #region(小型计算器键盘映射)
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (PageSet.SelectedTab == tabPageCalc)
            {

                //组合键放在前面确保优先级

                //左括号
                if (e.KeyCode == Keys.D9 & e.Shift)
                    ButtonBindings(calcButtonLBrack, null);
                //右括号
                else if (e.KeyCode == Keys.D0 & e.Shift)
                    ButtonBindings(calcButtonRBrack, null);
                //组合键 加法
                else if (e.KeyCode == Keys.Oemplus & e.Shift)
                    ButtonBindings(calcButtonAdd, null);
                //减法
                else if (e.KeyCode == Keys.OemMinus)
                    ButtonBindings(calcButtonSub, null);
                //组合键 乘法
                else if (e.KeyCode == Keys.D8 & e.Shift)
                    ButtonBindings(calcButtonMult, null);
                //自定义组合键 OemQuestion + shift = /
                else if (e.KeyCode == Keys.OemQuestion & e.Shift)
                    ButtonBindings(calcButtonDiv, null);
                //OemQuotes 对应的是键盘上的 单引号键
                else if (e.KeyCode == Keys.OemQuotes & e.Shift)
                    ButtonBindings(calcButtonQuote, null);
                //对应? 即 非shift下的/
                else if (e.KeyCode == Keys.OemQuestion)
                    ButtonBindings(calcButtonQuestion, null);
                else if (e.KeyCode == Keys.D0)
                    ButtonBindings(calcButton0, null);
                else if (e.KeyCode == Keys.D1)
                    ButtonBindings(calcButton1, null);
                else if (e.KeyCode == Keys.D2)
                    ButtonBindings(calcButton2, null);
                else if (e.KeyCode == Keys.D3)
                    ButtonBindings(calcButton3, null);
                else if (e.KeyCode == Keys.D4)
                    ButtonBindings(calcButton4, null);
                else if (e.KeyCode == Keys.D5)
                    ButtonBindings(calcButton5, null);
                else if (e.KeyCode == Keys.D6)
                    ButtonBindings(calcButton6, null);
                else if (e.KeyCode == Keys.D7)
                    ButtonBindings(calcButton7, null);
                else if (e.KeyCode == Keys.D8)
                    ButtonBindings(calcButton8, null);
                else if (e.KeyCode == Keys.D9)
                    ButtonBindings(calcButton9, null);
                else if (e.KeyCode == Keys.Delete)
                    ButtonBindings(calcButtonClean, null);
                else if (e.KeyCode == Keys.Back)
                    calcButtonDelete_Click(null, null);
                else if (e.KeyCode == Keys.Enter)
                    calcButtonResult_Click(null, null);
                else
                    return;
            }

        }

        private void calcButtonDelete_Click(object sender, EventArgs e)
        {
            //这个键是后退键——用于删除一个刚刚出错的字符
            string text = calcTextBox.Text;
            char[] Temp = text.ToCharArray();
            text = "";
            //当前TextBox里的内容转换为一个char数组，剔除最后一个字符，并重新赋值到该textbox中
            for (int i = 0; i < Temp.Count() - 1; i++)
            {
                text += Temp[i];
            }
            calcTextBox.Text = text;
        }

        #region(计算器核心调用处)
        private void calcButtonResult_Click(object sender, EventArgs e)
        {
            //这里应该调用计算核心中的计算单个表达式的值，并显示在该TextBox中
            /////////////////////////////////////////
            // single calc expression              //
            /////////////////////////////////////////
            string Content = calcTextBox.Text;
            try
            {
                Configure con = new Configure(CoreMode.CalcuateMode);
                Content = con.Calc(calcTextBox.Text + "=");
                lastCalcBox.Text = calcTextBox.Text + " =";
            }
            catch (MyException.OwnException e1)
            {
                ErrorForm form = new ErrorForm(e1.Message);
                form.ShowDialog();
            }
            finally
            {
                calcTextBox.Text = Content;
            }
        }
        #endregion()


        private void ButtonBindings(object sender,EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "calcButtonRBrack":calcTextBox.Text += ")"; break;
                case "calcButtonLBrack":calcTextBox.Text += "("; break;
                case "calcButtonQuote": calcTextBox.Text += "'"; break;
                case "calcButtonQuestion": calcTextBox.Text += "/"; break;
                case "calcButtonSub":calcTextBox.Text += "-"; break;
                case "calcButtonAdd":calcTextBox.Text += "+"; break;
                case "calcButtonMult":calcTextBox.Text += "×"; break;
                case "calcButtonDiv":calcTextBox.Text += "÷"; break;
                case "calcButtonClean":calcTextBox.Text = ""; break;
                default:
                    Regex pattern = new Regex("calcButton(?<index>\\d)");
                    Match m = pattern.Match(((Button)sender).Name);
                    if (m.Success)
                        calcTextBox.Text += m.Groups["index"];
                    break;
            }
        }
        #endregion
        
        #region(检查器核心调用处)
        //这个按钮按下时，将触发检查事件，要根据AnswerText和ExeText获取文件路径
        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            try {
                string ExePath = ExeText.Text;
                string AnswerPath = AnswerText.Text;
                Configure con = new Configure(CoreMode.CheckMode);
                con.Calc(ExePath, AnswerPath);
                DisGradeBox.Text += "成绩已经生成到" + ReadXml("//Path//Grade") + Environment.NewLine;

            }
            catch (MyException.OwnException e1)
            {
                ErrorForm form = new ErrorForm(e1.Message);
                form.ShowDialog();
            }
        }
        #endregion


        //在组件成立时初始化xml文件
        //xml文件包括以下几个属性：
        //1、Range.第一个属性是左值域，第二个属性是右值域
        //2、Path.依次为ExePath,AnsPath,GradePath
        //3、Count.第一个属性为运算符的数量，第二个属性为操作数的数量
        //4、Option.依次为Brack,MultDiv,Frac,Negative
        public void InitialXmlFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明结点
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根结点
            XmlNode root = xmlDoc.CreateElement("User");
            xmlDoc.AppendChild(root);
            //创建Option结点
            XmlElement xeOp = xmlDoc.CreateElement("Option");
            root.AppendChild(xeOp);
            CreateNode(xmlDoc, xeOp, "BrackOp", "false");
            CreateNode(xmlDoc, xeOp, "MultDivOp", "false");
            CreateNode(xmlDoc, xeOp, "FracOp", "false");
            CreateNode(xmlDoc, xeOp, "NegOp", "false");

            XmlElement xeRange = xmlDoc.CreateElement("Range");
            root.AppendChild(xeRange);
            CreateNode(xmlDoc, xeRange, "leftRange", "0");
            CreateNode(xmlDoc, xeRange, "rightRange", "1");

            XmlElement xePath = xmlDoc.CreateElement("Path");
            root.AppendChild(xePath);
            CreateNode(xmlDoc, xePath, "Exe", "Exercise.txt");
            CreateNode(xmlDoc, xePath, "Ans", "Answer.txt");
            CreateNode(xmlDoc, xePath, "Grade", "Grade.txt");

            XmlElement xeCount = xmlDoc.CreateElement("Count");
            root.AppendChild(xeCount);
            CreateNode(xmlDoc, xeCount, "NumCount", "1");
            CreateNode(xmlDoc, xeCount, "OpCount", "1");
            CreateNode(xmlDoc, xeCount, "FactCount", "1");

            xmlDoc.Save("configure.xml");
        }

        //这个菜单栏的按钮使用时，会更改默认的.txt的生成路径
        private void 更改Gradetxt生成路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //加载指定的xml文件
            string Gradepath = "Grade.txt";
            DialogResult result = GradeFolderDialog.ShowDialog();
            if ((result == DialogResult.OK) || (result == DialogResult.Yes))
            {
                Gradepath = GradeFolderDialog.SelectedPath + "\\Grade.txt";
                ChangeXml("//Path//Grade", Gradepath);
                DisGradeBox.Text += "更改Grade.txt到路径" + Gradepath;
                DisGradeBox.Text += Environment.NewLine;
            }
        }

        private void 更改Exercisetxt生成路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Exepath = "";
            DialogResult result = GradeFolderDialog.ShowDialog();
            if ((result == DialogResult.OK) || (result == DialogResult.Yes))
            {
                Exepath = GradeFolderDialog.SelectedPath + "\\Exercise.txt";
                ChangeXml("//Path//Exe", Exepath);
                ExeAnsTextBox.Text += "更改Exercise.txt到路径" + Exepath;
                ExeAnsTextBox.Text += Environment.NewLine;
            }
        }

        private void 更改Answertxt生成路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Anspath = "";
            DialogResult result = GradeFolderDialog.ShowDialog();
            if ((result == DialogResult.OK) || (result == DialogResult.Yes))
            {
                Anspath = GradeFolderDialog.SelectedPath + "\\Answer.txt";
                ChangeXml("//Path//Exe", Anspath);
                ExeAnsTextBox.Text += "更改Answer.txt到路径" + Anspath;
                ExeAnsTextBox.Text += Environment.NewLine;
            }
        }

        //改变xml配置文件
        public string ChangeXml(string name, string NewValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("configure.xml");
            XmlElement rootElem = doc.DocumentElement;
            XmlNode node = doc.SelectSingleNode(name);
            XmlElement Exepath = (XmlElement)node;
            Exepath.InnerText = NewValue;
            doc.Save("configure.xml");
            return NewValue;
        }

        //读取结点的数据
        public string ReadXml(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("configure.xml");
            XmlElement rootElem = doc.DocumentElement;
            XmlNode node = doc.SelectSingleNode(name);
            XmlElement Exepath = (XmlElement)node;
            return Exepath.InnerText;
        }
        
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.ShowDialog();
        }

        //窗体关闭前询问是否需要自动导入上一次的配置文件
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //remember.xml
            //负责记录上一次的配置
            if (!File.Exists("remember.xml"))
            {
                RememberMe tips = new RememberMe();
                tips.ShowDialog();
            }
        }

        //如果不是第一次启动，需要手动去配置是否自动导入配置
        private void 导入配置设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RememberMe tips = new RememberMe();
            tips.ShowDialog();
        }

        private void 设置配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConfigureForm conf = new ConfigureForm();
            conf.ShowDialog();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            td.Abort();
        }
    }
}
