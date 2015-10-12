using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Xml;

namespace WindowsFormsApplication2
{
    public partial class RememberMe : CCSkinMain
    {
        public RememberMe()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明结点
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            XmlNode root = xmlDoc.CreateElement("User");
            root.InnerText = (YesRadioButton.Checked ==true)? "Yes":"No";
            xmlDoc.AppendChild(root);
            //保存到remember.xml文件中
            xmlDoc.Save("remember.xml");
            this.Close();
        }

    }
}
