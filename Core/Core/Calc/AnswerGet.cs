using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using WindowsFormsApplication2.MyException;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2.Calc
{
    public class AnswerGet
    {
        //传入的不带序号的表达式
        string Exeline;
        //包含了每个token的Exercise数组
        string[] Exercise;
        //表达式的值
        string Answer = "";

        //构造函数，在构造时就根据exeline检查有效性，并计算生成Answer
        public AnswerGet(string exeline)
        {
            try
            {
                this.Exeline = exeline;
                //根据Exeline生成Exercise数组
                CheckSimExpValid();
                //根据Exercise数组生成Answer
                CalcSimMediaExp();
            }
            catch (System.OverflowException)
            {
                throw new MyException.OwnException("输入的数太大啦，计算不了啦~");
            }
        }

        //根据符号获得其优先级用于堆栈判断
        public static int getPriority(string opt)
        {
            int priority = 0;
            //# 是 处理过的负号
            if (opt == "#")
                priority = 4;
            else if (opt == "×" || opt == "÷")
                priority = 3;
            else if (opt == "+" || opt == "-")
                priority = 2;
            else if (opt == "(")
                priority = 1;
            return priority;
        }

        //给定堆栈和运算符，计算值
        public static void calculate(ref Stack<Fraction> StackNum, string op)
        {
            try
            {
                if (op == "#")
                //#是负号运算替换值
                {
                    Fraction First = StackNum.Pop();
                    Fraction Result = 0 - First;
                    StackNum.Push(Result);
                }
                else if (op == "+")
                {
                    Fraction Second = StackNum.Pop();
                    Fraction First = StackNum.Pop();
                    Fraction Result = First + Second;
                    StackNum.Push(Result);
                }
                else if (op == "-")
                {
                    Fraction Second = StackNum.Pop();
                    Fraction First = StackNum.Pop();
                    Fraction Result = First - Second;
                    StackNum.Push(Result);
                }
                else if (op == "×")
                {
                    Fraction Second = StackNum.Pop();
                    Fraction First = StackNum.Pop();
                    Fraction Result = First * Second;
                    StackNum.Push(Result);
                }
                else if (op == "÷")
                {
                    Fraction Second = StackNum.Pop();
                    Fraction First = StackNum.Pop();
                    if (Second.GetMo() == 0)
                        throw new MyException.OwnException("除数不能为0哦！");
                    Fraction Result = First / Second;
                    StackNum.Push(Result);
                }
            }
            catch (System.InvalidOperationException)
            {
                throw new MyException.OwnException("啊，题目表达式出错了！");
            }
        }

        //计算未经过语义检查的表达式的值，并以字符串形式返回该表达式的答案
        public void CalcSimMediaExp()
        {
            /**
             *可能出现的错误有:
             * 1.左右括号不匹配
             * 2.运算符号与运算数的数量和关系出错
             */
            //定义操作数栈
            Stack<Fraction> StackNum = new Stack<Fraction>();
            //定义操作符栈
            Stack<string> StackOp = new Stack<string>();
            foreach (string token in Exercise)
            {
                try
                {
                    if (token == "-" || token == "+" || token == "×" || token == "÷" || token == "#")
                    {
                        //如果操作符栈是空的，操作符入栈
                        if (StackOp.Count == 0)
                            StackOp.Push(token);
                        //否则比较当前操作符与操作符栈顶操作符的优先级
                        else
                        {
                            //获取当前操作符的优先级
                            int TokenPrior = getPriority(token);
                            //获取操作符栈栈顶操作符的优先级
                            int TopPrior = getPriority(StackOp.Peek());
                            //如果当前操作符优先级比栈顶操作符优先级大，则入栈
                            if (TokenPrior > TopPrior)
                                StackOp.Push(token);
                            else
                            {
                                //否则一直计算，到当前操作符优先级比栈顶的大为止
                                while (TokenPrior <= TopPrior)
                                {
                                    //操作符出栈，参与运算，这过程中可能会产生异常
                                    calculate(ref StackNum, StackOp.Pop());
                                    if (StackOp.Count > 0)
                                        //获取栈顶操作符的优先级
                                        TopPrior = getPriority(StackOp.Peek());
                                    else
                                        break;
                                }
                                //这时操作符优先级比栈顶的大，或者栈顶已经被清空
                                StackOp.Push(token);
                            }
                        }
                    }
                    else if (token == "(")
                        StackOp.Push(token);
                    else if (token == ")")
                    {
                        while (StackOp.Peek() != "(")
                        {//当栈顶不是 ( 时，
                            calculate(ref StackNum, StackOp.Pop());
                        }
                        if (StackOp.Count == 0)
                            throw new MyException.OwnException("表达式中括号匹配有问题哦！");
                        //把 ( 出栈，结束括号运算
                        StackOp.Pop();
                    }
                    else if (token == "=")
                    {
                        while (StackOp.Count != 0)
                        {
                            //操作符弹栈，运算，直到操作符栈为空
                            calculate(ref StackNum, StackOp.Pop());
                        }
                    }
                    else
                        StackNum.Push(token);
                }
                catch (System.InvalidOperationException)
                {
                    throw new MyException.OwnException("运算符和操作数的数量不匹配！");
                }
            }
            //如果操作数栈里的操作数不为1，则抛出异常
            if (StackNum.Count != 1)
                throw new MyException.OwnException("表达式操作符的数目不够！");
            //栈顶存放的是结果
            Answer = StackNum.Peek().ToString();
        }

        //检查单个表达式的格式：(1+2)*3 =
        public void CheckSimExpValid()
        {
            #region(检查表达式格式的正确性)
            List<string> Token = new List<string>();
            //去掉输入的字符串中的空格，便于负号和减号的判断
            Exeline = Exeline.Replace(" ", "");
            char[] Temp = Exeline.ToCharArray();
            //使用StringBUilder来提升性能
            StringBuilder Exp = new StringBuilder("", 25);
            //为了获取前一个的值来判断，不使用foreach结构
            for (int i = 0; i < Temp.Count(); i++)
            {
                char s = Temp[i];
                if (s == '(' || s == '+' || s == ')' || s == '÷' || s == '×')
                    //如果是运算符则前后空1格
                    Exp.Append(" " + s + " ");
                //如果s为-，前面如果为 ) 或 数字时，则s是减号
                else if (s == '-' && i > 0 && (Temp[i - 1] == ')' || Char.IsNumber(Temp[i - 1])))
                    Exp.Append(" - ");
                //在s=='-'时，排除减号的情况，剩下的就是负号
                else if (s == '-')
                    Exp.Append(" # ");
                //在s不为任何符号时,说明是分数表达式中的某一部分
                else if (s == '=')
                {
                    if (i != Temp.Count()-1)
                        throw new MyException.OwnException("等号后面是不是还有什么东西？");
                    Exp.Append(" = ");
                }
                else
                    Exp.Append(s);
            }
            String ExpSplit = Exp.ToString();
            //根据空格将表达式分离成单独的token
            string[] split = ExpSplit.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //这里不判断除运算符号外的其他值是否符合分数定义形式，在Fraction的string强制类型转换处会判断。
            #endregion
            Exercise = split;
        }

        //获得某个Exercise的答案
        public string getAnswer()
        {
            return Answer;
        }
    }
}
