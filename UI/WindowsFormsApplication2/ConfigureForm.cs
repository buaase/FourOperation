using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CCWin;

namespace WindowsFormsApplication2
{
    public partial class ConfigureForm : CCSkinMain
    {

        XmlDocument doc = new XmlDocument();
        public ConfigureForm()
        {
            InitializeComponent();
            XmlToForm();
        }
        private void leftRange_ValueChanged(object sender, EventArgs e)
        {
            MaxRangeUpAndDown.Minimum = MinRangeUpAndDown.Value + 1;
        }
        public string ChangeXml(string name, string NewValue)
        {
            XmlElement rootElem = doc.DocumentElement;
            XmlNode node = doc.SelectSingleNode(name);
            XmlElement Exepath = (XmlElement)node;
            Exepath.InnerText = NewValue;
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
        //根据xml文件配置一下配置窗口
        private void XmlToForm()
        {
            ReadOptionToForm("BrackOp", HasBrackCheck);
            ReadOptionToForm("NegOp",HasNegCheck);
            ReadOptionToForm("MultDivOp",HasMultDivCheck);
            ReadOptionToForm("FracOp",HasFracCheck);
            ReadUpAndDownToForm("//Range//rightRange", MaxRangeUpAndDown);
            ReadUpAndDownToForm("//Range//leftRange", MinRangeUpAndDown);
            ReadUpAndDownToForm("//Count//OpCount", OpCountUpAndDown);
            ReadUpAndDownToForm("//Count//NumCount", ExeCountUpAndDown);

        }

        private void ReadOptionToForm(string name,CheckBox checkbox)
        {
            string checkstate = ReadXml("//Option//"+name);
            if (checkstate == "true")
                checkbox.CheckState = CheckState.Checked;
            else
                checkbox.CheckState = CheckState.Unchecked;
        }

        private void ReadUpAndDownToForm(string name,NumericUpDown numeric)
        {
            string text = ReadXml(name);
            numeric.Value = int.Parse(text);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            doc.Load("configure.xml");
            ChangeXml("//Range//rightRange", MaxRangeUpAndDown.Value.ToString());
            ChangeXml("//Count//NumCount", ExeCountUpAndDown.Value.ToString());
            ChangeXml("//Count//OpCount", OpCountUpAndDown.Value.ToString());
            ChangeXml("//Range//leftRange", MinRangeUpAndDown.Value.ToString());
            if (HasNegCheck.CheckState == CheckState.Checked)
                ChangeXml("//Option//NegOp", "true");
            else
                ChangeXml("//Option//NegOp", "false");
            if (HasFracCheck.CheckState == CheckState.Checked)
                ChangeXml("//Option//FracOp", "true");
            else
                ChangeXml("//Option//FracOp", "false");
            if (HasMultDivCheck.CheckState == CheckState.Checked)
                ChangeXml("//Option//MultDivOp", "true");
            else
                ChangeXml("//Option//MultDivOp", "false");
            if (HasBrackCheck.CheckState == CheckState.Checked)
                ChangeXml("//Option//BrackOp", "true");
            else
                ChangeXml("//Option//BrackOp", "false");
            if (HasBrackCheck.CheckState == CheckState.Checked)
                ChangeXml("//Option//BrackOp", "true");
            else
                ChangeXml("//Option//BrackOp", "false");
            doc.Save("configure.xml");
            this.Dispose();
        }
    }
}
