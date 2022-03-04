using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace project_71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 3;
            Console.WriteLine(MegaAkker(m, n));
        }

        private static BigInteger MegaAkker(BigInteger m, BigInteger n)
        {
            Stack<BigInteger> stack = new Stack<BigInteger>();
            stack.Push(m);
            while (stack.Count != 0)
            {
                m = stack.Pop();
                if (m == 0)
                    n = n + 1;
                else if (n == 0)
                {
                    stack.Push(m - 1);
                    n = 1;
                }
                else
                {
                    stack.Push(m - 1);
                    stack.Push(m);
                    --n;
                }
            }
            return n;
        }
    }
}
