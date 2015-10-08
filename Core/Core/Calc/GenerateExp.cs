using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Calc
{
    public class GenerateExp
    {
        public static long GetLongRandom(long min,long max,Random random)
        {
            return (long)(random.NextDouble() * (max - min) + min);
        }

        //生成表达式
        public GenerateExp(
            bool hasNegative/*负数*/,
            bool hasMultDiv/*乘除法*/,
            bool hasBrack/*括号*/,
            bool hasFrac/*分数*/,
            int opCount/*运算符个数上限*/,
            int exerciseCount/*数量上限*/,
            int leftRange/*左值域*/,
            int rightRange/*右值域*/,
            string ExePath,
            string AnsPath,
            ref int FactCount/*实际产生值*/
            )
        {
            //只需要一个随机种子就够了
            int iRnd = DateTime.Now.Millisecond;
            Random rand = new Random(iRnd);
            //需要一个用来判重的HashSet
            HashSet<string> MinusHash = new HashSet<string>();
            //按照操作符上限生成
            StringBuilder buildExercise = new StringBuilder();
            StringBuilder buildAnswer = new StringBuilder();
            DateTime time1=DateTime.Now, time2;
            int i = 0;
            try {
                for (i = 0; i < exerciseCount;)
                {
                    try {
                        //在1和OpCount之间生成一个操作符的数量,注意这里的opCount是需要带上+1的！！
                        int OpCount = rand.Next(1, opCount + 1);
                        string[] operation = GenerateOperation(rand, OpCount, hasMultDiv);
                        //因为操作数总比操作符多1个，所以FracCount=OpCount+1
                        int FracCount = OpCount + 1;
                        Fraction[] Numbers = GenerateNumber(rand, FracCount, hasNegative/*控制生成的数里是否有负数*/, hasFrac/*生成的数里是否有分数*/, leftRange, rightRange);
                        //生成一个表达式啦!
                        ExpTree Expression = new ExpTree(Numbers, operation, hasNegative, hasBrack, hasFrac, leftRange, rand);
                        /*，如果最后出现了超过范围的数，会被转换成负数，那该怎么办呢... [FIXME]*/
                        //如果发现之前已经有重复的式子了，那就重新生成一个
                        if (MinusHash.Contains(Expression.TreeMinusLamda))
                        {
                            time2 = DateTime.Now;
                            TimeSpan Ts = time2 - time1;
                            if (Ts.Seconds >= 20)
                                throw new MyException.OwnException("这式子要爆炸！");
                            continue;
                        }
                        i++;
                        MinusHash.Add(Expression.TreeMinusLamda);
                        buildExercise.Append(i + "." + Expression.TreeInfix + Environment.NewLine);
                        buildAnswer.Append(i + "." + Expression.Answer + Environment.NewLine);
                        time1 = DateTime.Now;
                    }
                    //如果遭遇了溢出错误，则继续生成...
                   catch (System.OverflowException)
                    {
                        time2 = DateTime.Now;
                        TimeSpan Ts = time2 - time1;
                        if (Ts.Seconds >= 20)
                            throw new MyException.OwnException("这式子要爆炸！");
                        continue;
                    }
                }
            }
            catch(MyException.OwnException)
            {
                throw new MyException.TooManyException("抱歉，我实在产生不了这么多式子，放过我吧...");
            }
            finally
            {
                FactCount = i;
                ExeToFile(buildExercise,ExePath);
                AnsToFile(buildAnswer,AnsPath);
            }
        }

        //生成合法的预定数量的表达操作符
        public string[] GenerateOperation(Random rand,int count,bool hasMultDiv)
        {
            string[] operation = new string[count];
            for (int i = 0; i < count ; i++)
            {
                int RandKey = rand.Next(0, 4);
                if (RandKey == 0)
                    operation[i] = "+";
                else if (RandKey == 1)
                    operation[i] = "-";
                else if (RandKey == 2 && hasMultDiv)
                    operation[i] = "×";
                else if (RandKey == 2 && !hasMultDiv)
                    operation[i] = "+";
                else if (RandKey == 3 && hasMultDiv)
                    operation[i] = "÷";
                else
                    operation[i] = "-";
            }
            return operation;
        }

        //生成合法的预定数量的分数或整数组合 FracCount=OpCount+1
        public Fraction[] GenerateNumber(Random rand, int count,bool hasNegative,bool hasFrac,int leftRange,int rightRange)
        {
            Fraction[] Number = new Fraction[count];
            long RandDe;
            long RandMo;
            long Int;
            int IsNega = 0;//默认没有负数
            //Note:我为什么舍弃这段代码?因为没用...
            //if (hasNegative)
            //    leftRange = -leftRange;
            for (int i = 0; i < count; i++)
            {
                //如果可以有负数，就摇色子
                if (hasNegative)
                    IsNega = rand.Next(0, 2);
                //如果要求生成的是分数
                if (hasFrac)
                {
                    //先生成分母
                    RandDe = GetLongRandom(leftRange, rightRange, rand);
                    //如果生成的分母为0，则将其置为1
                    if (RandDe == 0)
                        RandDe = 1;
                    //生成的带分数的范围要控制在leftRange ~ rightRange之间，所以如下范围
                    RandMo = GetLongRandom(leftRange * RandDe, rightRange * RandDe, rand);
                    //生成一个分母不为0的分数表达式
                    Fraction number = new Fraction(RandMo, RandDe);
                    Number[i] = number;
                }
                //如果要求不能生成分数
                else
                {
                    //生成一个值域范围内的整数
                    Int = GetLongRandom(leftRange, rightRange, rand);
                    //构造一个整数式
                    Fraction number = new Fraction(Int, 1);
                    Number[i] = number;
                }
                //默认是0，如果不幸摇色子摇中了，就变成负数了
                if (IsNega == 1)
                    Number[i] = 0 - Number[i];
            }
            return Number;
        }

        //将题目写入指定文件
        public void ExeToFile(StringBuilder Exercise,string ExePath)
        {
            FileStream stream = new FileStream(ExePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream, Encoding.Unicode);
            sw.Write(Exercise);
            sw.Flush();
            sw.Close();
            stream.Close();
        }

        //将答案写入指定文件
        public void AnsToFile(StringBuilder Answer,string AnswerPath)
        {
            FileStream stream = new FileStream(AnswerPath, FileMode.Create);
            StreamWriter sw = new StreamWriter(stream, Encoding.Unicode);
            sw.Write(Answer);
            sw.Flush();
            sw.Close();
            stream.Close();
        }
    }
}
