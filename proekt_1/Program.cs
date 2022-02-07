// По двум заданным числам проверять является ли первое квадратом второго
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 * n1 == n)
            Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
