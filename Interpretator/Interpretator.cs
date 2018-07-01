using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpretator
{
    public class NodeR
    {
        public char Operation;
        public int Value;
        NodeR Left;
        NodeR Right;
        public void GetValue()
        {
            if (Operation == ' ')
            {
                return;
            }
            if (Operation == '+')
            {
                Left.GetValue();
                Right.GetValue();
                Value = Left.Value + Right.Value;
            }
            if (Operation == '-')
            {
                Left.GetValue();
                Right.GetValue();
                Value = Right.Value - Left.Value;
            }
        }
        public NodeR(int Value)
        {
            Operation = ' ';
            this.Value = Value;
            Right = null;
            Left = null;
        }
        public NodeR(char Operation, NodeR left, NodeR right)
        {
            this.Operation = Operation;
            this.Value = 0;
            this.Left = left;
            this.Right = right;
        }
    }


    public class Interpretator
    {
        NodeR Root;
        List<int> PointError = new List<int>();
        public List<int> GetPointError
        {
            get
            {
                PointError.Sort();
                return PointError;
            }
            set { }
        }

        void DelGaps(string s, ref int Cur)
        {
            try
            {
                while (s[Cur] == ' ')
                {
                    Cur--;
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new InputError();
            }
        }
        public class InputError : ApplicationException
        {
        }

        public int Inter(string s)
        {
            PointError = new List<int>();
            Root = null;
            FormTree(s);
            Root.GetValue();
            if (PointError.Count != 0)
            {
                throw new InputError();
            }
            return Root.Value;
        }
        void FormTree(string s)
        {
            int Cur = s.Length - 1;
            Root = Expression(s, ref Cur);
        }
        NodeR Expression(string s, ref int Cur)
        {
            try
            {
                DelGaps(s, ref Cur);
            }
            catch (InputError)
            {
                PointError.Add(Cur);
                throw new InputError();
            }
            NodeR A;
            try
            {
                A = ProcessNumber(s, ref Cur);

            }
            catch (InputError)
            {
                PointError.Add(Cur);
                A = new NodeR(0);
            }
            try
            {
                DelGaps(s, ref Cur);
            }
            catch (InputError)
            { 
                return A;
            }

            if (s[Cur] != '-' && s[Cur] != '+')
            {
                PointError.Add(Cur);
                Cur--;
                return Expression(s, ref Cur);
            }
            else
            {
                Cur--;
                return new NodeR(s[Cur + 1], A, Expression(s, ref Cur));
                //1+2+3+4
            }

        }
        NodeR ProcessNumber(string s, ref int Cur)// number processing - обработка числа
        {
            if (!Char.IsDigit(s[Cur]) && (s[Cur] < '0' || s[Cur] > '9'))//&& !Char.IsDigit(s[Cur])
            {
                throw new InputError();
            }
            //исправление ошибки <число><знак>
            //if (!Char.IsDigit(s[Cur]))
            //{
            //    throw new InputError();
            //}
            int Koef = 1;
            int Num = 0;
            while (Cur >= 0 && s[Cur] >= '0' && s[Cur] <= '9')
            {
                //string ss = Convert.ToString(s[Cur]);
                //Num += Convert.ToInt32(ss) * Koef;
                Num += (s[Cur] - '0') * Koef;
                Koef *= 10;
                Cur--;
            }
            return new NodeR(Num);
        }
    }

}
