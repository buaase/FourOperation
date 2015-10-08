using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.MyException;
using System.IO;
using System.Text.RegularExpressions;
using WindowsFormsApplication2;

namespace WindowsFormsApplication2.Calc
{
    public class CheckAnswer
    {
        //从文件中读取到的答案
        private List<string> FileAnswer;
        private List<int> Correct;
        private List<int> Wrong;
        private string ExePath;
        private string AnswerPath;

        public CheckAnswer(string exepath,string answerpath)
        {
            FileAnswer = new List<string>();
            Correct = new List<int>();
            Wrong = new List<int>();
            this.ExePath = exepath;
            this.AnswerPath = answerpath;
        }

        public static string CheckAnswerIndex(string Answerline,int index)
        {
            #region(检查答案文件数字序号是否正确)
            string[] split = Answerline.Split(new string[] { "."}, StringSplitOptions.RemoveEmptyEntries);
            if (split[0]!=index.ToString())
                throw new OwnException("答案文件序号格式有误！在" + split[0] + "处序号出错！");
            //把空格都去掉之后的答案
            return split[1].Replace(" ","");
            #endregion
        }

        public static string CheckExeIndex(string Exeline,int index)
        {
            #region(检查题目文件数字序号是否正确)
            string[] split = Exeline.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            string Index = index.ToString();
            if (split[0]!=index.ToString())
                throw new OwnException("题目文件序号格式有误！在" + split[0] + "处序号出错！");
            return split[1];
            #endregion
        }

        public static void CheckAnswerValid(string Answer)
        {
            #region(检查答案格式的正确性)
            string Pat1 = "(-?\\d+'\\d+\\/\\d+)";
            string Pat2 = "(-?\\d+\\/\\d+)";
            string Pat3 = "(-?\\d+)";
            string Frac = "^(" + Pat1 + "|" + Pat2 + "|" + Pat3 + ")$";
            Regex pattern = new Regex(Frac);
            //将答案中的空格去掉后，与标准格式进行对比
            if (!pattern.IsMatch(Answer.Replace(" ", "")))
                throw new MyException.OwnException("答案文件中" + Answer + "格式不太对哦！");
            #endregion
        }

        //从答案文件中读取答案序列存入FileAnswer中。
        public void ReadAnswerFile()
        {
            //以Open的形式读取答案文件
            FileStream stream = new FileStream(AnswerPath, FileMode.Open);
            //以Unicode格式打开
            StreamReader sr = new StreamReader(stream, Encoding.Unicode);
            string line = "";
            int index = 1;
            while((line=sr.ReadLine())!=null)
            {
                //如果index符合格式，则不会抛出异常
                string answer = CheckAnswerIndex(line, index);
                //如果answer的表达式符合格式，则不会抛出异常
                CheckAnswerValid(answer);
                //如果是符合answer格式的表达式，则加入FileAnswer中
                FileAnswer.Add(answer);
                index++;
            }
        }

        //从题目文件中读入题目，计算答案并与之前已经获得的答案进行对比。
        public void ReadExerciseFile()
        {
            FileStream stream = new FileStream(ExePath, FileMode.Open);
            //以Unicode格式打开
            StreamReader sr = new StreamReader(stream, Encoding.Unicode);
            string line = "";
            int index = 1;
            while ((line = sr.ReadLine()) != null)
            {
                //获取题目表达式
                string Exercise = CheckExeIndex(line, index);
                //获取正确的答案
                string CorrectAnswer =new AnswerGet(Exercise).getAnswer();
                if (index > FileAnswer.Count())
                    throw new MyException.OwnException("没做完题还想来对答案，哼！你只做了"+FileAnswer.Count()+"道题呀！"); 
                //如果答案与当前序列的文件答案一致，则将序号记录入正确集
                if (CorrectAnswer == FileAnswer[index - 1])
                    Correct.Add(index);
                //如果答案与当前序列的文件答案不一致，则将序号记录入错误集
                else
                    Wrong.Add(index);
                index++;
            }
        }

        //将最终答案中的对错数量及其序号写入文件
        public void ToGradeFile(string GradePath)
        {
            FileStream file = new FileStream(GradePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.Unicode);
            sw.Write("Correct: {0} ", Correct.Count);
            if (Correct.Count != 0)
            {
                sw.Write("(");
                for (int k = 0; k < Correct.Count; k++)
                {
                    if (k == 0)
                        sw.Write(Correct[k]);
                    else
                    {
                        sw.Write(",");
                        sw.Write(Correct[k]);
                    }
                }
                sw.Write(")");
            }
            sw.Write(Environment.NewLine);
            sw.Write("Wrong: {0} ", Wrong.Count);
            if (Wrong.Count != 0)
            {
                sw.Write("(");
                for (int k = 0; k < Wrong.Count; k++)
                {
                    if (k == 0)
                        sw.Write(Wrong[k]);
                    else
                    {
                        sw.Write(",");
                        sw.Write(Wrong[k]);
                    }
                }
                sw.Write(")");
            }
            sw.Flush();
            sw.Close();
        }

        public static void Grade(string Exepath, string Answerpath,string Gradepath)
        {
            CheckAnswer check = new CheckAnswer(Exepath,Answerpath);
            check.ReadAnswerFile();
            check.ReadExerciseFile();
            check.ToGradeFile(Gradepath);
        }
    }
}
