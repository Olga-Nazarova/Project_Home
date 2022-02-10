// Подсчитать сумму цифр в числе
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int x = int.Parse(Console.ReadLine());
            int s = 0;

            while (x > 0)
            {
                s = s + x % 10;
                x = x / 10;
            }
            Console.WriteLine(s);
        }
    }
}
