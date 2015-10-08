using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Calc
{
    public class ExpTree
    {
        public Node Root;
        public string TreeMinusLamda;
        public string TreeInfix;
        public string Answer = "";
        //指示减法过程中是否出现负数
        public bool HasNegative = false;
        //指示除法过程中是否出现分数
        public bool HasFrac = false;
        //指示生成的表达式中是否含有括号
        public bool HasBrack = false;
        //leftRange是为了随机数生成的时候而用
        public int LeftRange;
        /////////////////////////////////
        //  public string Suffix;      //
        //  For test                   //
        /////////////////////////////////

        //Note:表达式树的构造函数，括号选项为HasBrack，默认为无括号
        public ExpTree(Fraction[] numbers,string[] operation,bool hasNegative,bool hasBrack,bool hasFrac,int leftRange,Random rand)
        {
            this.HasNegative = hasNegative;
            this.HasFrac = hasFrac;
            this.HasBrack = hasBrack;
            this.LeftRange = leftRange;
            //根据是否有括号生成是否有括号的树
            if (hasBrack)
                GenerateTreeWithBrack(numbers, operation,rand,LeftRange);
            else
                GenerateTreeWithoutBrack(numbers, operation,rand,LeftRange);
        }
        

        //因为裂解而被废弃的代码——如果可能有所优化的话——在Amend里使用
        ////Note:这个生成是为了通过裂解产生一种带括号式子除法只可能整除的例子
        ////这种情况下，数字都是整数，所以好解决。
        //public void GenerateBinaryWithoutFrac(string[] operation)
        //{

        //}

        //Note:生成一颗有几率带括号的表达式树
        //步骤:生成一个二叉树，再得到答案，然后中序遍历得到中缀表达式
        public void GenerateTreeWithBrack(Fraction[] numbers, string[] operation,Random rand,int leftRange)
        {
            Stack<string> StackOp = new Stack<string>(operation);
            Stack<Fraction> StackNum = new Stack<Fraction>(numbers);
            //根据numbers和opertaion数组生成根结点——改变了Root
            GenerateBinaryTree(ref this.Root,ref StackNum,ref StackOp,rand);
            //对表达树进行适当的修补与改动，使其合法——改变了表达式树
            Answer = AmendTreeAndCalculate(this.Root,leftRange).ToString();
            //通过表达式树，生成一个带括号的中缀表达式
            TreeInfix = InOrderToInfixWithBrack(this.Root) +" =";
            //生成最小表示法生成的表达式树
            TreeMinusLamda = GenerateMinusExp(this.Root);
        }

        public void GenerateBinaryTree(ref Node root,ref Stack<Fraction> StackNum,ref Stack<string> StackOp,Random rand)
        {
            //先看是不是根结点
            if(root==null)
                root = new Node(StackOp.Pop());
            if(StackOp.Count()==0)
            {
                root.Left = new Node(StackNum.Pop().ToString());
                root.Right = new Node(StackNum.Pop().ToString());
                return;
            }
            int RandKey = rand.Next(0,3);
            //如果两边都是符号的话，则两边都递归
            if(RandKey==0)
            {
                root.Left = new Node(StackOp.Pop());
                //一次Pop之后栈可能为空了，所以要注意判断
                if (StackOp.Count == 0)
                {
                    //如果栈空了要注意对左侧进行递归
                    root.Right = new Node(StackNum.Pop().ToString());
                    GenerateBinaryTree(ref root.Left, ref StackNum, ref StackOp, rand);
                }
                else
                {
                    root.Right = new Node(StackOp.Pop());
                    GenerateBinaryTree(ref root.Left, ref StackNum, ref StackOp, rand);
                    GenerateBinaryTree(ref root.Right, ref StackNum, ref StackOp, rand);
                }
            }
            //如果左边是符号，右边是数字的话，则只进行左边的递归
            else if(RandKey==1)
            {
                root.Left = new Node(StackOp.Pop());
                root.Right = new Node(StackNum.Pop().ToString());
                GenerateBinaryTree(ref root.Left,ref StackNum,ref StackOp,rand);
            }
            //如果右边是符号，左边是数字的话，则只进行右边的递归
            else{
                root.Right = new Node(StackOp.Pop());
                root.Left = new Node(StackNum.Pop().ToString());
                GenerateBinaryTree(ref root.Right,ref StackNum,ref StackOp,rand);
            }
        }
        //通过层次遍历的方法直接生成一颗二叉树
        //  public void GenerateBinaryTree(Fraction[] numbers,string[] operation)
        //  {
        //      //将两个数组混合成为一个队列，当队列为空时标明二叉树建立成功
        //      Queue<Node> Nodes = new Queue<Node>();
        //      foreach(string op in operation)
        //          Nodes.Enqueue(new Node(op));
        //      foreach(Fraction num in numbers)
        //          Nodes.Enqueue(new Node(num.ToString()));
        //      //设立一个队列用于按层次构建二叉树
        //      Queue<Node> NodeQ = new Queue<Node>();
        //      //以Nodes[0]建立根结点
        //      //从待选取队列中除去头结点
        //      Root = Nodes.Dequeue();
        //      //根结点入队
        //      NodeQ.Enqueue(Root);
        //      //当待选取队列不为空的时候要一直出队入队进行
        //      while (Nodes.Count()!=0)
        //      {
        //          //头结点出队
        //          Node Head = NodeQ.Dequeue();
        //          //如果没有左结点，则从Nodes中获取
        //          if (Head.Left == null)
        //              Head.Left = Nodes.Dequeue();
        //          //由于该结点已经被选取了并加入了树中，所以加入NodeQ中
        //          NodeQ.Enqueue(Head.Left);
        //          //如果没有右结点，则从Nodes中获取
        //          if (Head.Right == null)
        //              Head.Right = Nodes.Dequeue();
        //          //由于右结点已经被选取了并加入了树中，所以加入NodeQ中
        //          NodeQ.Enqueue(Head.Right);
        //      }            
        //  }
        
        //中序遍历得到二叉树对应中缀表达式
        public string InOrderToInfixWithBrack(Node root)
        {
            //如果不是为叶结点或者不是根结点，则加括号
            if (!root.IsLeaf() && root != Root)
                return "( " + InOrderToInfixWithBrack(root.Left) + " " + root.Value +
                    " " + InOrderToInfixWithBrack(root.Right) + " )";
            //如果不是叶结点却是根结点
            else if (!root.IsLeaf())
                return InOrderToInfixWithBrack(root.Left) + " " + root.Value +
                    " " + InOrderToInfixWithBrack(root.Right);
            else
                return root.Value;
        }

        //在修补不带括号的表达式后要重新生成一下其表达式，同样不能带括号
        public string InOrderToInfixWithoutBrack(Node root)
        {
            if (root.Left == null && root.Right == null)
                return root.Value;
            return InOrderToInfixWithoutBrack(root.Left) + " " + root.Value +
            " " + InOrderToInfixWithoutBrack(root.Right);
        }

        //Note:生成一颗不可能带括号的树
        //步骤:先生成一个中缀表达式，再生成一颗二叉树
        public void GenerateTreeWithoutBrack(Fraction[] numbers,string[] operations,Random rand,int leftRange)
        {
            StringBuilder temp = new StringBuilder();
            //通过给定的numbers和operations生成不带括号的中缀表达式
            for(int i=0;i<numbers.Count();i++)
            {
                temp.Append(numbers[i].ToString() + " ");
                //在生成不带括号的表达式时，必须得学会反转
                if (i==numbers.Count()-1)
                    break;
                //如果不带括号表达中出现了 x/0的情况，由于除法是左结合所以只要保证除法右侧的数不为0即可
                if (operations[i] == "÷" && numbers[i + 1].GetMo() == 0)
                    numbers[i + 1] = new Fraction(1, 1);
                //要求整除的前提下，这时候都是整数参与运算，没有分数
                else if(operations[i] == "÷" && !HasFrac)
                {
                    //如果本来就整除就不需要费事了...
                    if (numbers[i].GetMo() % numbers[i + 1].GetMo() != 0 && 
                       (i==0 || operations[i-1]=="+" || operations[i-1]=="-" || operations[i-1]== "×"))
                    {
                        //在leftRange到numbers[i]的范围内取一随机数，求它与numbers[i]的分子的最大公约数
                        int a = rand.Next(leftRange, Math.Abs((int)numbers[i].GetMo()) + 1);
                        long gcd = Fraction.GetGCD(numbers[i].GetMo(), a);
                        //令numbers[i+1]的值为该数
                        numbers[i + 1] = new Fraction(gcd, 1);
                    }
                }
                temp.Append(operations[i]+" ");
            }
            //获得了不带括号的中缀表达式，接下来要将它变为一颗树，这里一定要带=，这是判断的条件之一
            TreeInfix = temp.ToString() +" =";
            //中缀表达式要先转成后缀表达式
            string Suffix = InfixToSuffix(TreeInfix);
            //后缀表达式转成树,设置Root为根结点
            SuffixToTree(Suffix);
            //通过对树的修补进行表达式的合法化
            Answer = AmendTreeAndCalculate(this.Root,leftRange).ToString();
            //重新生成一个中缀表达式(不加任何括号的)
            TreeInfix = InOrderToInfixWithoutBrack(this.Root) + " =";
            //通过最小表示法生成最小表示序列
            TreeMinusLamda = GenerateMinusExp(this.Root);
        }
        
        //将一个中缀表达式转换为后缀表达式
        public string InfixToSuffix(string Infix)
        {
            //输入一个不带括号的中缀表达式，将其转换为一个后缀表达式
            string[] split = Infix.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //操作符栈
            Stack<string> StackOp = new Stack<string>();
            string Suffix = "";
            foreach(string token in split)
            {
                if (token == "-" || token == "+" || token == "×" || token == "÷")
                {
                    //如果操作符栈是空的，操作符入栈
                    if (StackOp.Count == 0)
                        StackOp.Push(token);
                    //否则比较当前操作符与操作符栈顶操作符的优先级
                    else
                    {
                        //获取当前操作符的优先级
                        int TokenPrior = AnswerGet.getPriority(token);
                        //获取操作符栈栈顶操作符的优先级
                        int TopPrior = AnswerGet.getPriority(StackOp.Peek());
                        //如果当前操作符优先级比栈顶操作符优先级大，则入栈
                        if (TokenPrior > TopPrior)
                            StackOp.Push(token);
                        else
                        {
                            //否则一直弹出并加入到后缀表达式中，到当前操作符优先级比栈顶的大为止
                            while (TokenPrior <= TopPrior)
                            {
                                //操作符出栈，加入到后缀表达式中
                                Suffix += " " + StackOp.Pop() + " ";
                                if (StackOp.Count > 0)
                                    //获取栈顶操作符的优先级
                                    TopPrior = AnswerGet.getPriority(StackOp.Peek());
                                else
                                    break;
                            }
                            //这时操作符优先级比栈顶的大，或者栈顶已经被清空
                            StackOp.Push(token);
                        }
                    }
                }
                else if(token=="=")
                {
                    while (StackOp.Count != 0)
                    {
                        //操作符进入后缀表达式，直到操作符栈为空
                        Suffix += " " + StackOp.Pop() + " ";
                    }
                }
                else
                    Suffix += " "+token+" ";
            }
            return Suffix+" =";
        }

        //将一个后缀表达式转换为一个二叉树
        public void SuffixToTree(string Suffix)
        {
            Stack<Node> Stack = new Stack<Node>();
            string[] split = Suffix.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string token in split)
            {
                if (token == "-" || token == "+" || token == "×" || token == "÷")
                {
                    //栈中先弹出的是右儿子
                    Node RChild = Stack.Pop();
                    //后弹出的是左儿子
                    Node LChild = Stack.Pop();
                    //以左结点与右结点和当前键值构建根结点，并压入栈
                    Node tokenRoot = new Node(token, LChild, RChild);
                    Stack.Push(tokenRoot);
                }
                //否则可能是等号，则令当前Root=栈顶的结点
                else if (token == "=")
                {
                    Root = Stack.Pop();
                    break;
                }
                //如果是操作数的话需要压栈
                else
                    Stack.Push(new Node(token));
            }
        }

        //根据root递归生成最小表示法获得的字符串
        public string GenerateMinusExp(Node root)
        {
            //如果是叶结点的话，则直接返回该结点的值
            if (root.IsLeaf())
                return root.Value;
            else if (root.Value == "+" || root.Value == "×")
            {
                //对左子树进行递归，得到左子树的最小表示字符串
                string LeftMinus = GenerateMinusExp(root.Left);
                //对右子树进行递归，得到右子树的最小表示字符串
                string RightMinus = GenerateMinusExp(root.Right);
                //对左子树和右子树进行统一排序
                if (string.Compare(LeftMinus, RightMinus) <= 0)
                    return root.Value + LeftMinus + RightMinus;
                else
                    return root.Value + RightMinus + LeftMinus;
            }
            //否则就按照正常次序进行最小字符串表示
            else
                return root.Value + GenerateMinusExp(root.Left) + GenerateMinusExp(root.Right);
        }

        //翻转子树，为了修补程序所用
        public void Transfer(Node root)
        {
            Node Temp;
            Temp = root.Left;
            root.Left = root.Right;
            root.Right = Temp;
        }

        //修正树结构，并计算得出最后的值。
        //修正包括范围：
        //1.减法中产生负数的情况(包括 有括号 与 无括号式子)
        //2.除法中需要整除的情况(这里只会修复有括号式子，无括号式子的情况已经在生成时修复了)
        //3.除法出现除数为0的情况(全部修复)
        public Fraction AmendTreeAndCalculate(Node root,int leftRange)
        {
            if (root.Left == null && root.Right == null)
                return (Fraction)root.Value;
            switch(root.Value)
            {
                case "+":return AmendTreeAndCalculate(root.Left,leftRange)+ AmendTreeAndCalculate(root.Right,leftRange);
                case "-":
                    Fraction LExp = AmendTreeAndCalculate(root.Left,leftRange);
                    Fraction RExp = AmendTreeAndCalculate(root.Right,leftRange);
                    //如果结果为负数的话且是没有括号的式子
                    //不允许结果中出现负数的话，就把两颗子树翻转
                    //并且要重新生成中缀表达式和最小表达式
                    if ((RExp > LExp) & !HasNegative & HasBrack)
                        Transfer(root);
                    //针对没有括号的情况
                    else if((RExp > LExp) & !HasNegative)
                    {
                        root.Value = "+";
                        return LExp + RExp;
                    }
                    return LExp - RExp;
                case "×":return AmendTreeAndCalculate(root.Left,leftRange) * AmendTreeAndCalculate(root.Right,leftRange);
                case "÷":
                    Fraction divider = AmendTreeAndCalculate(root.Left,leftRange) ;
                    Fraction divisor = AmendTreeAndCalculate(root.Right,leftRange);
                    //如果发现被除数不是0，而除数是0的话，就翻转两颗子树
                    if (divisor.GetMo() == 0 && divider.GetMo() != 0)
                    {
                        Transfer(root);
                        return 0;
                    }
                    //如果不幸发现被除数和除数同时为0的话，那么还是默默地改掉这个符号吧...
                    else if (divisor.GetMo() == 0 && divider.GetMo() == 0)
                    {
                        //除法自此改名为加法
                        root.Value = "+";
                        return 0;
                    }
                    //如果在满足了有效性的条件下，突然发现老板加了任务：你必须给我搞个整除出来，咋办？
                    if(!HasFrac)
                    {
                        //如果你天生就能整除，我何必遭受这个罪呢...
                        if (divider.GetMo() % divisor.GetMo() == 0)
                            return divider.GetMo() / divisor.GetMo();
                        //但如果你天生不能整除可咋办呢？
                        else
                        {
                            //求得左侧被除数随机化产生的一个因子
                            int iRnd = DateTime.Now.Millisecond;
                            Random rand = new Random(iRnd);
                            //注意这里值域的下限
                            int a = rand.Next(leftRange, Math.Abs((int)divider.GetMo()));
                            long gcd = Fraction.GetGCD(divider.GetMo(), a);
                            //舍弃右侧原有子树，使用新的结点来代替，除法结果是 divider / gcd
                            root.Right =new Node(new Fraction(gcd, 1).ToString());
                            return divider.GetMo() / gcd;
                        }
                    }
                    return divider / divisor;
                default:
                    throw new MyException.OwnDivException("啊呀呀，在计算的时候出了奇怪的错误。");
            }
        }

    }
    public class Node
    {
        public Node Left;
        public Node Right;
        public string Value;
        //非叶结点的构造方法(非叶结点必然含有两个子结点）
        public Node(string value, Node left,Node right)
        {
            this.Left = left;
            this.Right = right;
            this.Value = value;
        }
        //叶子结点的构造方法
        public Node(string value)
        {
            this.Left = null;
            this.Right = null;
            this.Value = value;
        }

        public bool IsLeaf()
        {
            if (Left == null && Right == null)
                return true;
            return false;
        }
    }
}
