using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roject_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void NaturalRecurce(int n)
        {
            if (n >= 1)
            {
                Console.Write($"{n}, ");
                n--;
                NaturalRecurce(n);
            }
        }
    }
}
