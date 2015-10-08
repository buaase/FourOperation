using System;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2.Calc
{
    public class Fraction
    {
        private long Molecular;
        //Molecular是分子
        private long Denomiator;
        //Denomiator是分母

        public Fraction(long molecular, long denomiator)
        {
            //Note:Molecular 是分子，Denomiator是分母，这里可以是一个假分数传入
            //计算时都使用假分数计算，但是在显示时使用真分数
            this.Molecular = molecular;
            if (denomiator == 0)
                throw new MyException.OwnException("有表达式中出现了分母为0！");
            this.Denomiator = denomiator;
            Fraction.Reduce(ref this.Molecular, ref this.Denomiator);
        }

        public long GetMo()
        {
            return this.Molecular;
        }

        public long GetDe()
        {
            return this.Denomiator;
        }

        public static void Reduce(ref long Mo, ref long De)
        {
            //这个函数是为了将函数式化简为最简式
            if (Mo == 0)
            {
                De = 1;
                return;
            }
            long gcd = GetGCD(Mo, De);
            Mo /= gcd;
            De /= gcd;
        }

        public override String ToString()
        {
            String Disint = "", DisMo = "", DisDe = "";
            checked
            {
                if (Molecular == 0)
                    Disint = "0";
                else if (Math.Abs(Molecular) >= Math.Abs(Denomiator) && Molecular % Denomiator == 0)
                    //如果分子正好可以整除分母的话，那么就是一个整数式
                    Disint = (Molecular / Denomiator).ToString();
                else if (Math.Abs(Molecular) > Math.Abs(Denomiator))
                //如果分子虽然大于分母（假分数）但是无法整除，就是一个带余分数
                {
                    if ((Molecular > 0 && Denomiator > 0) || (Molecular < 0 && Denomiator < 0))
                    {
                        //结果为正带分数的情况
                        //可能有两种，一种是分母分子都有负数。一种是分母没负数，分子没负数。
                        Disint = (Molecular / Denomiator).ToString() + "'";
                        DisMo = Math.Abs((Molecular % Denomiator)).ToString() + "/";
                        DisDe = Math.Abs(Denomiator).ToString();
                    }
                    else
                    {
                        //结果为负带分数的情况
                        Disint = (Molecular / Denomiator).ToString() + "'";
                        DisMo = (Math.Abs(Molecular % Denomiator)).ToString() + "/";
                        DisDe = Math.Abs(Denomiator).ToString();
                    }
                }
                else
                //如果分子没有分母大的话，就是一个真分数
                {
                    //真分数里也有表示的问题
                    //结果为正真分数时
                    if ((Molecular > 0 && Denomiator > 0) || (Molecular < 0 && Denomiator < 0))
                    {
                        DisMo = Math.Abs(Molecular).ToString() + "/";
                        DisDe = Math.Abs(Denomiator).ToString();
                    }
                    else
                    {
                        DisMo = (-Math.Abs(Molecular)).ToString() + "/";
                        DisDe = Math.Abs(Denomiator).ToString();
                    }
                }
                return Disint + DisMo + DisDe;
            }
        }

        public static long GetGCD(long m, long n)
        {
            //获取m和n的 绝对值 最大公约数。
            m = Math.Abs(m);
            n = Math.Abs(n);
            if (m < n)
            {
                long tmp = m;
                m = n;
                n = tmp;
            }
            if (n == 0)
                return m;
            while (n > 0)
            {
                long tmp = m % n;
                m = n;
                n = tmp;
            }
            return m;
        }

        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            long Mo1, Mo2;
            long De1, De2;
            long MoSum, DeSum;
            Mo1 = lhs.GetMo();
            Mo2 = rhs.GetMo();
            De1 = lhs.GetDe();
            De2 = rhs.GetDe();
            //rhs = Mo1/De1 lhs  = Mo2/De2
            checked
            {
                MoSum = Mo1 * De2 + Mo2 * De1;
                DeSum = De1 * De2;
            }
            Fraction.Reduce(ref MoSum, ref DeSum);
            return new Fraction(MoSum, DeSum);
        }

        public static Fraction operator -(Fraction lhs, Fraction rhs)
        {
            long Mo1, Mo2;
            long De1, De2;
            long MoSub, DeSub;
            Mo1 = lhs.GetMo();
            Mo2 = rhs.GetMo();
            De1 = lhs.GetDe();
            De2 = rhs.GetDe();
            //lhs = Mo1/De1 , rhs = Mo2/De2
            checked
            {
                MoSub = Mo1 * De2 - Mo2 * De1;
                DeSub = De1 * De2;
            }
            Fraction.Reduce(ref MoSub, ref DeSub);
            return new Fraction(MoSub, DeSub);
        }

        public static Fraction operator *(Fraction lhs, Fraction rhs)
        {
            long Mo1, Mo2;
            long De1, De2;
            long MoMult, DeMult;
            Mo1 = lhs.GetMo();
            Mo2 = rhs.GetMo();
            De1 = lhs.GetDe();
            De2 = rhs.GetDe();
            checked
            {
                MoMult = Mo1 * Mo2;
                DeMult = De1 * De2;
            }
            Fraction.Reduce(ref MoMult, ref DeMult);
            return new Fraction(MoMult, DeMult);
        }

        public static Fraction operator /(Fraction lhs, Fraction rhs)
        {
            long Mo1, Mo2;
            long De1, De2;
            long MoDiv, DeDiv;
            Mo1 = lhs.GetMo();
            Mo2 = rhs.GetMo();
            De1 = lhs.GetDe();
            De2 = rhs.GetDe();
            checked
            {
                MoDiv = Mo1 * De2;
                DeDiv = Mo2 * De1;
            }
            if (DeDiv == 0)
                throw new MyException.OwnException("除数不能为0！");
            Fraction.Reduce(ref MoDiv, ref DeDiv);
            return new Fraction(MoDiv, DeDiv);
            //lhs = Mo1/De1 rhs = Mo2/De2 , lhs / rhs = (Mo1 *De2)/(Mo2 *De1)
        }

        public static bool operator >(Fraction lhs, Fraction rhs)
        {
            long Mo1, Mo2;
            long De1, De2;
            Mo1 = lhs.GetMo();
            Mo2 = rhs.GetMo();
            De1 = lhs.GetDe();
            De2 = rhs.GetDe();
            //lhs = Mo1/De1 , rhs = Mo2/De2;
            checked
            {
                if (Mo1 == Mo2 && De1 > De2)
                {
                    //如果分子相等，但lhs的分母 大于 rhs的分母，则false
                    return false;
                }
                else if (Mo1 < Mo2 && De1 == De2)
                {
                    //如果分母相等，但lhs的分子 小于 rhs的分子，则false
                    return false;
                }
                else if (Mo1 == Mo2 && De1 == De2)
                    //如果分母相等，分子也相等。
                    return false;
                else
                {
                    //如果分母不相等，分子也不相等，那么则需要通分进行比较
                    long Mo1Sum = Mo1 * De2;
                    long Mo2Sum = Mo2 * De1;
                    if (Mo1Sum > Mo2Sum)
                        return true;
                    else
                        return false;
                }
            }
        }

        public static bool operator <(Fraction lhs, Fraction rhs)
        {
            throw new NotImplementedException();
        }

        //Note:此函数的作用是将一个长整数强制转换为一个分数形式
        public static implicit operator Fraction(long input)
        {
            //implicit 的意思是隐式转换，即自动类型转换
            Fraction output = new Fraction(input, 1);
            return output;
        }
        
        //Note:此函数的作用是将一个字符串强制转换为一个分数形式
        //如果input不符合任何一个表达式的正则文法，则抛出异常
        public static implicit operator Fraction(String input)
        {
            Regex pattern1 = new Regex("^(?<intg>-?\\d+)'(?<Mo>\\d+)\\/(?<De>\\d+)$");
            //带分数形式
            Regex pattern2 = new Regex("^(?<Mo>-?\\d+)\\/(?<De>\\d+)$");
            //真分数形式
            Regex pattern3 = new Regex("^-?\\d+$");
            //整数形式
            Match match1 = pattern1.Match(input);
            Match match2 = pattern2.Match(input);
            Match match3 = pattern3.Match(input);

            if (pattern1.IsMatch(input))
            {
                int De = int.Parse(match1.Groups["De"].Value);
                int Mo = int.Parse(match1.Groups["Mo"].Value);
                int intg = int.Parse(match1.Groups["intg"].Value);
                Fraction R;
                //如果包含负号的话，是一个负带分数
                if (input.Contains("-"))
                    R = new Fraction(intg * De - Mo, De);
                else
                    R = new Fraction(intg * De + Mo, De);
                return R;
            }
            else if (pattern2.IsMatch(input))
            {

                int De = int.Parse(match2.Groups["De"].Value);
                int Mo = int.Parse(match2.Groups["Mo"].Value);
                Fraction R = new Fraction(Mo, De);
                return R;
            }
            else if (pattern3.IsMatch(input))
            {
                return (Fraction)int.Parse(input);
            }
            else
                throw new MyException.OwnException("这个表达式" + input + "格式出错啦！");
        }
    }
}
