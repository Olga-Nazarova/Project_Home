// Показать натуральные числа от M до N, N и M заданы
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Func(10, 50);
            }
        }
        private static void Func(int i, int j)
        {
            Console.Write($"{i} ");
            if (i < j)
                Func(i + 1, j);
            else
                Console.ReadKey();
        }
    }
}
