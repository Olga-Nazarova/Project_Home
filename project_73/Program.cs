// Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = CheckInputIsNumber("Введите первое число: ");
            //int k = CheckInputIsNumber("Введите первое число: "); 
            int N = 7;
            int a = 3;
            int b = 5;
            int Metod(int x, int y, int num)
            {
                if (num == 1) return x;
                if (num == 2) return y;
                return Metod(x, y, num - 1) + Metod(x, y, num - 2);
            }
            //Console.WriteLine(Metod(a,b,N));
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{Metod(a, b, i)} ");
            }
            Console.WriteLine();
        }
    }
}

