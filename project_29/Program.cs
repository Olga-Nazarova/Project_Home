// Написать программу вычисления произведения чисел от 1 до N
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N: ");
            long a = long.Parse(Console.ReadLine());
            long i = 1;
            long num = 1;
            while (i <= a)
            {
                num = num * i;
                i++;
            }
            Console.WriteLine("Произведение чисел равно " + num);

        }
    }
}
