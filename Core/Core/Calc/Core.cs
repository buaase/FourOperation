using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WindowsFormsApplication2.Calc;

namespace Core
{
    public class Configure
    {
        CoreMode Mode;
        public Configure(CoreMode mode)
        {
            this.Mode = mode;
        }

        public string Calc(string exePath="",string answerPath="")
        {
            int factcount = 1;
            if (Mode == CoreMode.CheckMode)
            {
                string GradePath = ReadXml("//Path//Grade");
                CheckAnswer.Grade(exePath, answerPath, GradePath);
            }
            else if(Mode==CoreMode.ExerciseMode)
            {
                try {
                    bool HasNeg = ReadOption("//Option//NegOp");
                    bool HasMultDiv = ReadOption("//Option//MultDivOp");
                    bool HasBrack = ReadOption("//Option//BrackOp");
                    bool HasFrac = ReadOption("//Option//FracOp");
                    int OpCount = ReadCount("//Count//OpCount");
                    int ExeCount = ReadCount("//Count//NumCount");
                    int leftRange = ReadCount("//Range//leftRange");
                    int rightRange = ReadCount("//Range//rightRange");
                    //这俩路径是要在配置文件里指定的
                    string ExePath = ReadXml("//Path//Exe");
                    string AnswerPath = ReadXml("//Path//Ans");
                     factcount = 0;
                    new GenerateExp(
                     HasNeg,
                     HasMultDiv,
                     HasBrack,
                     HasFrac,
                     OpCount,
                     ExeCount,
                     leftRange,
                     rightRange,
                     ExePath,
                     AnswerPath,
                     ref factcount
                     );

                }
                finally
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("configure.xml");
                    XmlElement rootElem = doc.DocumentElement;
                    XmlNode node = doc.SelectSingleNode("//Count//FactCount");
                    XmlElement Exepath = (XmlElement)node;
                    Exepath.InnerText = factcount.ToString();
                    doc.Save("configure.xml");
                }
            }
            else
            {
                //利用第一个参数...为表达式的题目
                return new AnswerGet(exePath + " =").getAnswer();
            }
            return "";
        }
        

        //从配置的xml文件中读取出有关的描述
        public string ReadXml(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("configure.xml");
            XmlElement rootElem = doc.DocumentElement;
            XmlNode node = doc.SelectSingleNode(name);
            XmlElement Exepath = (XmlElement)node;
            return Exepath.InnerText;
        }

        public bool ReadOption(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("configure.xml");
            XmlElement rootElem = doc.DocumentElement;
            XmlNode node = doc.SelectSingleNode(name);
            XmlElement Exepath = (XmlElement)node;
            if (Exepath.InnerText == "true")
                return true;
            else
                return false;
        }

        public int ReadCount(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("configure.xml");
            XmlElement rootElem = doc.DocumentElement;
            XmlNode node = doc.SelectSingleNode(name);
            XmlElement Exepath = (XmlElement)node;
            return int.Parse(Exepath.InnerText);
        }

    }
    public enum CoreMode { CheckMode,ExerciseMode,CalcuateMode}
}
