// Найти кубы чисел от 1 до N
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                a = InputNumber();

                if (a < 1)
                    Console.WriteLine("Вы ввели ноль или отрицательное число. Попробуйте ещё раз");
                else break;
            }

            Console.WriteLine($"Вы ввели число {a}. Программа покажет кубы каждого числа от 1 до {a}");

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine($"Куб числа {i} это {i * i * i}");
            }
        }

        private static int InputNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string inputStr = Console.ReadLine();

                bool isNum = int.TryParse(inputStr, out int chNum);

                if (!isNum)
                    Console.WriteLine("Вы ввели не число. Попробуйте ещё раз");
                else return chNum;
            }
        }
    }
}
