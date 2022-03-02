// Показать натуральные числа от 1 до N, N задано
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func(1, 10);
        }

        private static void Func(int num1, int num2)
        {
            Console.Write($"{num1} ");
            if (num1 < num2)
                Func(num1+1, num2);
            else
                Console.ReadKey();
        }
    }
}
